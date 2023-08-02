using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;
using NLog;
using Application.Contracts.Repositories;
using Infrastructure.Repositories;
using Infrastructure.Services;
using Infrastructure.Extentions;
using Application.DTOS;
using FluentValidation;
using MediatR;
using Application.Contracts;
using AutoMapper;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Application.Mappers;
using Application.Models;

var builder = WebApplication.CreateBuilder(args);
LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));

builder.Services.AddControllers();

// Database configuration
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Identity configuration
builder.Services.AddAuthentication();
builder.Services.ConfigureIdentity();

// HttpClient
builder.Services.AddHttpClient();

// AutoMapper
builder.Services.AddAutoMapper(typeof(Program));

// Add AutoMapper
builder.Services.AddSingleton(provider =>
{
    var config = new MapperConfiguration(cfg =>
    {
        cfg.AddProfile(new MappingProfile());
    });
    return config.CreateMapper();
});

// Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Application services
builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
builder.Services.AddMediatR(typeof(Application.AssemblyReference).Assembly);
builder.Services.AddHttpContextAccessor();

//Jwt
builder.Services.ConfigureJWT(builder.Configuration);


// Localization
builder.Services.ConfigureLocalization();
// Load SMTP configuration from appsettings.json
builder.Configuration.GetSection("SmtpConfig");
builder.Services.Configure<SmtpConfig>(builder.Configuration.GetSection("SmtpConfig"));

// Register EmailService with DI
builder.Services.AddScoped<IEmailService, EmailService>();
// Repository services
builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IBorrowerRepository, BorrowerRepository>();
builder.Services.AddScoped<ICompanyTypeRepository, CompanyTypeRepository>();
builder.Services.AddScoped<IPermissionRepository, PermissionRepository>();
builder.Services.AddScoped<IRolePermissionRepository, RolePermissionRepository>();


// ServiceManager and Logger
builder.Services.ConfigureServiceManager();
builder.Services.ConfigureLoggerService();

var app = builder.Build();

// Database seeding
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    SeedData.Initizlize(services);
}

var localizationOptions = app.Services.GetService<IOptions<RequestLocalizationOptions>>();
app.UseRequestLocalization(localizationOptions.Value);

// Exception handling middleware
var logger = app.Services.GetRequiredService<ILoggerManager>();
app.UseMiddleware<ExceptionMiddlewareExtensions>();

// Development environment
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.Run();
