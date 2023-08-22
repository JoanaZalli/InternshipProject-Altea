using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Finhub : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.RenameColumn(
                name: "State",
                table: "CompanyProfiles",
                newName: "state");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "CompanyProfiles",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "CompanyProfiles",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "CompanyProfiles",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Currency",
                table: "CompanyProfiles",
                newName: "currency");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "CompanyProfiles",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "CompanyProfiles",
                newName: "weburl");

            migrationBuilder.RenameColumn(
                name: "Symbol",
                table: "CompanyProfiles",
                newName: "ticker");

            migrationBuilder.RenameColumn(
                name: "SubSector",
                table: "CompanyProfiles",
                newName: "naicsSubsector");

            migrationBuilder.RenameColumn(
                name: "Sector",
                table: "CompanyProfiles",
                newName: "naicsSector");

            migrationBuilder.RenameColumn(
                name: "NationalIndustry",
                table: "CompanyProfiles",
                newName: "naicsNationalIndustry");

               }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
          

            migrationBuilder.RenameColumn(
                name: "state",
                table: "CompanyProfiles",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "phone",
                table: "CompanyProfiles",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "CompanyProfiles",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "CompanyProfiles",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "currency",
                table: "CompanyProfiles",
                newName: "Currency");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "CompanyProfiles",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "weburl",
                table: "CompanyProfiles",
                newName: "Url");

            migrationBuilder.RenameColumn(
                name: "ticker",
                table: "CompanyProfiles",
                newName: "Symbol");

            migrationBuilder.RenameColumn(
                name: "naicsSubsector",
                table: "CompanyProfiles",
                newName: "SubSector");

            migrationBuilder.RenameColumn(
                name: "naicsSector",
                table: "CompanyProfiles",
                newName: "Sector");

            migrationBuilder.RenameColumn(
                name: "naicsNationalIndustry",
                table: "CompanyProfiles",
                newName: "NationalIndustry");

              }
    }
}
