using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TokenMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "243c92de-0670-48e3-9cad-e0bbe73c9c0f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "88b4c231-cf19-43a1-9c01-8867ba9b0338");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2c42648-763f-4d5a-ab6f-8ab95be24a4d");

            migrationBuilder.AddColumn<string>(
                name: "Token",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "TokenCreationTime",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Token",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TokenCreationTime",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "243c92de-0670-48e3-9cad-e0bbe73c9c0f", null, "Borrower", "BORROWER" },
                    { "88b4c231-cf19-43a1-9c01-8867ba9b0338", null, "Admin", "ADMIN" },
                    { "c2c42648-763f-4d5a-ab6f-8ab95be24a4d", null, "Loan Officer", "LOAN OFFICER" }
                });
        }
    }
}
