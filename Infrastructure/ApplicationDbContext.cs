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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasOne(u => u.Prefix)
                .WithMany()
                .HasForeignKey(u => u.PrefixId);

            modelBuilder.ApplyConfiguration(new RoleConfiguration());

        }

        public DbSet<User> Users {  get; set; }
        public DbSet<Prefix> Prefixes { get; set; }

    }
}
