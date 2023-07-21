using Infrastructure;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Application.Mappers;
using Application.Contracts;
using NLog;
using Microsoft.Extensions.Configuration;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Infrastructure.Extentions;
using Infrastructure.Services;
using Application.DTOS;
using FluentValidation;
using Microsoft.Extensions.Options;
using Application.Validations;

//using MediatR;

var builder = WebApplication.CreateBuilder(args);
LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));

// Add services to the container.

builder.Services.AddControllers();

//database configuration
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));

});
builder.Services.AddAuthentication();
builder.Services.ConfigureIdentity();
builder.Services.AddHttpClient();
builder.Services.AddAutoMapper(typeof(Program));
//automapper
builder.Services.AddSingleton(provider =>
{
    var config = new MapperConfiguration(cfg =>
    {
        cfg.AddProfile(new MappingProfile());
    });
    return config.CreateMapper();
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
builder.Services.AddMediatR(typeof(Application.AssemblyReference).Assembly);
//builder.Services.AddMediatR(typeof(Program));



builder.Services.ConfigureServiceManager();
builder.Services.ConfigureLoggerService();
builder.Services.ConfigureLocalization();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services= scope.ServiceProvider;
    SeedData.Initizlize(services);
}
var localizationOptions = app.Services.GetService<IOptions<RequestLocalizationOptions>>();
app.UseRequestLocalization(localizationOptions.Value);

// Configure the HTTP request pipeline.

var logger = app.Services.GetRequiredService<ILoggerManager>();
app.UseMiddleware<ExceptionMiddlewareExtensions>();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseAuthentication();
app.MapControllers();
app.Run();
