using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class PrefixUpdatetedMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "427fb834-a450-48a7-bd0f-7fc4dd234ef1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e254cbb-361e-4cfe-b026-00caa7f2aa3c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "933a7741-8989-49c0-97bb-801c3546c97e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3a658b9f-35b5-4914-b9fe-d8148c20b00f", null, "Borrower", "BORROWER" },
                    { "a4f3e725-bca0-4422-af2f-a2189b5cc4b4", null, "Loan Officer", "LOAN OFFICER" },
                    { "a855b018-9996-4a4b-bb0d-c9a71a129f2e", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a658b9f-35b5-4914-b9fe-d8148c20b00f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a4f3e725-bca0-4422-af2f-a2189b5cc4b4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a855b018-9996-4a4b-bb0d-c9a71a129f2e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "427fb834-a450-48a7-bd0f-7fc4dd234ef1", null, "Loan Officer", "LOAN OFFICER" },
                    { "7e254cbb-361e-4cfe-b026-00caa7f2aa3c", null, "Borrower", "BORROWER" },
                    { "933a7741-8989-49c0-97bb-801c3546c97e", null, "Admin", "ADMIN" }
                });
        }
    }
}
