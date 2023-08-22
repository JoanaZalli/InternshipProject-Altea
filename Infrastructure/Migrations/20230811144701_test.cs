using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
                
            

          

            migrationBuilder.InsertData(
                table: "Conditions",
                columns: new[] { "Id", "CompanyTypeId", "LenderId", "MinRequestedAmount", "TenorMax", "TenorMin" },
                values: new object[] { 2, null, 2, 400000m, 60m, 40m });

        

            migrationBuilder.InsertData(
                table: "Conditions",
                columns: new[] { "Id", "CompanyTypeId", "LenderId", "MinRequestedAmount", "TenorMax", "TenorMin" },
                values: new object[,]
                {
                    { 1, 5, 1, 100000m, null, 30m },
                    { 3, 1, 3, 100000m, 60m, 30m }
                });

        

     



        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
          
        }
    }
}
