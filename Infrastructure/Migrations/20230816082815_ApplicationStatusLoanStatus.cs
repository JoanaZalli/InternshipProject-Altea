using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ApplicationStatusLoanStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationStatuses_LoanStatuses_LoanStatusId",
                table: "ApplicationStatuses");

       

            migrationBuilder.AlterColumn<int>(
                name: "LoanStatusId",
                table: "ApplicationStatuses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LoanStatusId", "Updated" },
                values: new object[] { new DateTime(2023, 8, 16, 10, 28, 15, 157, DateTimeKind.Local).AddTicks(2022), null, new DateTime(2023, 8, 16, 10, 28, 15, 157, DateTimeKind.Local).AddTicks(2024) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 16, 10, 28, 15, 157, DateTimeKind.Local).AddTicks(2026), new DateTime(2023, 8, 16, 10, 28, 15, 157, DateTimeKind.Local).AddTicks(2028) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 16, 10, 28, 15, 157, DateTimeKind.Local).AddTicks(2030), new DateTime(2023, 8, 16, 10, 28, 15, 157, DateTimeKind.Local).AddTicks(2032) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 16, 10, 28, 15, 157, DateTimeKind.Local).AddTicks(2034), new DateTime(2023, 8, 16, 10, 28, 15, 157, DateTimeKind.Local).AddTicks(2035) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 16, 10, 28, 15, 157, DateTimeKind.Local).AddTicks(2037), new DateTime(2023, 8, 16, 10, 28, 15, 157, DateTimeKind.Local).AddTicks(2039) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 16, 10, 28, 15, 157, DateTimeKind.Local).AddTicks(2041), new DateTime(2023, 8, 16, 10, 28, 15, 157, DateTimeKind.Local).AddTicks(2042) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 16, 10, 28, 15, 157, DateTimeKind.Local).AddTicks(2044), new DateTime(2023, 8, 16, 10, 28, 15, 157, DateTimeKind.Local).AddTicks(2046) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 16, 10, 28, 15, 157, DateTimeKind.Local).AddTicks(2048), new DateTime(2023, 8, 16, 10, 28, 15, 157, DateTimeKind.Local).AddTicks(2049) });

           

          
            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationStatuses_LoanStatuses_LoanStatusId",
                table: "ApplicationStatuses",
                column: "LoanStatusId",
                principalTable: "LoanStatuses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationStatuses_LoanStatuses_LoanStatusId",
                table: "ApplicationStatuses");

         
            migrationBuilder.AlterColumn<int>(
                name: "LoanStatusId",
                table: "ApplicationStatuses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LoanStatusId", "Updated" },
                values: new object[] { new DateTime(2023, 8, 16, 10, 25, 44, 629, DateTimeKind.Local).AddTicks(7093), 0, new DateTime(2023, 8, 16, 10, 25, 44, 629, DateTimeKind.Local).AddTicks(7095) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 16, 10, 25, 44, 629, DateTimeKind.Local).AddTicks(7097), new DateTime(2023, 8, 16, 10, 25, 44, 629, DateTimeKind.Local).AddTicks(7098) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 16, 10, 25, 44, 629, DateTimeKind.Local).AddTicks(7100), new DateTime(2023, 8, 16, 10, 25, 44, 629, DateTimeKind.Local).AddTicks(7102) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 16, 10, 25, 44, 629, DateTimeKind.Local).AddTicks(7104), new DateTime(2023, 8, 16, 10, 25, 44, 629, DateTimeKind.Local).AddTicks(7105) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 16, 10, 25, 44, 629, DateTimeKind.Local).AddTicks(7107), new DateTime(2023, 8, 16, 10, 25, 44, 629, DateTimeKind.Local).AddTicks(7108) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 16, 10, 25, 44, 629, DateTimeKind.Local).AddTicks(7110), new DateTime(2023, 8, 16, 10, 25, 44, 629, DateTimeKind.Local).AddTicks(7112) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 16, 10, 25, 44, 629, DateTimeKind.Local).AddTicks(7114), new DateTime(2023, 8, 16, 10, 25, 44, 629, DateTimeKind.Local).AddTicks(7115) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 16, 10, 25, 44, 629, DateTimeKind.Local).AddTicks(7117), new DateTime(2023, 8, 16, 10, 25, 44, 629, DateTimeKind.Local).AddTicks(7119) });

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationStatuses_LoanStatuses_LoanStatusId",
                table: "ApplicationStatuses",
                column: "LoanStatusId",
                principalTable: "LoanStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
