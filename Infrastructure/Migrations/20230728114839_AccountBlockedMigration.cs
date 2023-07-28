using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AccountBlockedMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "PasswordRecoveyTokenCreationTime",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BlockEnd",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FailedLoginAttempts",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsBlocked",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "46c18d40-dcf5-4311-bae8-547759431e7c", null, "Borrower", "BORROWER" },
                    { "d0c0e9cf-ec31-41e6-9405-4a0832830027", null, "Loan Officer", "LOAN OFFICER" },
                    { "e8c880eb-e610-4908-aec4-998945754e37", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46c18d40-dcf5-4311-bae8-547759431e7c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0c0e9cf-ec31-41e6-9405-4a0832830027");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e8c880eb-e610-4908-aec4-998945754e37");

            migrationBuilder.DropColumn(
                name: "BlockEnd",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FailedLoginAttempts",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsBlocked",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PasswordRecoveyTokenCreationTime",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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
    }
}
