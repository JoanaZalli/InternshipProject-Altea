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

        public async Task<string> CreateToken( )
        {
            var signingCredintials = GetSigningCredentials();
            var claims = await GetClaims();
            var tokenOptions = GenerateTokenOptions(signingCredintials, claims);

         
            var accessToken = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

            return accessToken;
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


    }
}