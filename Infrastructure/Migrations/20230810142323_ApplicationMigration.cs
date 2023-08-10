using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ApplicationMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Application",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BorrowerId = table.Column<int>(type: "int", nullable: false),
                    RequestedAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RequestedTenor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    ApplicationStatusId = table.Column<int>(type: "int", nullable: false),
                    FinancingPurposeDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExcelFileData = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Application", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Application_ApplicationStatuses_ApplicationStatusId",
                        column: x => x.ApplicationStatusId,
                        principalTable: "ApplicationStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Application_Borrowers_BorrowerId",
                        column: x => x.BorrowerId,
                        principalTable: "Borrowers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Application_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Application_ApplicationStatusId",
                table: "Application",
                column: "ApplicationStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_BorrowerId",
                table: "Application",
                column: "BorrowerId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_ProductId",
                table: "Application",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Application");

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
    }
}
