using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UserPassworTokenMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "PasswordRecoveyToken",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PasswordRecoveyTokenCreationTime",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "297e01cf-c2d7-4beb-b838-f60dc3c65725", null, "Loan Officer", "LOAN OFFICER" },
                    { "33891ded-6fb5-4629-af28-e0f6edafa0e5", null, "Admin", "ADMIN" },
                    { "3c3557f4-a7c8-444d-bc6d-0c7413564449", null, "Borrower", "BORROWER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "297e01cf-c2d7-4beb-b838-f60dc3c65725");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33891ded-6fb5-4629-af28-e0f6edafa0e5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c3557f4-a7c8-444d-bc6d-0c7413564449");

            migrationBuilder.DropColumn(
                name: "PasswordRecoveyToken",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PasswordRecoveyTokenCreationTime",
                table: "AspNetUsers");

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
    }
}
