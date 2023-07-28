using Domain.Entities;
using Infrastructure.Repository.Configuration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {

        public ApplicationDbContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Prefix> Prefixes { get; set; }
        public DbSet<CompanyType> CompanyTypes { get; set; }
        public DbSet<Borrower> Borrowers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>()
               .HasMany(u => u.Borrowers)
               .WithOne(b => b.User)
               .HasForeignKey(b => b.UserId);


            modelBuilder.Entity<User>()
                .HasOne(u => u.Prefix)
                .WithMany()
                .HasForeignKey(u => u.PrefixId);

            modelBuilder.ApplyConfiguration(new RoleConfiguration());


            modelBuilder.Entity<CompanyType>().HasData(
            new CompanyType { 
                Id = 1,
                Company_Type= "Sole proprietorship (S.I.)",
                DateCreated = DateTime.Now,
            },
            new CompanyType
            {
                Id = 2,
                Company_Type = "Other",
                DateCreated = DateTime.Now,
            },
            new CompanyType
            {
                Id = 3,
                Company_Type = "Partnership limited by shares (p.l.sh.)",
                DateCreated = DateTime.Now,
            },
             new CompanyType
             {
                 Id = 4,
                 Company_Type = "Limited partnership (l.p.)",
                 DateCreated = DateTime.Now,
             },
              new CompanyType
              {
                  Id = 5,
                  Company_Type = "Cooperative Society (c.s.)",
                  DateCreated = DateTime.Now,
              },
               new CompanyType
               {
                   Id = 6,
                   Company_Type = "General partnership (g.p.)",
                   DateCreated = DateTime.Now,
               }
            );


        }

    }
}
