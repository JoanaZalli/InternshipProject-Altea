using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AccessTokenMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "540b670f-683f-4dfa-bc86-e09cbdaced0c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2f49f2c-2d31-4388-b929-5429312a5782");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b9718c24-3a91-484b-a4f1-d866d588d8f7");

            migrationBuilder.AddColumn<string>(
                name: "AccesToken",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AccesTokenExpiryTime",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4a76d96a-a80f-4dfa-b251-b2fe22d3b22e", null, "Loan Officer", "LOAN OFFICER" },
                    { "502d1b0b-f7da-4deb-9297-716bd39c5656", null, "Borrower", "BORROWER" },
                    { "f16fe5bb-01ec-470b-b049-9537a02ff539", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a76d96a-a80f-4dfa-b251-b2fe22d3b22e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "502d1b0b-f7da-4deb-9297-716bd39c5656");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f16fe5bb-01ec-470b-b049-9537a02ff539");

            migrationBuilder.DropColumn(
                name: "AccesToken",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AccesTokenExpiryTime",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "540b670f-683f-4dfa-bc86-e09cbdaced0c", null, "Admin", "ADMIN" },
                    { "b2f49f2c-2d31-4388-b929-5429312a5782", null, "Borrower", "BORROWER" },
                    { "b9718c24-3a91-484b-a4f1-d866d588d8f7", null, "Loan Officer", "LOAN OFFICER" }
                });
        }
    }
}
