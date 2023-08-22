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
    public static class SeedLoanOfficer
    {
        public static async Task Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {


                if (!context.Users.Any(u => u.UserName == "loanofficer"))
                {
                    var userManager = serviceProvider.GetRequiredService<UserManager<User>>();
                    var loanofficeruser = new User
                    {
                        FirstName = "loanofficer",
                        LastName = "loanofficer",
                        PrefixId = 1,
                        UserName = "loanofficer",
                        Email = "loanofficer@gmail.com",
                        EmailConfirmed = true
                    };

                    var result = await userManager.CreateAsync(loanofficeruser, "Pa$$w0rd)");

                    if (!result.Succeeded)
                    {

                    }
                }
            }
        }
    }
}
