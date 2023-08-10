using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class LoanApplicationStatuses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0842523-ca9d-4cd6-ae18-c0a317930732");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4200a97-f84a-48db-9383-38ddf3c97ee4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c29b76fa-aee3-461b-87ba-8e2b231438b1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ebd21694-e7e8-40ec-bfe9-a41a1f0afe25");

            migrationBuilder.CreateTable(
                name: "ApplicationStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoanStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanStatuses", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ApplicationStatuses",
                columns: new[] { "Id", "Created", "Name", "Updated" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8208), "In Charge", new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8210) },
                    { 2, new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8212), "Loan Issued", new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8213) },
                    { 3, new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8215), "Loan Canceled", new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8217) },
                    { 4, new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8219), "Loan Defaulted", new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8220) },
                    { 5, new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8222), "Loan Disbursed", new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8224) },
                    { 6, new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8225), "Loan Guaranteed", new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8227) },
                    { 7, new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8229), "Loan Rejected", new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8230) },
                    { 8, new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8232), "Loan Repaid", new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8234) }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "f1125c1c-139f-49ba-bd17-b7f730a71927", null, "Admin", "ADMIN" },
                    { "f3bd527a-82e9-473a-bced-07a14a269d2c", null, "Borrower", "BORROWER" },
                    { "fcaaceec-bfbb-4948-af94-370e4103028c", null, "Loan Officer", "LOAN OFFICER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccesToken", "AccesTokenExpiryTime", "AccessFailedCount", "BlockEnd", "ConcurrencyStamp", "Email", "EmailConfirmed", "FailedLoginAttempts", "FirstName", "IsBlocked", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordRecoveyToken", "PasswordRecoveyTokenCreationTime", "PhoneNumber", "PhoneNumberConfirmed", "PrefixId", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "Token", "TokenCreationTime", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e9efda0c-9b13-4efd-bc1f-d8840cd80370", null, null, 0, null, "cdf33343-c78c-47b5-bb31-864aafeedf7f", "admin@gmail.com", true, 0, "admin", false, "admin", false, null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, null, null, "f19aa472-90c0-43ac-ae59-955ff76cd1a4", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "admin1" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8089));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8145));

            migrationBuilder.InsertData(
                table: "LoanStatuses",
                columns: new[] { "Id", "Created", "Name", "Updated" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8250), "Created", new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8252) },
                    { 2, new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8254), "Accepted", new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8256) },
                    { 3, new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8258), "Rejected", new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8259) },
                    { 4, new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8261), "Disbursed", new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8263) },
                    { 5, new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8265), "Current", new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8266) },
                    { 6, new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8268), "In Arrears", new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8270) },
                    { 7, new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8271), "Defaulted", new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8273) },
                    { 8, new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8275), "Repaid", new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8276) },
                    { 9, new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8278), "Guaranteed", new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8280) },
                    { 10, new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8282), "Erased", new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8283) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationStatuses");

            migrationBuilder.DropTable(
                name: "LoanStatuses");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f1125c1c-139f-49ba-bd17-b7f730a71927");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f3bd527a-82e9-473a-bced-07a14a269d2c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcaaceec-bfbb-4948-af94-370e4103028c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9efda0c-9b13-4efd-bc1f-d8840cd80370");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a0842523-ca9d-4cd6-ae18-c0a317930732", null, "Loan Officer", "LOAN OFFICER" },
                    { "b4200a97-f84a-48db-9383-38ddf3c97ee4", null, "Borrower", "BORROWER" },
                    { "c29b76fa-aee3-461b-87ba-8e2b231438b1", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccesToken", "AccesTokenExpiryTime", "AccessFailedCount", "BlockEnd", "ConcurrencyStamp", "Email", "EmailConfirmed", "FailedLoginAttempts", "FirstName", "IsBlocked", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordRecoveyToken", "PasswordRecoveyTokenCreationTime", "PhoneNumber", "PhoneNumberConfirmed", "PrefixId", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "Token", "TokenCreationTime", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ebd21694-e7e8-40ec-bfe9-a41a1f0afe25", null, null, 0, null, "782ac77e-72de-465c-988a-4ce0abb8d939", "admin@gmail.com", true, 0, "admin", false, "admin", false, null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, null, null, "e5f5c06b-2047-42b3-8efe-b0548da5b888", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "admin1" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 11, 46, 50, 755, DateTimeKind.Local).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 11, 46, 50, 755, DateTimeKind.Local).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 11, 46, 50, 755, DateTimeKind.Local).AddTicks(7205));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 11, 46, 50, 755, DateTimeKind.Local).AddTicks(7207));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 11, 46, 50, 755, DateTimeKind.Local).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 11, 46, 50, 755, DateTimeKind.Local).AddTicks(7211));
        }
    }
}
