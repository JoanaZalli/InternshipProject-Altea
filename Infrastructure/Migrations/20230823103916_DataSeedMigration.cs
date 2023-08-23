using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DataSeedMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ApplicationStatuses",
                columns: new[] { "Id", "Created", "LoanStatusId", "Name", "Updated" },
                values: new object[] { 1, new DateTime(2023, 8, 23, 12, 39, 16, 508, DateTimeKind.Local).AddTicks(9124), null, "In Charge", new DateTime(2023, 8, 23, 12, 39, 16, 508, DateTimeKind.Local).AddTicks(9126) });

          
            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "Company_Type", "DateCreated" },
                values: new object[,]
                {
                    { 1, "Sole proprietorship (S.I.)", new DateTime(2023, 8, 23, 12, 39, 16, 508, DateTimeKind.Local).AddTicks(6590) },
                    { 2, "Other", new DateTime(2023, 8, 23, 12, 39, 16, 508, DateTimeKind.Local).AddTicks(6638) },
                    { 3, "Partnership limited by shares (p.l.sh.)", new DateTime(2023, 8, 23, 12, 39, 16, 508, DateTimeKind.Local).AddTicks(6640) },
                    { 4, "Limited partnership (l.p.)", new DateTime(2023, 8, 23, 12, 39, 16, 508, DateTimeKind.Local).AddTicks(6642) },
                    { 5, "Cooperative Society (c.s.)", new DateTime(2023, 8, 23, 12, 39, 16, 508, DateTimeKind.Local).AddTicks(6644) },
                    { 6, "General partnership (g.p.)", new DateTime(2023, 8, 23, 12, 39, 16, 508, DateTimeKind.Local).AddTicks(6645) }
                });

            migrationBuilder.InsertData(
                table: "Lenders",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 23, 12, 39, 16, 508, DateTimeKind.Local).AddTicks(9187), new DateTime(2023, 8, 23, 12, 39, 16, 508, DateTimeKind.Local).AddTicks(9189), null, "PMI BTECH" },
                    { 2, new DateTime(2023, 8, 23, 12, 39, 16, 508, DateTimeKind.Local).AddTicks(9191), new DateTime(2023, 8, 23, 12, 39, 16, 508, DateTimeKind.Local).AddTicks(9192), null, "AZIF" },
                    { 3, new DateTime(2023, 8, 23, 12, 39, 16, 508, DateTimeKind.Local).AddTicks(9194), new DateTime(2023, 8, 23, 12, 39, 16, 508, DateTimeKind.Local).AddTicks(9195), null, "LOGITECH" }
                });

            migrationBuilder.InsertData(
                table: "LoanStatuses",
                columns: new[] { "Id", "Created", "Name", "Updated" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 23, 12, 39, 16, 508, DateTimeKind.Local).AddTicks(9052), "Created", new DateTime(2023, 8, 23, 12, 39, 16, 508, DateTimeKind.Local).AddTicks(9068) },
                    { 2, new DateTime(2023, 8, 23, 12, 39, 16, 508, DateTimeKind.Local).AddTicks(9070), "Accepted", new DateTime(2023, 8, 23, 12, 39, 16, 508, DateTimeKind.Local).AddTicks(9072) },
                    { 3, new DateTime(2023, 8, 23, 12, 39, 16, 508, DateTimeKind.Local).AddTicks(9074), "Rejected", new DateTime(2023, 8, 23, 12, 39, 16, 508, DateTimeKind.Local).AddTicks(9075) },
                    { 4, new DateTime(2023, 8, 23, 12, 39, 16, 508, DateTimeKind.Local).AddTicks(9077), "Disbursed", new DateTime(2023, 8, 23, 12, 39, 16, 508, DateTimeKind.Local).AddTicks(9078) },
                    { 5, new DateTime(2023, 8, 23, 12, 39, 16, 508, DateTimeKind.Local).AddTicks(9080), "Current", new DateTime(2023, 8, 23, 12, 39, 16, 508, DateTimeKind.Local).AddTicks(9082) },
                    { 6, new DateTime(2023, 8, 23, 12, 39, 16, 508, DateTimeKind.Local).AddTicks(9083), "In Arrears", new DateTime(2023, 8, 23, 12, 39, 16, 508, DateTimeKind.Local).AddTicks(9085) },
                    { 7, new DateTime(2023, 8, 23, 12, 39, 16, 508, DateTimeKind.Local).AddTicks(9087), "Defaulted", new DateTime(2023, 8, 23, 12, 39, 16, 508, DateTimeKind.Local).AddTicks(9088) },
                    { 8, new DateTime(2023, 8, 23, 12, 39, 16, 508, DateTimeKind.Local).AddTicks(9090), "Repaid", new DateTime(2023, 8, 23, 12, 39, 16, 508, DateTimeKind.Local).AddTicks(9092) },
                    { 9, new DateTime(2023, 8, 23, 12, 39, 16, 508, DateTimeKind.Local).AddTicks(9093), "Guaranteed", new DateTime(2023, 8, 23, 12, 39, 16, 508, DateTimeKind.Local).AddTicks(9095) },
                    { 10, new DateTime(2023, 8, 23, 12, 39, 16, 508, DateTimeKind.Local).AddTicks(9097), "Erased", new DateTime(2023, 8, 23, 12, 39, 16, 508, DateTimeKind.Local).AddTicks(9098) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Max_Financed_Amount", "Min_Financed_Amount", "Name", "Refernce_rate" },
                values: new object[,]
                {
                    { 1, "Installments with pre-amortization at a fixed rate", 200000000m, 1000000m, "Installments with pre-amortization at a fixed rate", 0.0025000000000000001 },
                    { 2, "Installment with variable rate pre-amortization", 100000000m, 1000000m, "Installment with variable rate pre-amortization", 0.029999999999999999 }
                });

            migrationBuilder.InsertData(
                table: "ApplicationStatuses",
                columns: new[] { "Id", "Created", "LoanStatusId", "Name", "Updated" },
                values: new object[,]
                {
                    { 2, new DateTime(2023, 8, 23, 12, 39, 16, 508, DateTimeKind.Local).AddTicks(9128), 1, "Loan Issued", new DateTime(2023, 8, 23, 12, 39, 16, 508, DateTimeKind.Local).AddTicks(9130) },
                    { 3, new DateTime(2023, 8, 23, 12, 39, 16, 508, DateTimeKind.Local).AddTicks(9132), 10, "Loan Canceled", new DateTime(2023, 8, 23, 12, 39, 16, 508, DateTimeKind.Local).AddTicks(9133) },
                    { 4, new DateTime(2023, 8, 23, 12, 39, 16, 508, DateTimeKind.Local).AddTicks(9136), 7, "Loan Defaulted", new DateTime(2023, 8, 23, 12, 39, 16, 508, DateTimeKind.Local).AddTicks(9137) },
                    { 5, new DateTime(2023, 8, 23, 12, 39, 16, 508, DateTimeKind.Local).AddTicks(9139), 4, "Loan Disbursed", new DateTime(2023, 8, 23, 12, 39, 16, 508, DateTimeKind.Local).AddTicks(9141) },
                    { 6, new DateTime(2023, 8, 23, 12, 39, 16, 508, DateTimeKind.Local).AddTicks(9143), 9, "Loan Guaranteed", new DateTime(2023, 8, 23, 12, 39, 16, 508, DateTimeKind.Local).AddTicks(9144) },
                    { 7, new DateTime(2023, 8, 23, 12, 39, 16, 508, DateTimeKind.Local).AddTicks(9146), 3, "Loan Rejected", new DateTime(2023, 8, 23, 12, 39, 16, 508, DateTimeKind.Local).AddTicks(9148) },
                    { 8, new DateTime(2023, 8, 23, 12, 39, 16, 508, DateTimeKind.Local).AddTicks(9150), 8, "Loan Repaid", new DateTime(2023, 8, 23, 12, 39, 16, 508, DateTimeKind.Local).AddTicks(9151) }
                });

            migrationBuilder.InsertData(
                table: "LenderConditions",
                columns: new[] { "Id", "CompanyTypeId", "LenderId", "MinRequestedAmount", "TenorMax", "TenorMin" },
                values: new object[,]
                {
                    { 1, 5, 1, 100000m, null, 30m },
                    { 2, null, 2, 400000m, 60m, 40m },
                    { 3, 1, 3, 100000m, 60m, 30m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 8);

           
            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "LenderConditions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LenderConditions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LenderConditions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Lenders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Lenders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Lenders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
