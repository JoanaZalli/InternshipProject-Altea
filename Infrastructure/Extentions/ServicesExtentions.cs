using Application.DTOS;
using Application.Moduls.UserModul.Commands;
using Application.Services.Contracts;
using Domain.Entities;
using Infrastructure.Services;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Moduls.UserModul;
namespace Infrastructure.Extentions
{
    public static class ServicesExtentions
    {
        // Identity configurations
        public static void ConfigureIdentity(this IServiceCollection services)
        {
            var builder = services.AddIdentity<User, IdentityRole>(o =>
            {
                o.Password.RequireDigit = true;
                o.Password.RequireNonAlphanumeric = true;
                o.Password.RequiredLength = 8;
                o.User.RequireUniqueEmail = true;
            }).AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultTokenProviders();
        }

        public static void ConfigureServiceManager(this IServiceCollection services) =>
            services.AddScoped<IServiceManager, ServiceManager>();

        //public static void ConfigureUserCreateHandler(this IServiceCollection services) =>
        //    services.AddScoped<IRequestHandler<CreateUserCommand, UserRegistrationDTO>, CreateUserCommandHandler>();


    }
}
