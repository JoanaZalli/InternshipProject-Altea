using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ProductMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Refernce_rate = table.Column<double>(type: "float", nullable: false),
                    Max_Financed_Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Min_Financed_Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

           

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Max_Financed_Amount", "Min_Financed_Amount", "Name", "Refernce_rate" },
                values: new object[,]
                {
                    { 1, "Installments with pre-amortization at a fixed rate", 200000000m, 1000000m, "Installments with pre-amortization at a fixed rate", 0.0025000000000000001 },
                    { 2, "Installment with variable rate pre-amortization", 100000000m, 1000000m, "Installment with variable rate pre-amortization", 0.029999999999999999 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56303f94-ea01-49c1-99b4-0c255841dfbe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "daac7143-9a06-447d-9cfd-072e0134b1c0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f3ff3c04-cd86-4eb1-95f2-fb56a672ba2c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5142c668-e059-4859-b5d3-9a0cf4e62e59");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3960bdd1-6ae2-462f-a93c-7dd03dce725f", null, "Loan Officer", "LOAN OFFICER" },
                    { "669f2bb4-655e-4dce-bead-5c6d48c2c824", null, "Borrower", "BORROWER" },
                    { "d61f1f9b-de07-4910-a0bd-708874c04698", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccesToken", "AccesTokenExpiryTime", "AccessFailedCount", "BlockEnd", "ConcurrencyStamp", "Email", "EmailConfirmed", "FailedLoginAttempts", "FirstName", "IsBlocked", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordRecoveyToken", "PasswordRecoveyTokenCreationTime", "PhoneNumber", "PhoneNumberConfirmed", "PrefixId", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "Token", "TokenCreationTime", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3b719ecd-3ebb-4089-84fc-49c45541bedd", null, null, 0, null, "2b71bf1f-7b42-4037-bdc5-2cf6d041b9d6", "admin@gmail.com", true, 0, "admin", false, "admin", false, null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, null, null, "b516db98-c929-4d49-bda7-26e058a3f47c", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "admin1" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 8, 3, 16, 38, 55, 389, DateTimeKind.Local).AddTicks(8092));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 8, 3, 16, 38, 55, 389, DateTimeKind.Local).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 8, 3, 16, 38, 55, 389, DateTimeKind.Local).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 8, 3, 16, 38, 55, 389, DateTimeKind.Local).AddTicks(8146));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 8, 3, 16, 38, 55, 389, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 8, 3, 16, 38, 55, 389, DateTimeKind.Local).AddTicks(8150));
        }
    }
}
