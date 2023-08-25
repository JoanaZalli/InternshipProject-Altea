using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class BorrowerCompanhyType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyProfileId",
                table: "Borrowers",
                type: "int",
                nullable: true);

          
            migrationBuilder.CreateIndex(
                name: "IX_Borrowers_CompanyProfileId",
                table: "Borrowers",
                column: "CompanyProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Borrowers_CompanyProfiles_CompanyProfileId",
                table: "Borrowers",
                column: "CompanyProfileId",
                principalTable: "CompanyProfiles",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Borrowers_CompanyProfiles_CompanyProfileId",
                table: "Borrowers");

            migrationBuilder.DropIndex(
                name: "IX_Borrowers_CompanyProfileId",
                table: "Borrowers");

            migrationBuilder.DropColumn(
                name: "CompanyProfileId",
                table: "Borrowers");

         
            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 8, 23, 14, 36, 12, 777, DateTimeKind.Local).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 8, 23, 14, 36, 12, 777, DateTimeKind.Local).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 8, 23, 14, 36, 12, 777, DateTimeKind.Local).AddTicks(5638));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 8, 23, 14, 36, 12, 777, DateTimeKind.Local).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 8, 23, 14, 36, 12, 777, DateTimeKind.Local).AddTicks(5642));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 8, 23, 14, 36, 12, 777, DateTimeKind.Local).AddTicks(5644));
  }
    }
}
