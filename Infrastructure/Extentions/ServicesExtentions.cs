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
using Application.Validations;
using FluentValidation;
using Application.Exceptions;

namespace Infrastructure.Extentions
{
    public static class ServicesExtentions
    {
        // Identity configurations
        public static void ConfigureIdentity(this IServiceCollection services)
        {
            var builder = services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultTokenProviders();
            builder.Services.AddTransient<IValidator<UserRegistrationDTO>, UserValidations>();
        }

        

        public static void ConfigureServiceManager(this IServiceCollection services) =>
            services.AddScoped<IServiceManager, ServiceManager>();

        

    }
}
