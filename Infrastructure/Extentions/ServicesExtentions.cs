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
using Infrastructure.Repository;
using Application.Contracts;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Localization;
using System.Globalization;
using Application.Contracts.ValidationLocalization;

namespace Infrastructure.Extentions
{
    public static class ServicesExtentions
    {
        // Identity configurations
        public static void ConfigureIdentity(this IServiceCollection services)
        {
            var builder = services.AddIdentity<User, IdentityRole>(o =>
            {
                o.Password.RequireUppercase = false;
                o.User.RequireUniqueEmail = true;
            }).AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultTokenProviders();
            //builder.Services.AddTransient<IValidator<UserRegistrationDTO>, UserValidations>();
        }

        public static void ConfigureLoggerService(this IServiceCollection services) =>
                services.AddSingleton<ILoggerManager, LoggerManager>();

        public static void ConfigureServiceManager(this IServiceCollection services) =>
            services.AddScoped<IServiceManager, ServiceManager>();

        public static void ConfigureLocalization(this IServiceCollection services)
        {
            services.AddLocalization(options => options.ResourcesPath = "Resources\\UserResources");

            services.AddSingleton<IStringLocalizerFactory, ResourceManagerStringLocalizerFactory>();
            services.AddTransient<IUserValidationLocalizationService, UserValidationLocalizationService>();

            services.Configure<RequestLocalizationOptions>(options =>
            {
                var supportedCultures = new[]
                {
                    new CultureInfo("en"),
                    new CultureInfo("it")
                };

                options.DefaultRequestCulture = new Microsoft.AspNetCore.Localization.RequestCulture("en");
                options.SupportedCultures = supportedCultures;
                options.SupportedUICultures = supportedCultures;
            });
        }
    }
}
