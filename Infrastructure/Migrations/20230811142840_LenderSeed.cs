using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class LenderSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.InsertData(
                table: "Lenders",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 11, 16, 28, 39, 606, DateTimeKind.Local).AddTicks(4516), new DateTime(2023, 8, 11, 16, 28, 39, 606, DateTimeKind.Local).AddTicks(4518), null, "PMI BTECH" },
                    { 2, new DateTime(2023, 8, 11, 16, 28, 39, 606, DateTimeKind.Local).AddTicks(4520), new DateTime(2023, 8, 11, 16, 28, 39, 606, DateTimeKind.Local).AddTicks(4521), null, "AZIF" },
                    { 3, new DateTime(2023, 8, 11, 16, 28, 39, 606, DateTimeKind.Local).AddTicks(4523), new DateTime(2023, 8, 11, 16, 28, 39, 606, DateTimeKind.Local).AddTicks(4525), null, "LOGITECH" }
                });
  }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
                   }
    }
}
