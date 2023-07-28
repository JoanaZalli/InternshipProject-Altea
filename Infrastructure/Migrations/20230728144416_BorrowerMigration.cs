using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class BorrowerMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Borrowers_AspNetUsers_UserId1",
                table: "Borrowers");

            migrationBuilder.DropIndex(
                name: "IX_Borrowers_UserId1",
                table: "Borrowers");

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

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Borrowers");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Borrowers",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.CreateIndex(
                name: "IX_Borrowers_UserId",
                table: "Borrowers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Borrowers_AspNetUsers_UserId",
                table: "Borrowers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Borrowers_AspNetUsers_UserId",
                table: "Borrowers");

            migrationBuilder.DropIndex(
                name: "IX_Borrowers_UserId",
                table: "Borrowers");

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

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Borrowers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Borrowers",
                type: "nvarchar(450)",
                nullable: true);

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
                name: "IX_Borrowers_UserId1",
                table: "Borrowers",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Borrowers_AspNetUsers_UserId1",
                table: "Borrowers",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
