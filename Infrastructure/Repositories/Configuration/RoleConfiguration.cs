using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {

            builder.HasData(
                     new IdentityRole
                     {
                         Id= "4377AA5F-C7E7-45B9-A879-8409074EE9AB",
                         Name = "Admin",
                         NormalizedName = "ADMIN"
                     },
                     new IdentityRole
                     {
                         Id= "ACEE1889-E154-4C90-91D4-5F8F396FC5B5",
                         Name = "Loan Officer",
                         NormalizedName = "LOAN OFFICER"
                     },
                     new IdentityRole
                     {
                         Id= "0A47E499-1E79-4E81-94DE-1BC68019CCCE",
                         Name = "Borrower",
                         NormalizedName = "BORROWER"
                     }
            );
        }
    }
}
