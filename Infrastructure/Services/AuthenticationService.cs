using Application;
using Application.Contracts;
using Application.DTOS;
using Application.Exceptions;
using Application.Services.Contracts;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _configuration;

        private User? _user;
        public AuthenticationService(UserManager<User> userManager, IMapper mapper,IConfiguration configuration)
        {
            _userManager = userManager;
            _mapper = mapper;
            _configuration = configuration;
        }

        public async Task<IdentityResult> CreateUser(UserRegistrationDTO userDTO)
        {
            var user=_mapper.Map<User>(userDTO);
            var result=await _userManager.CreateAsync(user,userDTO.Password);
            if (result.Succeeded)
                await _userManager.AddToRoleAsync(user, "Borrower");
            return result;
        }
        public async Task<bool> ValidateUser(UserForAuthenticationDto userForAuth, string cultureId)
        {
            _user = await _userManager.FindByNameAsync(userForAuth.UserName);
            if (_user != null && !_user.EmailConfirmed)
            {
                throw new EmailNotConfirmedException(cultureId);
            }
            var result = (_user != null && await _userManager.CheckPasswordAsync(_user, userForAuth.Password));
           
            if (!result)
            {
                throw new AuthenticationFailedException(cultureId);
            }
            return result;
        }
        public async Task<IdentityResult> UpdateUserPassword(string userId, string newPassword, string cultureId)
        {
            var user=await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                throw new UserNotFoundException(cultureId);
            }
            bool isTokenExpired = TokenGenerator.IsTokenExpired(user.TokenCreationTime,15);
            if (isTokenExpired)
            {
                throw new TokenExpiredException(cultureId);
            }
            var result = await _userManager.ResetPasswordAsync(user, user.Token, newPassword);
            if (result.Succeeded)
            {
                user.Token = null;
                user.TokenCreationTime = default(DateTime);
                await _userManager.UpdateAsync(user);
            }

            return result;

        }
        public async Task<AuthenticationTokenDTO> CreateToken(bool populateExp)
        {
            var signingCredintials = GetSigningCredentials();
            var claims = await GetClaims();
            var tokenOptions = GenerateTokenOptions(signingCredintials, claims);
            var accessToken = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

            var refreshToken = GenerateRefreshToken();
            _user.RefreshToken = refreshToken;
            _user.AccesToken = accessToken;
            _user.AccesTokenExpiryTime = DateTime.Now.AddMinutes(20);
            if (populateExp)
                _user.RefreshTokenExpiryTime = DateTime.Now.AddDays(7);
            await _userManager.UpdateAsync(_user);
            

            return new AuthenticationTokenDTO(accessToken, refreshToken);
        }

        private SigningCredentials GetSigningCredentials()
        {

            var key = Encoding.UTF8.GetBytes(_configuration.GetSection("JwtSettings:secret").Value); //kontrolloje kete
            var secret = new SymmetricSecurityKey(key);
            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }
        private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims)
        {
            var jwtSettings = _configuration.GetSection("JwtSettings");

            var tokenOptions = new JwtSecurityToken(
                issuer: jwtSettings["validIssuer"],
                audience: jwtSettings["validAudience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(Convert.ToDouble(jwtSettings["expires"])), signingCredentials: signingCredentials
                );

            return tokenOptions;
        }
        private async Task<List<Claim>> GetClaims()
        {
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, _user.UserName)
            };
            var roles = await _userManager.GetRolesAsync(_user);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }
            return claims;
        }

        private string GenerateRefreshToken()
        {
            var randomNr= new byte[32];
            using (var rng= RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNr);
                return Convert.ToBase64String(randomNr);
            }
        }

        private ClaimsPrincipal GetPrincipalFromExpiredToken(string token)
        {
            var key = _configuration.GetSection("JwtSettings:secret").Value;
            var jwtSettings = _configuration.GetSection("JwtSettings");

            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateAudience = true,
                ValidateIssuer = true,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key)),
                ValidateLifetime = true,
                ValidIssuer = jwtSettings["validIssuer"],
                ValidAudience = jwtSettings["validAudience"]
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken securityToken;
            var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out securityToken);
            var jwtSecurityToken = securityToken as JwtSecurityToken;
            if (jwtSecurityToken == null || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256,
            StringComparison.InvariantCultureIgnoreCase))
            {
                throw new SecurityTokenException("Invalid token");
            }
            return principal;

        }


    }
}