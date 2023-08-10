using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CompanyProfileMigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "25da0d5b-5938-4d88-8c04-1fc1ccde4fec");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c596973e-afc9-4aa8-92e0-867d82654e9f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e165c86b-f966-4a32-b138-e47f97528b29");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "83f9b799-9031-4d12-ab7b-20e4100d94db");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "CompanyProfiles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 40, 9, 361, DateTimeKind.Local).AddTicks(2253), new DateTime(2023, 8, 10, 15, 40, 9, 361, DateTimeKind.Local).AddTicks(2256) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 40, 9, 361, DateTimeKind.Local).AddTicks(2258), new DateTime(2023, 8, 10, 15, 40, 9, 361, DateTimeKind.Local).AddTicks(2259) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 40, 9, 361, DateTimeKind.Local).AddTicks(2261), new DateTime(2023, 8, 10, 15, 40, 9, 361, DateTimeKind.Local).AddTicks(2263) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 40, 9, 361, DateTimeKind.Local).AddTicks(2264), new DateTime(2023, 8, 10, 15, 40, 9, 361, DateTimeKind.Local).AddTicks(2266) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 40, 9, 361, DateTimeKind.Local).AddTicks(2268), new DateTime(2023, 8, 10, 15, 40, 9, 361, DateTimeKind.Local).AddTicks(2269) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 40, 9, 361, DateTimeKind.Local).AddTicks(2271), new DateTime(2023, 8, 10, 15, 40, 9, 361, DateTimeKind.Local).AddTicks(2273) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 40, 9, 361, DateTimeKind.Local).AddTicks(2275), new DateTime(2023, 8, 10, 15, 40, 9, 361, DateTimeKind.Local).AddTicks(2276) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 40, 9, 361, DateTimeKind.Local).AddTicks(2278), new DateTime(2023, 8, 10, 15, 40, 9, 361, DateTimeKind.Local).AddTicks(2280) });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8924e31c-1a2e-4178-8512-b51f2ae86933", null, "Loan Officer", "LOAN OFFICER" },
                    { "9bfcd3a1-1bca-4b70-9071-d165453cef6d", null, "Admin", "ADMIN" },
                    { "b81063c0-4b79-4e84-9e24-15ecba5aabbd", null, "Borrower", "BORROWER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccesToken", "AccesTokenExpiryTime", "AccessFailedCount", "BlockEnd", "ConcurrencyStamp", "Email", "EmailConfirmed", "FailedLoginAttempts", "FirstName", "IsBlocked", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordRecoveyToken", "PasswordRecoveyTokenCreationTime", "PhoneNumber", "PhoneNumberConfirmed", "PrefixId", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "Token", "TokenCreationTime", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b2291990-e56c-4355-bc03-1b767b78d77e", null, null, 0, null, "78d8fc8b-caa5-4068-8a1d-ef19df9e0d6c", "admin@gmail.com", true, 0, "admin", false, "admin", false, null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, null, null, "54c9d532-81c7-4227-930c-d0ca4d5feac8", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "admin1" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 15, 40, 9, 361, DateTimeKind.Local).AddTicks(2127));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 15, 40, 9, 361, DateTimeKind.Local).AddTicks(2175));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 15, 40, 9, 361, DateTimeKind.Local).AddTicks(2177));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 15, 40, 9, 361, DateTimeKind.Local).AddTicks(2179));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 15, 40, 9, 361, DateTimeKind.Local).AddTicks(2181));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 15, 40, 9, 361, DateTimeKind.Local).AddTicks(2183));

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 40, 9, 361, DateTimeKind.Local).AddTicks(2297), new DateTime(2023, 8, 10, 15, 40, 9, 361, DateTimeKind.Local).AddTicks(2299) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 40, 9, 361, DateTimeKind.Local).AddTicks(2301), new DateTime(2023, 8, 10, 15, 40, 9, 361, DateTimeKind.Local).AddTicks(2303) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 40, 9, 361, DateTimeKind.Local).AddTicks(2304), new DateTime(2023, 8, 10, 15, 40, 9, 361, DateTimeKind.Local).AddTicks(2306) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 40, 9, 361, DateTimeKind.Local).AddTicks(2308), new DateTime(2023, 8, 10, 15, 40, 9, 361, DateTimeKind.Local).AddTicks(2309) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 40, 9, 361, DateTimeKind.Local).AddTicks(2311), new DateTime(2023, 8, 10, 15, 40, 9, 361, DateTimeKind.Local).AddTicks(2313) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 40, 9, 361, DateTimeKind.Local).AddTicks(2315), new DateTime(2023, 8, 10, 15, 40, 9, 361, DateTimeKind.Local).AddTicks(2316) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 40, 9, 361, DateTimeKind.Local).AddTicks(2318), new DateTime(2023, 8, 10, 15, 40, 9, 361, DateTimeKind.Local).AddTicks(2319) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 40, 9, 361, DateTimeKind.Local).AddTicks(2321), new DateTime(2023, 8, 10, 15, 40, 9, 361, DateTimeKind.Local).AddTicks(2323) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 40, 9, 361, DateTimeKind.Local).AddTicks(2325), new DateTime(2023, 8, 10, 15, 40, 9, 361, DateTimeKind.Local).AddTicks(2326) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 40, 9, 361, DateTimeKind.Local).AddTicks(2328), new DateTime(2023, 8, 10, 15, 40, 9, 361, DateTimeKind.Local).AddTicks(2330) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8924e31c-1a2e-4178-8512-b51f2ae86933");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9bfcd3a1-1bca-4b70-9071-d165453cef6d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b81063c0-4b79-4e84-9e24-15ecba5aabbd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2291990-e56c-4355-bc03-1b767b78d77e");

            migrationBuilder.AlterColumn<int>(
                name: "Phone",
                table: "CompanyProfiles",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 38, 50, 332, DateTimeKind.Local).AddTicks(6442), new DateTime(2023, 8, 10, 15, 38, 50, 332, DateTimeKind.Local).AddTicks(6444) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 38, 50, 332, DateTimeKind.Local).AddTicks(6446), new DateTime(2023, 8, 10, 15, 38, 50, 332, DateTimeKind.Local).AddTicks(6447) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 38, 50, 332, DateTimeKind.Local).AddTicks(6449), new DateTime(2023, 8, 10, 15, 38, 50, 332, DateTimeKind.Local).AddTicks(6451) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 38, 50, 332, DateTimeKind.Local).AddTicks(6453), new DateTime(2023, 8, 10, 15, 38, 50, 332, DateTimeKind.Local).AddTicks(6454) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 38, 50, 332, DateTimeKind.Local).AddTicks(6456), new DateTime(2023, 8, 10, 15, 38, 50, 332, DateTimeKind.Local).AddTicks(6458) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 38, 50, 332, DateTimeKind.Local).AddTicks(6460), new DateTime(2023, 8, 10, 15, 38, 50, 332, DateTimeKind.Local).AddTicks(6461) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 38, 50, 332, DateTimeKind.Local).AddTicks(6463), new DateTime(2023, 8, 10, 15, 38, 50, 332, DateTimeKind.Local).AddTicks(6464) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 38, 50, 332, DateTimeKind.Local).AddTicks(6466), new DateTime(2023, 8, 10, 15, 38, 50, 332, DateTimeKind.Local).AddTicks(6468) });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "25da0d5b-5938-4d88-8c04-1fc1ccde4fec", null, "Borrower", "BORROWER" },
                    { "c596973e-afc9-4aa8-92e0-867d82654e9f", null, "Loan Officer", "LOAN OFFICER" },
                    { "e165c86b-f966-4a32-b138-e47f97528b29", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccesToken", "AccesTokenExpiryTime", "AccessFailedCount", "BlockEnd", "ConcurrencyStamp", "Email", "EmailConfirmed", "FailedLoginAttempts", "FirstName", "IsBlocked", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordRecoveyToken", "PasswordRecoveyTokenCreationTime", "PhoneNumber", "PhoneNumberConfirmed", "PrefixId", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "Token", "TokenCreationTime", "TwoFactorEnabled", "UserName" },
                values: new object[] { "83f9b799-9031-4d12-ab7b-20e4100d94db", null, null, 0, null, "f1e250e6-ffa9-435d-b733-af3edb4e77e7", "admin@gmail.com", true, 0, "admin", false, "admin", false, null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, null, null, "03e77442-153e-4b24-b0e4-6317a69e6154", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "admin1" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 15, 38, 50, 332, DateTimeKind.Local).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 15, 38, 50, 332, DateTimeKind.Local).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 15, 38, 50, 332, DateTimeKind.Local).AddTicks(6348));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 15, 38, 50, 332, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 15, 38, 50, 332, DateTimeKind.Local).AddTicks(6352));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 15, 38, 50, 332, DateTimeKind.Local).AddTicks(6354));

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 38, 50, 332, DateTimeKind.Local).AddTicks(6485), new DateTime(2023, 8, 10, 15, 38, 50, 332, DateTimeKind.Local).AddTicks(6487) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 38, 50, 332, DateTimeKind.Local).AddTicks(6489), new DateTime(2023, 8, 10, 15, 38, 50, 332, DateTimeKind.Local).AddTicks(6491) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 38, 50, 332, DateTimeKind.Local).AddTicks(6493), new DateTime(2023, 8, 10, 15, 38, 50, 332, DateTimeKind.Local).AddTicks(6494) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 38, 50, 332, DateTimeKind.Local).AddTicks(6496), new DateTime(2023, 8, 10, 15, 38, 50, 332, DateTimeKind.Local).AddTicks(6498) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 38, 50, 332, DateTimeKind.Local).AddTicks(6500), new DateTime(2023, 8, 10, 15, 38, 50, 332, DateTimeKind.Local).AddTicks(6501) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 38, 50, 332, DateTimeKind.Local).AddTicks(6503), new DateTime(2023, 8, 10, 15, 38, 50, 332, DateTimeKind.Local).AddTicks(6504) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 38, 50, 332, DateTimeKind.Local).AddTicks(6506), new DateTime(2023, 8, 10, 15, 38, 50, 332, DateTimeKind.Local).AddTicks(6508) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 38, 50, 332, DateTimeKind.Local).AddTicks(6510), new DateTime(2023, 8, 10, 15, 38, 50, 332, DateTimeKind.Local).AddTicks(6511) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 38, 50, 332, DateTimeKind.Local).AddTicks(6513), new DateTime(2023, 8, 10, 15, 38, 50, 332, DateTimeKind.Local).AddTicks(6515) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 38, 50, 332, DateTimeKind.Local).AddTicks(6517), new DateTime(2023, 8, 10, 15, 38, 50, 332, DateTimeKind.Local).AddTicks(6518) });
        }
    }
}
