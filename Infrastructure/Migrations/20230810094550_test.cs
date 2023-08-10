using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2bf91485-ead6-4331-9390-b279acd6a85d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72685525-e926-40db-9d21-646b461c544b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a4ce02e1-6035-4203-99c6-8f983ad0f82d");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "2bf91485-ead6-4331-9390-b279acd6a85d", null, "Borrower", "BORROWER" },
                    { "72685525-e926-40db-9d21-646b461c544b", null, "Admin", "ADMIN" },
                    { "a4ce02e1-6035-4203-99c6-8f983ad0f82d", null, "Loan Officer", "LOAN OFFICER" }
                });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 11, 44, 1, 174, DateTimeKind.Local).AddTicks(1627));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 11, 44, 1, 174, DateTimeKind.Local).AddTicks(1684));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 11, 44, 1, 174, DateTimeKind.Local).AddTicks(1686));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 11, 44, 1, 174, DateTimeKind.Local).AddTicks(1688));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 11, 44, 1, 174, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 11, 44, 1, 174, DateTimeKind.Local).AddTicks(1692));
        }
    }
}
