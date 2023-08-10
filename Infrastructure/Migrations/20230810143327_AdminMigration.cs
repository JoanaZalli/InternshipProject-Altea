using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AdminMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "936b3459-6008-481c-93fd-27ebc821fc69");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac6ac3a5-7b9a-4f99-9ab5-55315affd01d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f9e83fd9-9172-4d9a-a0cc-32f40f9705a0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c849cab5-efd3-4c8a-9a92-9739dfb4891f");

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 16, 33, 26, 893, DateTimeKind.Local).AddTicks(7269), new DateTime(2023, 8, 10, 16, 33, 26, 893, DateTimeKind.Local).AddTicks(7271) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 16, 33, 26, 893, DateTimeKind.Local).AddTicks(7274), new DateTime(2023, 8, 10, 16, 33, 26, 893, DateTimeKind.Local).AddTicks(7275) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 16, 33, 26, 893, DateTimeKind.Local).AddTicks(7325), new DateTime(2023, 8, 10, 16, 33, 26, 893, DateTimeKind.Local).AddTicks(7327) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 16, 33, 26, 893, DateTimeKind.Local).AddTicks(7329), new DateTime(2023, 8, 10, 16, 33, 26, 893, DateTimeKind.Local).AddTicks(7330) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 16, 33, 26, 893, DateTimeKind.Local).AddTicks(7332), new DateTime(2023, 8, 10, 16, 33, 26, 893, DateTimeKind.Local).AddTicks(7334) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 16, 33, 26, 893, DateTimeKind.Local).AddTicks(7336), new DateTime(2023, 8, 10, 16, 33, 26, 893, DateTimeKind.Local).AddTicks(7337) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 16, 33, 26, 893, DateTimeKind.Local).AddTicks(7339), new DateTime(2023, 8, 10, 16, 33, 26, 893, DateTimeKind.Local).AddTicks(7341) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 16, 33, 26, 893, DateTimeKind.Local).AddTicks(7342), new DateTime(2023, 8, 10, 16, 33, 26, 893, DateTimeKind.Local).AddTicks(7344) });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6eb872cc-7da6-45cb-b0ed-6904c4bbd06d", null, "Loan Officer", "LOAN OFFICER" },
                    { "e995ccf4-801b-41ed-9bab-82d6745dba80", null, "Admin", "ADMIN" },
                    { "f9c9c767-83d8-4181-9a03-90669c4f307b", null, "Borrower", "BORROWER" }
                });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 16, 33, 26, 893, DateTimeKind.Local).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 16, 33, 26, 893, DateTimeKind.Local).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 16, 33, 26, 893, DateTimeKind.Local).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 16, 33, 26, 893, DateTimeKind.Local).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 16, 33, 26, 893, DateTimeKind.Local).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 16, 33, 26, 893, DateTimeKind.Local).AddTicks(7221));

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 16, 33, 26, 893, DateTimeKind.Local).AddTicks(7365), new DateTime(2023, 8, 10, 16, 33, 26, 893, DateTimeKind.Local).AddTicks(7367) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 16, 33, 26, 893, DateTimeKind.Local).AddTicks(7369), new DateTime(2023, 8, 10, 16, 33, 26, 893, DateTimeKind.Local).AddTicks(7371) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 16, 33, 26, 893, DateTimeKind.Local).AddTicks(7373), new DateTime(2023, 8, 10, 16, 33, 26, 893, DateTimeKind.Local).AddTicks(7374) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 16, 33, 26, 893, DateTimeKind.Local).AddTicks(7376), new DateTime(2023, 8, 10, 16, 33, 26, 893, DateTimeKind.Local).AddTicks(7377) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 16, 33, 26, 893, DateTimeKind.Local).AddTicks(7379), new DateTime(2023, 8, 10, 16, 33, 26, 893, DateTimeKind.Local).AddTicks(7381) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 16, 33, 26, 893, DateTimeKind.Local).AddTicks(7383), new DateTime(2023, 8, 10, 16, 33, 26, 893, DateTimeKind.Local).AddTicks(7384) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 16, 33, 26, 893, DateTimeKind.Local).AddTicks(7386), new DateTime(2023, 8, 10, 16, 33, 26, 893, DateTimeKind.Local).AddTicks(7388) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 16, 33, 26, 893, DateTimeKind.Local).AddTicks(7390), new DateTime(2023, 8, 10, 16, 33, 26, 893, DateTimeKind.Local).AddTicks(7391) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 16, 33, 26, 893, DateTimeKind.Local).AddTicks(7393), new DateTime(2023, 8, 10, 16, 33, 26, 893, DateTimeKind.Local).AddTicks(7395) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 16, 33, 26, 893, DateTimeKind.Local).AddTicks(7397), new DateTime(2023, 8, 10, 16, 33, 26, 893, DateTimeKind.Local).AddTicks(7398) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6eb872cc-7da6-45cb-b0ed-6904c4bbd06d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e995ccf4-801b-41ed-9bab-82d6745dba80");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f9c9c767-83d8-4181-9a03-90669c4f307b");

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 16, 23, 23, 130, DateTimeKind.Local).AddTicks(5896), new DateTime(2023, 8, 10, 16, 23, 23, 130, DateTimeKind.Local).AddTicks(5898) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 16, 23, 23, 130, DateTimeKind.Local).AddTicks(5900), new DateTime(2023, 8, 10, 16, 23, 23, 130, DateTimeKind.Local).AddTicks(5902) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 16, 23, 23, 130, DateTimeKind.Local).AddTicks(5904), new DateTime(2023, 8, 10, 16, 23, 23, 130, DateTimeKind.Local).AddTicks(5905) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 16, 23, 23, 130, DateTimeKind.Local).AddTicks(5907), new DateTime(2023, 8, 10, 16, 23, 23, 130, DateTimeKind.Local).AddTicks(5908) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 16, 23, 23, 130, DateTimeKind.Local).AddTicks(5910), new DateTime(2023, 8, 10, 16, 23, 23, 130, DateTimeKind.Local).AddTicks(5912) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 16, 23, 23, 130, DateTimeKind.Local).AddTicks(5914), new DateTime(2023, 8, 10, 16, 23, 23, 130, DateTimeKind.Local).AddTicks(5915) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 16, 23, 23, 130, DateTimeKind.Local).AddTicks(5917), new DateTime(2023, 8, 10, 16, 23, 23, 130, DateTimeKind.Local).AddTicks(5919) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 16, 23, 23, 130, DateTimeKind.Local).AddTicks(5921), new DateTime(2023, 8, 10, 16, 23, 23, 130, DateTimeKind.Local).AddTicks(5922) });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "936b3459-6008-481c-93fd-27ebc821fc69", null, "Loan Officer", "LOAN OFFICER" },
                    { "ac6ac3a5-7b9a-4f99-9ab5-55315affd01d", null, "Admin", "ADMIN" },
                    { "f9e83fd9-9172-4d9a-a0cc-32f40f9705a0", null, "Borrower", "BORROWER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccesToken", "AccesTokenExpiryTime", "AccessFailedCount", "BlockEnd", "ConcurrencyStamp", "Email", "EmailConfirmed", "FailedLoginAttempts", "FirstName", "IsBlocked", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordRecoveyToken", "PasswordRecoveyTokenCreationTime", "PhoneNumber", "PhoneNumberConfirmed", "PrefixId", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "Token", "TokenCreationTime", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c849cab5-efd3-4c8a-9a92-9739dfb4891f", null, null, 0, null, "8f779a72-7b12-49f1-82ea-10c8a44ed060", "admin@gmail.com", true, 0, "admin", false, "admin", false, null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, null, null, "c27a5697-55bc-4a75-af59-1ed56adb96f9", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "admin1" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 16, 23, 23, 130, DateTimeKind.Local).AddTicks(5713));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 16, 23, 23, 130, DateTimeKind.Local).AddTicks(5761));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 16, 23, 23, 130, DateTimeKind.Local).AddTicks(5763));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 16, 23, 23, 130, DateTimeKind.Local).AddTicks(5765));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 16, 23, 23, 130, DateTimeKind.Local).AddTicks(5767));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 16, 23, 23, 130, DateTimeKind.Local).AddTicks(5769));

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 16, 23, 23, 130, DateTimeKind.Local).AddTicks(5940), new DateTime(2023, 8, 10, 16, 23, 23, 130, DateTimeKind.Local).AddTicks(5942) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 16, 23, 23, 130, DateTimeKind.Local).AddTicks(5944), new DateTime(2023, 8, 10, 16, 23, 23, 130, DateTimeKind.Local).AddTicks(5945) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 16, 23, 23, 130, DateTimeKind.Local).AddTicks(5947), new DateTime(2023, 8, 10, 16, 23, 23, 130, DateTimeKind.Local).AddTicks(5949) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 16, 23, 23, 130, DateTimeKind.Local).AddTicks(5951), new DateTime(2023, 8, 10, 16, 23, 23, 130, DateTimeKind.Local).AddTicks(5952) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 16, 23, 23, 130, DateTimeKind.Local).AddTicks(5954), new DateTime(2023, 8, 10, 16, 23, 23, 130, DateTimeKind.Local).AddTicks(5956) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 16, 23, 23, 130, DateTimeKind.Local).AddTicks(5958), new DateTime(2023, 8, 10, 16, 23, 23, 130, DateTimeKind.Local).AddTicks(5959) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 16, 23, 23, 130, DateTimeKind.Local).AddTicks(5961), new DateTime(2023, 8, 10, 16, 23, 23, 130, DateTimeKind.Local).AddTicks(5962) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 16, 23, 23, 130, DateTimeKind.Local).AddTicks(5964), new DateTime(2023, 8, 10, 16, 23, 23, 130, DateTimeKind.Local).AddTicks(5966) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 16, 23, 23, 130, DateTimeKind.Local).AddTicks(5968), new DateTime(2023, 8, 10, 16, 23, 23, 130, DateTimeKind.Local).AddTicks(5969) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 16, 23, 23, 130, DateTimeKind.Local).AddTicks(5971), new DateTime(2023, 8, 10, 16, 23, 23, 130, DateTimeKind.Local).AddTicks(5973) });
        }
    }
}
