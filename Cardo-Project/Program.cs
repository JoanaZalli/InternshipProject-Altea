using Infrastructure;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using Infrastructure.Extentions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Application.Services.Contracts;
using Infrastructure.Services;
using AutoMapper;
using Application.Mappers;
using Application.Contracts;
using Microsoft.AspNetCore.Hosting;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Application.DTOS;
using Application.Moduls.UserModul.Commands;
using System.Reflection;


//using MediatR;

var builder = WebApplication.CreateBuilder(args);

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

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services= scope.ServiceProvider;
    SeedData.Initizlize(services);
}


// Configure the HTTP request pipeline.
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
