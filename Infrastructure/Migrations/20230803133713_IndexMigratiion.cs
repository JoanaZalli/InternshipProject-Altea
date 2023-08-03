using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class IndexMigratiion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4963467c-d8d5-4ea7-bc54-8f4b9d23ac02");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83dd89b3-7435-4e13-8998-bd2b45dae7cc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e8326b38-8f0c-4d69-b1e4-3b9a44bf67cd");

            migrationBuilder.AlterColumn<string>(
                name: "FiscalCode",
                table: "Borrowers",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "44829347-a1a2-4b4f-9195-3ff36afcd170", null, "Admin", "ADMIN" },
                    { "a1dc9480-855b-4aa5-bea9-cbb47d7207f9", null, "Loan Officer", "LOAN OFFICER" },
                    { "aa0e3d62-8760-4b1a-a21b-0b340ae1732a", null, "Borrower", "BORROWER" }
                });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 8, 3, 15, 37, 13, 87, DateTimeKind.Local).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 8, 3, 15, 37, 13, 87, DateTimeKind.Local).AddTicks(3467));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 8, 3, 15, 37, 13, 87, DateTimeKind.Local).AddTicks(3469));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 8, 3, 15, 37, 13, 87, DateTimeKind.Local).AddTicks(3471));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 8, 3, 15, 37, 13, 87, DateTimeKind.Local).AddTicks(3473));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 8, 3, 15, 37, 13, 87, DateTimeKind.Local).AddTicks(3474));

            migrationBuilder.CreateIndex(
                name: "IX_Borrowers_FiscalCode_UserId",
                table: "Borrowers",
                columns: new[] { "FiscalCode", "UserId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Borrowers_FiscalCode_UserId",
                table: "Borrowers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44829347-a1a2-4b4f-9195-3ff36afcd170");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1dc9480-855b-4aa5-bea9-cbb47d7207f9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aa0e3d62-8760-4b1a-a21b-0b340ae1732a");

            migrationBuilder.AlterColumn<string>(
                name: "FiscalCode",
                table: "Borrowers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4963467c-d8d5-4ea7-bc54-8f4b9d23ac02", null, "Admin", "ADMIN" },
                    { "83dd89b3-7435-4e13-8998-bd2b45dae7cc", null, "Borrower", "BORROWER" },
                    { "e8326b38-8f0c-4d69-b1e4-3b9a44bf67cd", null, "Loan Officer", "LOAN OFFICER" }
                });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 8, 1, 14, 38, 17, 984, DateTimeKind.Local).AddTicks(3262));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 8, 1, 14, 38, 17, 984, DateTimeKind.Local).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 8, 1, 14, 38, 17, 984, DateTimeKind.Local).AddTicks(3311));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 8, 1, 14, 38, 17, 984, DateTimeKind.Local).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 8, 1, 14, 38, 17, 984, DateTimeKind.Local).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 8, 1, 14, 38, 17, 984, DateTimeKind.Local).AddTicks(3317));
        }
    }
}
