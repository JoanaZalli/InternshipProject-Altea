using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CompanyProfileMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f1125c1c-139f-49ba-bd17-b7f730a71927");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f3bd527a-82e9-473a-bced-07a14a269d2c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcaaceec-bfbb-4948-af94-370e4103028c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9efda0c-9b13-4efd-bc1f-d8840cd80370");

            migrationBuilder.CreateTable(
                name: "CompanyProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sector = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubSector = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationalIndustry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyProfiles", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyProfiles");

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

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8208), new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8210) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8212), new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8213) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8215), new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8217) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8219), new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8220) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8222), new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8224) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8225), new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8227) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8229), new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8230) });

            migrationBuilder.UpdateData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8232), new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8234) });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "f1125c1c-139f-49ba-bd17-b7f730a71927", null, "Admin", "ADMIN" },
                    { "f3bd527a-82e9-473a-bced-07a14a269d2c", null, "Borrower", "BORROWER" },
                    { "fcaaceec-bfbb-4948-af94-370e4103028c", null, "Loan Officer", "LOAN OFFICER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccesToken", "AccesTokenExpiryTime", "AccessFailedCount", "BlockEnd", "ConcurrencyStamp", "Email", "EmailConfirmed", "FailedLoginAttempts", "FirstName", "IsBlocked", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordRecoveyToken", "PasswordRecoveyTokenCreationTime", "PhoneNumber", "PhoneNumberConfirmed", "PrefixId", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "Token", "TokenCreationTime", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e9efda0c-9b13-4efd-bc1f-d8840cd80370", null, null, 0, null, "cdf33343-c78c-47b5-bb31-864aafeedf7f", "admin@gmail.com", true, 0, "admin", false, "admin", false, null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, null, null, "f19aa472-90c0-43ac-ae59-955ff76cd1a4", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "admin1" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8089));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8250), new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8252) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8254), new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8256) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8258), new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8259) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8261), new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8263) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8265), new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8266) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8268), new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8270) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8271), new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8273) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8275), new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8276) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8278), new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8280) });

            migrationBuilder.UpdateData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8282), new DateTime(2023, 8, 10, 14, 26, 3, 186, DateTimeKind.Local).AddTicks(8283) });
        }
    }
}
