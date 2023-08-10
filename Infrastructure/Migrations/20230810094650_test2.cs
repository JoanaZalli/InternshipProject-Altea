using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1404ccf0-9e90-4eb7-be7f-0d98c6912704");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18797d7a-8f2a-40bf-a804-f9da1cb55d32");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70268be4-b177-4ec2-bd2f-8a69e2eb7ea6");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1404ccf0-9e90-4eb7-be7f-0d98c6912704", null, "Loan Officer", "LOAN OFFICER" },
                    { "18797d7a-8f2a-40bf-a804-f9da1cb55d32", null, "Admin", "ADMIN" },
                    { "70268be4-b177-4ec2-bd2f-8a69e2eb7ea6", null, "Borrower", "BORROWER" }
                });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 11, 45, 50, 512, DateTimeKind.Local).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 11, 45, 50, 512, DateTimeKind.Local).AddTicks(8643));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 11, 45, 50, 512, DateTimeKind.Local).AddTicks(8645));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 11, 45, 50, 512, DateTimeKind.Local).AddTicks(8647));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 11, 45, 50, 512, DateTimeKind.Local).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 11, 45, 50, 512, DateTimeKind.Local).AddTicks(8651));
        }
    }
}
