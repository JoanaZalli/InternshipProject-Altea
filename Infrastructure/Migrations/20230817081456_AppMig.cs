using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AppMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ApplicationStatuses_LoanStatusId",
                table: "ApplicationStatuses");

         
            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 17, 10, 14, 56, 283, DateTimeKind.Local).AddTicks(8686), new DateTime(2023, 8, 17, 10, 14, 56, 283, DateTimeKind.Local).AddTicks(8702) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" , "LoanStatusId" },
                values: new object[] { new DateTime(2023, 8, 17, 10, 14, 56, 283, DateTimeKind.Local).AddTicks(8705), new DateTime(2023, 8, 17, 10, 14, 56, 283, DateTimeKind.Local).AddTicks(8706),1 });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated", "LoanStatusId" },
                values: new object[] { new DateTime(2023, 8, 17, 10, 14, 56, 283, DateTimeKind.Local).AddTicks(8708), new DateTime(2023, 8, 17, 10, 14, 56, 283, DateTimeKind.Local).AddTicks(8710),10 });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated", "LoanStatusId" },
                values: new object[] { new DateTime(2023, 8, 17, 10, 14, 56, 283, DateTimeKind.Local).AddTicks(8712), new DateTime(2023, 8, 17, 10, 14, 56, 283, DateTimeKind.Local).AddTicks(8713),7 });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" , "LoanStatusId" },
                values: new object[] { new DateTime(2023, 8, 17, 10, 14, 56, 283, DateTimeKind.Local).AddTicks(8715), new DateTime(2023, 8, 17, 10, 14, 56, 283, DateTimeKind.Local).AddTicks(8717),4 });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated", "LoanStatusId" },
                values: new object[] { new DateTime(2023, 8, 17, 10, 14, 56, 283, DateTimeKind.Local).AddTicks(8719), new DateTime(2023, 8, 17, 10, 14, 56, 283, DateTimeKind.Local).AddTicks(8720),9 });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" , "LoanStatusId" },
                values: new object[] { new DateTime(2023, 8, 17, 10, 14, 56, 283, DateTimeKind.Local).AddTicks(8722), new DateTime(2023, 8, 17, 10, 14, 56, 283, DateTimeKind.Local).AddTicks(8724) ,3});

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" , "LoanStatusId" },
                values: new object[] { new DateTime(2023, 8, 17, 10, 14, 56, 283, DateTimeKind.Local).AddTicks(8726), new DateTime(2023, 8, 17, 10, 14, 56, 283, DateTimeKind.Local).AddTicks(8727),8 });
    }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {



            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 17, 10, 14, 56, 283, DateTimeKind.Local).AddTicks(8686), new DateTime(2023, 8, 17, 10, 14, 56, 283, DateTimeKind.Local).AddTicks(8702) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated", "LoanStatusId" },
                values: new object[] { new DateTime(2023, 8, 17, 10, 14, 56, 283, DateTimeKind.Local).AddTicks(8705), new DateTime(2023, 8, 17, 10, 14, 56, 283, DateTimeKind.Local).AddTicks(8706), 1 });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated", "LoanStatusId" },
                values: new object[] { new DateTime(2023, 8, 17, 10, 14, 56, 283, DateTimeKind.Local).AddTicks(8708), new DateTime(2023, 8, 17, 10, 14, 56, 283, DateTimeKind.Local).AddTicks(8710), 10 });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated", "LoanStatusId" },
                values: new object[] { new DateTime(2023, 8, 17, 10, 14, 56, 283, DateTimeKind.Local).AddTicks(8712), new DateTime(2023, 8, 17, 10, 14, 56, 283, DateTimeKind.Local).AddTicks(8713), 7 });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated", "LoanStatusId" },
                values: new object[] { new DateTime(2023, 8, 17, 10, 14, 56, 283, DateTimeKind.Local).AddTicks(8715), new DateTime(2023, 8, 17, 10, 14, 56, 283, DateTimeKind.Local).AddTicks(8717), 4 });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated", "LoanStatusId" },
                values: new object[] { new DateTime(2023, 8, 17, 10, 14, 56, 283, DateTimeKind.Local).AddTicks(8719), new DateTime(2023, 8, 17, 10, 14, 56, 283, DateTimeKind.Local).AddTicks(8720), 9 });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated", "LoanStatusId" },
                values: new object[] { new DateTime(2023, 8, 17, 10, 14, 56, 283, DateTimeKind.Local).AddTicks(8722), new DateTime(2023, 8, 17, 10, 14, 56, 283, DateTimeKind.Local).AddTicks(8724), 3 });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated", "LoanStatusId" },
                values: new object[] { new DateTime(2023, 8, 17, 10, 14, 56, 283, DateTimeKind.Local).AddTicks(8726), new DateTime(2023, 8, 17, 10, 14, 56, 283, DateTimeKind.Local).AddTicks(8727), 8 });


            migrationBuilder.CreateIndex(
                name: "IX_ApplicationStatuses_LoanStatusId",
                table: "ApplicationStatuses",
                column: "LoanStatusId");
        }
    }
}
