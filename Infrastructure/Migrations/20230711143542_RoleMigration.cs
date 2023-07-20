using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RoleMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
