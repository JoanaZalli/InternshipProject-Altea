using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class test123 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20656626-bf43-4ce8-8ddf-30fcc30f6228");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4650930e-bb95-4789-935d-9527e871eb9d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a270aa45-195a-4d5e-84c6-bf789cb1a6fc");

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 11, 16, 41, 58, 111, DateTimeKind.Local).AddTicks(7008), new DateTime(2023, 8, 11, 16, 41, 58, 111, DateTimeKind.Local).AddTicks(7010) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 11, 16, 41, 58, 111, DateTimeKind.Local).AddTicks(7012), new DateTime(2023, 8, 11, 16, 41, 58, 111, DateTimeKind.Local).AddTicks(7013) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 11, 16, 41, 58, 111, DateTimeKind.Local).AddTicks(7015), new DateTime(2023, 8, 11, 16, 41, 58, 111, DateTimeKind.Local).AddTicks(7017) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 11, 16, 41, 58, 111, DateTimeKind.Local).AddTicks(7019), new DateTime(2023, 8, 11, 16, 41, 58, 111, DateTimeKind.Local).AddTicks(7020) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 11, 16, 41, 58, 111, DateTimeKind.Local).AddTicks(7022), new DateTime(2023, 8, 11, 16, 41, 58, 111, DateTimeKind.Local).AddTicks(7023) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 11, 16, 41, 58, 111, DateTimeKind.Local).AddTicks(7025), new DateTime(2023, 8, 11, 16, 41, 58, 111, DateTimeKind.Local).AddTicks(7027) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 11, 16, 41, 58, 111, DateTimeKind.Local).AddTicks(7029), new DateTime(2023, 8, 11, 16, 41, 58, 111, DateTimeKind.Local).AddTicks(7030) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 11, 16, 41, 58, 111, DateTimeKind.Local).AddTicks(7032), new DateTime(2023, 8, 11, 16, 41, 58, 111, DateTimeKind.Local).AddTicks(7033) });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8f53703f-00ca-466c-9f03-cc25d4a0a829", null, "Borrower", "BORROWER" },
                    { "aadfa59b-5558-4fb8-9889-766af52611e4", null, "Loan Officer", "LOAN OFFICER" },
                    { "b26a77f0-feed-4630-aebe-bac0e1a7a26e", null, "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 8, 11, 16, 41, 58, 111, DateTimeKind.Local).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 8, 11, 16, 41, 58, 111, DateTimeKind.Local).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 8, 11, 16, 41, 58, 111, DateTimeKind.Local).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 8, 11, 16, 41, 58, 111, DateTimeKind.Local).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 8, 11, 16, 41, 58, 111, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 8, 11, 16, 41, 58, 111, DateTimeKind.Local).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "Lenders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 8, 11, 16, 41, 58, 111, DateTimeKind.Local).AddTicks(7123), new DateTime(2023, 8, 11, 16, 41, 58, 111, DateTimeKind.Local).AddTicks(7125) });

            migrationBuilder.UpdateData(
                table: "Lenders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 8, 11, 16, 41, 58, 111, DateTimeKind.Local).AddTicks(7127), new DateTime(2023, 8, 11, 16, 41, 58, 111, DateTimeKind.Local).AddTicks(7129) });

            migrationBuilder.UpdateData(
                table: "Lenders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 8, 11, 16, 41, 58, 111, DateTimeKind.Local).AddTicks(7131), new DateTime(2023, 8, 11, 16, 41, 58, 111, DateTimeKind.Local).AddTicks(7132) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 11, 16, 41, 58, 111, DateTimeKind.Local).AddTicks(7052), new DateTime(2023, 8, 11, 16, 41, 58, 111, DateTimeKind.Local).AddTicks(7054) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 11, 16, 41, 58, 111, DateTimeKind.Local).AddTicks(7056), new DateTime(2023, 8, 11, 16, 41, 58, 111, DateTimeKind.Local).AddTicks(7058) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 11, 16, 41, 58, 111, DateTimeKind.Local).AddTicks(7059), new DateTime(2023, 8, 11, 16, 41, 58, 111, DateTimeKind.Local).AddTicks(7061) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 11, 16, 41, 58, 111, DateTimeKind.Local).AddTicks(7063), new DateTime(2023, 8, 11, 16, 41, 58, 111, DateTimeKind.Local).AddTicks(7064) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 11, 16, 41, 58, 111, DateTimeKind.Local).AddTicks(7066), new DateTime(2023, 8, 11, 16, 41, 58, 111, DateTimeKind.Local).AddTicks(7067) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 11, 16, 41, 58, 111, DateTimeKind.Local).AddTicks(7069), new DateTime(2023, 8, 11, 16, 41, 58, 111, DateTimeKind.Local).AddTicks(7070) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 11, 16, 41, 58, 111, DateTimeKind.Local).AddTicks(7072), new DateTime(2023, 8, 11, 16, 41, 58, 111, DateTimeKind.Local).AddTicks(7074) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 11, 16, 41, 58, 111, DateTimeKind.Local).AddTicks(7076), new DateTime(2023, 8, 11, 16, 41, 58, 111, DateTimeKind.Local).AddTicks(7077) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 11, 16, 41, 58, 111, DateTimeKind.Local).AddTicks(7079), new DateTime(2023, 8, 11, 16, 41, 58, 111, DateTimeKind.Local).AddTicks(7080) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 11, 16, 41, 58, 111, DateTimeKind.Local).AddTicks(7082), new DateTime(2023, 8, 11, 16, 41, 58, 111, DateTimeKind.Local).AddTicks(7084) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f53703f-00ca-466c-9f03-cc25d4a0a829");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aadfa59b-5558-4fb8-9889-766af52611e4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b26a77f0-feed-4630-aebe-bac0e1a7a26e");

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 11, 16, 40, 5, 206, DateTimeKind.Local).AddTicks(4767), new DateTime(2023, 8, 11, 16, 40, 5, 206, DateTimeKind.Local).AddTicks(4770) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 11, 16, 40, 5, 206, DateTimeKind.Local).AddTicks(4772), new DateTime(2023, 8, 11, 16, 40, 5, 206, DateTimeKind.Local).AddTicks(4773) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 11, 16, 40, 5, 206, DateTimeKind.Local).AddTicks(4775), new DateTime(2023, 8, 11, 16, 40, 5, 206, DateTimeKind.Local).AddTicks(4777) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 11, 16, 40, 5, 206, DateTimeKind.Local).AddTicks(4779), new DateTime(2023, 8, 11, 16, 40, 5, 206, DateTimeKind.Local).AddTicks(4780) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 11, 16, 40, 5, 206, DateTimeKind.Local).AddTicks(4782), new DateTime(2023, 8, 11, 16, 40, 5, 206, DateTimeKind.Local).AddTicks(4784) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 11, 16, 40, 5, 206, DateTimeKind.Local).AddTicks(4786), new DateTime(2023, 8, 11, 16, 40, 5, 206, DateTimeKind.Local).AddTicks(4788) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 11, 16, 40, 5, 206, DateTimeKind.Local).AddTicks(4790), new DateTime(2023, 8, 11, 16, 40, 5, 206, DateTimeKind.Local).AddTicks(4791) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 11, 16, 40, 5, 206, DateTimeKind.Local).AddTicks(4793), new DateTime(2023, 8, 11, 16, 40, 5, 206, DateTimeKind.Local).AddTicks(4795) });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "20656626-bf43-4ce8-8ddf-30fcc30f6228", null, "Admin", "ADMIN" },
                    { "4650930e-bb95-4789-935d-9527e871eb9d", null, "Loan Officer", "LOAN OFFICER" },
                    { "a270aa45-195a-4d5e-84c6-bf789cb1a6fc", null, "Borrower", "BORROWER" }
                });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 8, 11, 16, 40, 5, 206, DateTimeKind.Local).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 8, 11, 16, 40, 5, 206, DateTimeKind.Local).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 8, 11, 16, 40, 5, 206, DateTimeKind.Local).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 8, 11, 16, 40, 5, 206, DateTimeKind.Local).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 8, 11, 16, 40, 5, 206, DateTimeKind.Local).AddTicks(4684));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 8, 11, 16, 40, 5, 206, DateTimeKind.Local).AddTicks(4686));

            migrationBuilder.UpdateData(
                table: "Lenders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 8, 11, 16, 40, 5, 206, DateTimeKind.Local).AddTicks(4887), new DateTime(2023, 8, 11, 16, 40, 5, 206, DateTimeKind.Local).AddTicks(4889) });

            migrationBuilder.UpdateData(
                table: "Lenders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 8, 11, 16, 40, 5, 206, DateTimeKind.Local).AddTicks(4891), new DateTime(2023, 8, 11, 16, 40, 5, 206, DateTimeKind.Local).AddTicks(4892) });

            migrationBuilder.UpdateData(
                table: "Lenders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 8, 11, 16, 40, 5, 206, DateTimeKind.Local).AddTicks(4895), new DateTime(2023, 8, 11, 16, 40, 5, 206, DateTimeKind.Local).AddTicks(4896) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 11, 16, 40, 5, 206, DateTimeKind.Local).AddTicks(4813), new DateTime(2023, 8, 11, 16, 40, 5, 206, DateTimeKind.Local).AddTicks(4816) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 11, 16, 40, 5, 206, DateTimeKind.Local).AddTicks(4818), new DateTime(2023, 8, 11, 16, 40, 5, 206, DateTimeKind.Local).AddTicks(4819) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 11, 16, 40, 5, 206, DateTimeKind.Local).AddTicks(4821), new DateTime(2023, 8, 11, 16, 40, 5, 206, DateTimeKind.Local).AddTicks(4823) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 11, 16, 40, 5, 206, DateTimeKind.Local).AddTicks(4825), new DateTime(2023, 8, 11, 16, 40, 5, 206, DateTimeKind.Local).AddTicks(4826) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 11, 16, 40, 5, 206, DateTimeKind.Local).AddTicks(4828), new DateTime(2023, 8, 11, 16, 40, 5, 206, DateTimeKind.Local).AddTicks(4830) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 11, 16, 40, 5, 206, DateTimeKind.Local).AddTicks(4832), new DateTime(2023, 8, 11, 16, 40, 5, 206, DateTimeKind.Local).AddTicks(4834) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 11, 16, 40, 5, 206, DateTimeKind.Local).AddTicks(4836), new DateTime(2023, 8, 11, 16, 40, 5, 206, DateTimeKind.Local).AddTicks(4837) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 11, 16, 40, 5, 206, DateTimeKind.Local).AddTicks(4839), new DateTime(2023, 8, 11, 16, 40, 5, 206, DateTimeKind.Local).AddTicks(4841) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 11, 16, 40, 5, 206, DateTimeKind.Local).AddTicks(4843), new DateTime(2023, 8, 11, 16, 40, 5, 206, DateTimeKind.Local).AddTicks(4845) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 11, 16, 40, 5, 206, DateTimeKind.Local).AddTicks(4847), new DateTime(2023, 8, 11, 16, 40, 5, 206, DateTimeKind.Local).AddTicks(4848) });
        }
    }
}
