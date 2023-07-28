using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CompanyTypeMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Token",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "CompanyType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Company_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyType", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7f86f387-657c-44ba-8f53-e0b719ee5d3a", null, "Loan Officer", "LOAN OFFICER" },
                    { "9c731f22-9fb1-4c2a-9006-871e2325ffb5", null, "Admin", "ADMIN" },
                    { "d76e6ec5-5b81-4d61-b4aa-63a611d9fde3", null, "Borrower", "BORROWER" }
                });

            migrationBuilder.InsertData(
                table: "CompanyType",
                columns: new[] { "Id", "Company_Type", "DateCreated" },
                values: new object[,]
                {
                    { 1, "Sole proprietorship (S.I.)", new DateTime(2023, 7, 28, 16, 18, 46, 251, DateTimeKind.Local).AddTicks(1630) },
                    { 2, "Other", new DateTime(2023, 7, 28, 16, 18, 46, 251, DateTimeKind.Local).AddTicks(1675) },
                    { 3, "Partnership limited by shares (p.l.sh.)", new DateTime(2023, 7, 28, 16, 18, 46, 251, DateTimeKind.Local).AddTicks(1677) },
                    { 4, "Limited partnership (l.p.)", new DateTime(2023, 7, 28, 16, 18, 46, 251, DateTimeKind.Local).AddTicks(1713) },
                    { 5, "Cooperative Society (c.s.)", new DateTime(2023, 7, 28, 16, 18, 46, 251, DateTimeKind.Local).AddTicks(1716) },
                    { 6, "General partnership (g.p.)", new DateTime(2023, 7, 28, 16, 18, 46, 251, DateTimeKind.Local).AddTicks(1717) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyType");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f86f387-657c-44ba-8f53-e0b719ee5d3a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9c731f22-9fb1-4c2a-9006-871e2325ffb5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d76e6ec5-5b81-4d61-b4aa-63a611d9fde3");

            migrationBuilder.AlterColumn<string>(
                name: "Token",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
