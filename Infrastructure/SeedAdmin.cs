using Domain.Entities;
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
                        FirstName = "admin",
                        LastName = "admin",
                        PrefixId = 1,
                        UserName = "admin1",
                        Email = "admin@gmail.com",
                        EmailConfirmed = true
                    };

                    await userManager.CreateAsync(adminUser, "Passw0rd");

                    await userManager.AddToRoleAsync(adminUser, "Admin");
                }
            }
        }
    }
}
