using Domain.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class SeedData
    {
        public static void Initizlize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()
                ))
            {
                if (context.Prefixes.Any())
                {
                    return;
                }
                var env= serviceProvider.GetRequiredService<IWebHostEnvironment>();
                var path = Path.Combine(env.WebRootPath, "Files", "prefixes.json");

                var jsonString=System.IO.File.ReadAllText(path);
                if(jsonString != null)
                {
#pragma warning disable CS8600
                    var prefixes = System.Text.Json.JsonSerializer.Deserialize<List<Prefix>>(jsonString);
#pragma warning restore CS8600

                    if (prefixes != null)
                    {
                        context.Prefixes.AddRange(prefixes);
                        context.SaveChanges();
                    }

                }
            }
        }
    }
}
