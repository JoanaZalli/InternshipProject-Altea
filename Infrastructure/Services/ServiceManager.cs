using Application.Contracts;
using Application.Services.Contracts;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IAuthenticationService> _authenticationService;

        public ServiceManager(IMapper mapper, UserManager<User> userManager, IConfiguration configuration) {
            _authenticationService = new Lazy<IAuthenticationService>(() =>

             new AuthenticationService(userManager, mapper, configuration)
            );
        }
        public IAuthenticationService AuthenticationService =>_authenticationService.Value;
    }
}
