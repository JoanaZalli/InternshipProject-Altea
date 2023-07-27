using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RefreshTokenMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72ad5dca-432b-4303-aaa8-ede739e65080");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "caade65f-c23a-42aa-9be7-d5298dc8aa4b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb01607e-f5e7-4475-b886-ff7915ace6df");

            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenExpiryTime",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RefreshTokenExpiryTime",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "72ad5dca-432b-4303-aaa8-ede739e65080", null, "Borrower", "BORROWER" },
                    { "caade65f-c23a-42aa-9be7-d5298dc8aa4b", null, "Admin", "ADMIN" },
                    { "eb01607e-f5e7-4475-b886-ff7915ace6df", null, "Loan Officer", "LOAN OFFICER" }
                });
        }
    }
}
