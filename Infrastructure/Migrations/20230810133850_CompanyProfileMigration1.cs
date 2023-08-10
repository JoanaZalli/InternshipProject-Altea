using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CompanyProfileMigration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3000e407-397e-483c-bd80-2292110cdfa5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f2c4eb0-0a53-43bd-b087-b25e9c5bc135");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7ed814d-0286-40b8-84a0-a92d215a51f3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "705ba5f5-9f64-411e-ba83-be0731de0410");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new DateTime(2023, 8, 10, 15, 12, 59, 880, DateTimeKind.Local).AddTicks(3908), new DateTime(2023, 8, 10, 15, 12, 59, 880, DateTimeKind.Local).AddTicks(3910) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 12, 59, 880, DateTimeKind.Local).AddTicks(3912), new DateTime(2023, 8, 10, 15, 12, 59, 880, DateTimeKind.Local).AddTicks(3913) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 12, 59, 880, DateTimeKind.Local).AddTicks(3915), new DateTime(2023, 8, 10, 15, 12, 59, 880, DateTimeKind.Local).AddTicks(3917) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 12, 59, 880, DateTimeKind.Local).AddTicks(3919), new DateTime(2023, 8, 10, 15, 12, 59, 880, DateTimeKind.Local).AddTicks(3920) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 12, 59, 880, DateTimeKind.Local).AddTicks(3922), new DateTime(2023, 8, 10, 15, 12, 59, 880, DateTimeKind.Local).AddTicks(3923) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 12, 59, 880, DateTimeKind.Local).AddTicks(3925), new DateTime(2023, 8, 10, 15, 12, 59, 880, DateTimeKind.Local).AddTicks(3927) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 12, 59, 880, DateTimeKind.Local).AddTicks(3929), new DateTime(2023, 8, 10, 15, 12, 59, 880, DateTimeKind.Local).AddTicks(3930) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 12, 59, 880, DateTimeKind.Local).AddTicks(3932), new DateTime(2023, 8, 10, 15, 12, 59, 880, DateTimeKind.Local).AddTicks(3934) });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3000e407-397e-483c-bd80-2292110cdfa5", null, "Loan Officer", "LOAN OFFICER" },
                    { "5f2c4eb0-0a53-43bd-b087-b25e9c5bc135", null, "Admin", "ADMIN" },
                    { "a7ed814d-0286-40b8-84a0-a92d215a51f3", null, "Borrower", "BORROWER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccesToken", "AccesTokenExpiryTime", "AccessFailedCount", "BlockEnd", "ConcurrencyStamp", "Email", "EmailConfirmed", "FailedLoginAttempts", "FirstName", "IsBlocked", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordRecoveyToken", "PasswordRecoveyTokenCreationTime", "PhoneNumber", "PhoneNumberConfirmed", "PrefixId", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "Token", "TokenCreationTime", "TwoFactorEnabled", "UserName" },
                values: new object[] { "705ba5f5-9f64-411e-ba83-be0731de0410", null, null, 0, null, "b97bef3e-093f-410d-9c83-ac1a85c967cd", "admin@gmail.com", true, 0, "admin", false, "admin", false, null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, null, null, "b15d27b1-7797-4715-bc1b-a54a80b7d7b2", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "admin1" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 15, 12, 59, 880, DateTimeKind.Local).AddTicks(3794));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 15, 12, 59, 880, DateTimeKind.Local).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 15, 12, 59, 880, DateTimeKind.Local).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 15, 12, 59, 880, DateTimeKind.Local).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 15, 12, 59, 880, DateTimeKind.Local).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 15, 12, 59, 880, DateTimeKind.Local).AddTicks(3847));

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 12, 59, 880, DateTimeKind.Local).AddTicks(3953), new DateTime(2023, 8, 10, 15, 12, 59, 880, DateTimeKind.Local).AddTicks(3954) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 12, 59, 880, DateTimeKind.Local).AddTicks(3957), new DateTime(2023, 8, 10, 15, 12, 59, 880, DateTimeKind.Local).AddTicks(3958) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 12, 59, 880, DateTimeKind.Local).AddTicks(3960), new DateTime(2023, 8, 10, 15, 12, 59, 880, DateTimeKind.Local).AddTicks(3961) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 12, 59, 880, DateTimeKind.Local).AddTicks(3963), new DateTime(2023, 8, 10, 15, 12, 59, 880, DateTimeKind.Local).AddTicks(3965) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 12, 59, 880, DateTimeKind.Local).AddTicks(3967), new DateTime(2023, 8, 10, 15, 12, 59, 880, DateTimeKind.Local).AddTicks(3968) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 12, 59, 880, DateTimeKind.Local).AddTicks(3970), new DateTime(2023, 8, 10, 15, 12, 59, 880, DateTimeKind.Local).AddTicks(3972) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 12, 59, 880, DateTimeKind.Local).AddTicks(3974), new DateTime(2023, 8, 10, 15, 12, 59, 880, DateTimeKind.Local).AddTicks(3975) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 12, 59, 880, DateTimeKind.Local).AddTicks(3977), new DateTime(2023, 8, 10, 15, 12, 59, 880, DateTimeKind.Local).AddTicks(3979) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 12, 59, 880, DateTimeKind.Local).AddTicks(3981), new DateTime(2023, 8, 10, 15, 12, 59, 880, DateTimeKind.Local).AddTicks(3982) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 12, 59, 880, DateTimeKind.Local).AddTicks(3984), new DateTime(2023, 8, 10, 15, 12, 59, 880, DateTimeKind.Local).AddTicks(3986) });
        }
    }
}
