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
        public DbSet<Applicationn> Applications { get; set; }
        public DbSet<Lender> Lenders { get; set; }
        public DbSet<Condition> Conditions { get; set; }
        public DbSet<MatrixTemplate> MatrixTemplates { get; set; }
        public DbSet<Loan> Loans { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //MatrixTemplate configurations
            modelBuilder.Entity<MatrixTemplate>().HasKey(mt => mt.Id);

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

            modelBuilder.Entity<ApplicationStatus>()
                    .HasKey(e => e.Id);

            modelBuilder.Entity<LoanStatus>()
                     .HasKey(e => e.Id);

            modelBuilder.Entity<ApplicationStatus>()
        .HasOne(e => e.LoanStatus) 
        .WithOne() 
        .HasForeignKey<ApplicationStatus>(e => e.LoanStatusId) 
        .OnDelete(DeleteBehavior.NoAction);


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
                    LoanStatusId=1
                },
                new ApplicationStatus
                {
                    Id = 3,
                    Name = "Loan Canceled",
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                    LoanStatusId=10
                },
                 new ApplicationStatus
                 {
                     Id = 4,
                     Name = "Loan Defaulted",
                     Created = DateTime.Now,
                     Updated = DateTime.Now,
                     LoanStatusId=7
                 },
                  new ApplicationStatus
                  {
                      Id = 5,
                      Name = "Loan Disbursed",
                      Created = DateTime.Now,
                      Updated = DateTime.Now,
                      LoanStatusId=4
                  },
                   new ApplicationStatus
                   {
                       Id = 6,
                       Name = "Loan Guaranteed",
                       Created = DateTime.Now,
                       Updated = DateTime.Now,
                       LoanStatusId=9
                   },
                    new ApplicationStatus
                    {
                        Id = 7,
                        Name = "Loan Rejected",
                        Created = DateTime.Now,
                        Updated = DateTime.Now,
                        LoanStatusId=3
                    },
                     new ApplicationStatus
                     {
                         Id = 8,
                         Name = "Loan Repaid",
                         Created = DateTime.Now,
                         Updated = DateTime.Now,
                         LoanStatusId=8
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
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                 new IdentityUserRole<string>
                 {
                     RoleId = "e995ccf4-801b-41ed-9bab-82d6745dba80",
                     UserId = "47359644-3e10-4e45-b26c-cab9f4ca27c8",
                 },
                  new IdentityUserRole<string>
                  {
                      RoleId = "6eb872cc-7da6-45cb-b0ed-6904c4bbd06d",
                      UserId = "44f05ec5-c969-4b07-93c4-7c2472208fe6"
                  }
                );
            //lender data seed
            modelBuilder.Entity<Lender>().HasData(
                
                new Lender
                {
                    Id=1,
                    Name= "PMI BTECH",
                    DateCreated= DateTime.Now,
                    DateUpdated= DateTime.Now,
                },
                 new Lender
                 {
                     Id = 2,
                     Name = "AZIF",
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                 },
                  new Lender
                  {
                      Id = 3,
                      Name = "LOGITECH",
                      DateCreated = DateTime.Now,
                      DateUpdated = DateTime.Now,
                  }
                  );

            //condition data seed
            modelBuilder.Entity<Condition>().HasData(
                new Condition
                {
                    Id=1,
                    MinRequestedAmount=100000,
                    TenorMin=30,
                    CompanyTypeId=5,
                },
                new Condition
                { 
                    Id=2,
                    MinRequestedAmount=400000,
                    TenorMin=40,
                    TenorMax=60,
                },
                new Condition
                {
                    Id=3,
                    MinRequestedAmount=100000,
                    TenorMin=30,
                    TenorMax=60,
                    CompanyTypeId=1
                }
                );
        }

    }
}