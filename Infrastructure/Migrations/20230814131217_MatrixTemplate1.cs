using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class MatrixTemplate1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.AddColumn<double>(
                name: "Spread",
                table: "MatrixTemplates",
                type: "float",
                nullable: true);
   }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
           }
    }
}
