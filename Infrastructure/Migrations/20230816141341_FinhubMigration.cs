using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FinhubMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
         

            migrationBuilder.RenameColumn(
                name: "Adress",
                table: "CompanyProfiles",
                newName: "Address");

                }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
               }
    }
}
