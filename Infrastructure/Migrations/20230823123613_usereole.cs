using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class usereole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
         table: "AspNetUserRoles",
         columns: new[] { "UserId", "RoleId" },
         values: new object[,]
         {
            { "03DEC9A5-1AC0-4757-8393-BB870D4D53B0", "ACEE1889-E154-4C90-91D4-5F8F396FC5B5" },
            { "392086A6-ABEB-48E1-8666-426BA7B31312", "4377AA5F-C7E7-45B9-A879-8409074EE9AB" }
         });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
        table: "AspNetUserRoles",
        keyColumns: new[] { "UserId", "RoleId" },
        keyValues: new object[] { "03DEC9A5-1AC0-4757-8393-BB870D4D53B0", "ACEE1889-E154-4C90-91D4-5F8F396FC5B5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "392086A6-ABEB-48E1-8666-426BA7B31312", "4377AA5F-C7E7-45B9-A879-8409074EE9AB" });
        }
    }
}
