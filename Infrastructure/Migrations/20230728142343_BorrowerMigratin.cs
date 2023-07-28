using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class BorrowerMigratin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CompanyType",
                table: "CompanyType");

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

            migrationBuilder.RenameTable(
                name: "CompanyType",
                newName: "CompanyTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompanyTypes",
                table: "CompanyTypes",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Borrowers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyTypeId = table.Column<int>(type: "int", nullable: false),
                    VatNumber = table.Column<int>(type: "int", nullable: false),
                    FiscalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserId1 = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Borrowers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Borrowers_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Borrowers_CompanyTypes_CompanyTypeId",
                        column: x => x.CompanyTypeId,
                        principalTable: "CompanyTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0436929f-b1f3-45d2-a2c7-9a459fd80d5b", null, "Borrower", "BORROWER" },
                    { "0b4a2c71-a325-428c-8bf2-8cdbada16c10", null, "Admin", "ADMIN" },
                    { "a4448f6d-b228-4e52-a0ac-4f1cb62be653", null, "Loan Officer", "LOAN OFFICER" }
                });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 7, 28, 16, 23, 42, 997, DateTimeKind.Local).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 7, 28, 16, 23, 42, 997, DateTimeKind.Local).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 7, 28, 16, 23, 42, 997, DateTimeKind.Local).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 7, 28, 16, 23, 42, 997, DateTimeKind.Local).AddTicks(767));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 7, 28, 16, 23, 42, 997, DateTimeKind.Local).AddTicks(769));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 7, 28, 16, 23, 42, 997, DateTimeKind.Local).AddTicks(771));

            migrationBuilder.CreateIndex(
                name: "IX_Borrowers_CompanyTypeId",
                table: "Borrowers",
                column: "CompanyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Borrowers_UserId1",
                table: "Borrowers",
                column: "UserId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Borrowers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompanyTypes",
                table: "CompanyTypes");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0436929f-b1f3-45d2-a2c7-9a459fd80d5b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b4a2c71-a325-428c-8bf2-8cdbada16c10");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a4448f6d-b228-4e52-a0ac-4f1cb62be653");

            migrationBuilder.RenameTable(
                name: "CompanyTypes",
                newName: "CompanyType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompanyType",
                table: "CompanyType",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7f86f387-657c-44ba-8f53-e0b719ee5d3a", null, "Loan Officer", "LOAN OFFICER" },
                    { "9c731f22-9fb1-4c2a-9006-871e2325ffb5", null, "Admin", "ADMIN" },
                    { "d76e6ec5-5b81-4d61-b4aa-63a611d9fde3", null, "Borrower", "BORROWER" }
                });

            migrationBuilder.UpdateData(
                table: "CompanyType",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 7, 28, 16, 18, 46, 251, DateTimeKind.Local).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "CompanyType",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 7, 28, 16, 18, 46, 251, DateTimeKind.Local).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "CompanyType",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 7, 28, 16, 18, 46, 251, DateTimeKind.Local).AddTicks(1677));

            migrationBuilder.UpdateData(
                table: "CompanyType",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 7, 28, 16, 18, 46, 251, DateTimeKind.Local).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "CompanyType",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 7, 28, 16, 18, 46, 251, DateTimeKind.Local).AddTicks(1716));

            migrationBuilder.UpdateData(
                table: "CompanyType",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 7, 28, 16, 18, 46, 251, DateTimeKind.Local).AddTicks(1717));
        }
    }
}
