using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DataTypeChangeMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32763f1a-d526-4745-ac05-ffa1a2bc7508");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f49b046-29b9-4ccc-826d-8bd32dd114a8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7a6ce52-b1e0-4296-af72-4839e37efb06");

            migrationBuilder.AlterColumn<string>(
                name: "VatNumber",
                table: "Borrowers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0cb0f943-e8c2-4224-a3a4-036e6bfadd04", null, "Admin", "ADMIN" },
                    { "c023fd01-528f-472b-a89f-f6629c0d2ed3", null, "Borrower", "BORROWER" },
                    { "e44083e5-8be6-45f6-8ca8-f105330fcbf3", null, "Loan Officer", "LOAN OFFICER" }
                });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 8, 1, 9, 43, 51, 217, DateTimeKind.Local).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 8, 1, 9, 43, 51, 217, DateTimeKind.Local).AddTicks(2541));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 8, 1, 9, 43, 51, 217, DateTimeKind.Local).AddTicks(2543));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 8, 1, 9, 43, 51, 217, DateTimeKind.Local).AddTicks(2545));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 8, 1, 9, 43, 51, 217, DateTimeKind.Local).AddTicks(2547));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 8, 1, 9, 43, 51, 217, DateTimeKind.Local).AddTicks(2549));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0cb0f943-e8c2-4224-a3a4-036e6bfadd04");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c023fd01-528f-472b-a89f-f6629c0d2ed3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e44083e5-8be6-45f6-8ca8-f105330fcbf3");

            migrationBuilder.AlterColumn<int>(
                name: "VatNumber",
                table: "Borrowers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "32763f1a-d526-4745-ac05-ffa1a2bc7508", null, "Admin", "ADMIN" },
                    { "3f49b046-29b9-4ccc-826d-8bd32dd114a8", null, "Borrower", "BORROWER" },
                    { "f7a6ce52-b1e0-4296-af72-4839e37efb06", null, "Loan Officer", "LOAN OFFICER" }
                });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 7, 28, 16, 44, 16, 55, DateTimeKind.Local).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 7, 28, 16, 44, 16, 55, DateTimeKind.Local).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 7, 28, 16, 44, 16, 55, DateTimeKind.Local).AddTicks(9122));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 7, 28, 16, 44, 16, 55, DateTimeKind.Local).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 7, 28, 16, 44, 16, 55, DateTimeKind.Local).AddTicks(9126));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 7, 28, 16, 44, 16, 55, DateTimeKind.Local).AddTicks(9128));
        }
    }
}
