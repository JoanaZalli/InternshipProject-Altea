﻿using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class SeedAdmin
    {
        public static async Task Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {


                if (!context.Users.Any(u => u.UserName == "admin1"))
                {
                    var userManager = serviceProvider.GetRequiredService<UserManager<User>>();
                    var adminUser = new User
                    {
                        Id= "392086A6-ABEB-48E1-8666-426BA7B31312",
                        FirstName = "admin",
                        LastName = "admin",
                        PrefixId = 1,
                        UserName = "admin1",
                        Email = "admin@gmail.com",
                        EmailConfirmed = true
                    };

                    var result=await userManager.CreateAsync(adminUser, "Pa$$w0rd)");
                    
                    if (!result.Succeeded) {

                   }
                }
            }
        }
    }
}
