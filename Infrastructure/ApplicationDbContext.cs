using Domain.Entities;
using Infrastructure.Repository.Configuration;
using Microsoft.AspNetCore.Identity;
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

        public DbSet<Permission> Permissions { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<UserPermission> UserPermissions { get; set; }
        public DbSet<ApplicationStatus> ApplicationStatuses { get; set; }
        public DbSet<LoanStatus> LoanStatuses { get; set; }
        public DbSet<CompanyProfile> CompanyProfiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //borrower=>applications
            modelBuilder.Entity<Borrower>()
                .HasMany(b => b.Applications)
                .WithOne(b => b.Borrower)
                .HasForeignKey(b => b.BorrowerId);

            //products=>applications
            modelBuilder.Entity<Product>()
                .HasMany(b => b.Applications)
                .WithOne(b => b.Product)
                .HasForeignKey(b => b.ProductId);

            //applicationStatus=>applications
            modelBuilder.Entity<ApplicationStatus>()
                .HasMany(b => b.Applications)
                .WithOne(b => b.ApplicationStatus)
                .HasForeignKey(b => b.ApplicationStatusId);


            modelBuilder.Entity<User>()
               .HasMany(u => u.Borrowers)
               .WithOne(b => b.User)
               .HasForeignKey(b => b.UserId);
            //Role Permission
            modelBuilder.Entity<RolePermission>()
              .HasKey(rp => new { rp.RoleId, rp.PermissionId });

            modelBuilder.Entity<RolePermission>()
                .HasOne(rp => rp.Role)
                .WithMany()
                .HasForeignKey(rp => rp.RoleId);

            modelBuilder.Entity<RolePermission>()
                .HasOne(rp => rp.Permission)
                .WithMany()
                .HasForeignKey(rp => rp.PermissionId);
            //User Permission
            modelBuilder.Entity<UserPermission>()
              .HasKey(up => new { up.UserId, up.PermissionId });

            modelBuilder.Entity<UserPermission>()
                .HasOne(up => up.User)
                .WithMany()
                .HasForeignKey(up => up.UserId);

            modelBuilder.Entity<UserPermission>()
               .HasOne(up => up.Permission)
               .WithMany()
               .HasForeignKey(up => up.PermissionId);


            modelBuilder.Entity<User>()
                .HasOne(u => u.Prefix)
                .WithMany()
                .HasForeignKey(u => u.PrefixId);

            // create index 
            modelBuilder.Entity<Borrower>()
                .HasIndex(x => new { x.FiscalCode, x.UserId }).IsUnique();

            modelBuilder.ApplyConfiguration(new RoleConfiguration());

            //company type

            modelBuilder.Entity<CompanyType>().HasData(
            new CompanyType
            {
                Id = 1,
                Company_Type = "Sole proprietorship (S.I.)",
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
          
            //Products
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Installments with pre-amortization at a fixed rate",
                    Description = "Installments with pre-amortization at a fixed rate",
                    Refernce_rate = 0.0025,
                    Max_Financed_Amount = 200000000,
                    Min_Financed_Amount = 1000000
                },
                new Product
                {
                    Id = 2,
                    Name = "Installment with variable rate pre-amortization",
                    Description = "Installment with variable rate pre-amortization",
                    Refernce_rate = 0.03,
                    Max_Financed_Amount = 100000000,
                    Min_Financed_Amount = 1000000
                }
            );
            //application statuses data seed
            modelBuilder.Entity<ApplicationStatus>().HasData(
                new ApplicationStatus
                {
                    Id=1,
                    Name="In Charge",
                    Created= DateTime.Now,
                    Updated= DateTime.Now,
                },
                new ApplicationStatus
                {
                    Id = 2,
                    Name = "Loan Issued",
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                },
                new ApplicationStatus
                {
                    Id = 3,
                    Name = "Loan Canceled",
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                },
                 new ApplicationStatus
                 {
                     Id = 4,
                     Name = "Loan Defaulted",
                     Created = DateTime.Now,
                     Updated = DateTime.Now,
                 },
                  new ApplicationStatus
                  {
                      Id = 5,
                      Name = "Loan Disbursed",
                      Created = DateTime.Now,
                      Updated = DateTime.Now,
                  },
                   new ApplicationStatus
                   {
                       Id = 6,
                       Name = "Loan Guaranteed",
                       Created = DateTime.Now,
                       Updated = DateTime.Now,
                   },
                    new ApplicationStatus
                    {
                        Id = 7,
                        Name = "Loan Rejected",
                        Created = DateTime.Now,
                        Updated = DateTime.Now,
                    },
                     new ApplicationStatus
                     {
                         Id = 8,
                         Name = "Loan Repaid",
                         Created = DateTime.Now,
                         Updated = DateTime.Now,
                     }
                );
            //loan statusees data seed
            modelBuilder.Entity<LoanStatus>().HasData(
                new LoanStatus
                {
                    Id = 1,
                    Name = "Created",
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                },
                new LoanStatus
                {
                    Id = 2,
                    Name = "Accepted",
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                },
                new LoanStatus
                {
                    Id = 3,
                    Name = "Rejected",
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                },
                new LoanStatus
                {
                    Id = 4,
                    Name = "Disbursed",
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                },
                new LoanStatus
                {
                    Id = 5,
                    Name = "Current",
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                },
                new LoanStatus
                {
                    Id = 6,
                    Name = "In Arrears",
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                },
                new LoanStatus
                {
                    Id = 7,
                    Name = "Defaulted",
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                },
                new LoanStatus
                {
                    Id = 8,
                    Name = "Repaid",
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                },
                new LoanStatus
                {
                    Id = 9,
                    Name = "Guaranteed",
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                },
                new LoanStatus
                {
                    Id = 10,
                    Name = "Erased",
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                }
              );

        }

    }
}