using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class PrefixUpdatetedMigration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "243c92de-0670-48e3-9cad-e0bbe73c9c0f", null, "Borrower", "BORROWER" },
                    { "88b4c231-cf19-43a1-9c01-8867ba9b0338", null, "Admin", "ADMIN" },
                    { "c2c42648-763f-4d5a-ab6f-8ab95be24a4d", null, "Loan Officer", "LOAN OFFICER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
