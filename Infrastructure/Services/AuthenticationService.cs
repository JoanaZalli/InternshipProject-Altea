using Application.Contracts;
using Application.DTOS;
using Application.Services.Contracts;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _configuration;
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
    }
}