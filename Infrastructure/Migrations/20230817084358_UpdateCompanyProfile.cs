using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCompanyProfile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.RenameColumn(
                name: "state",
                table: "CompanyProfiles",
                newName: "shareOutstanding");

            migrationBuilder.RenameColumn(
                name: "naicsSubsector",
                table: "CompanyProfiles",
                newName: "logo");

            migrationBuilder.RenameColumn(
                name: "naicsSector",
                table: "CompanyProfiles",
                newName: "ipo");

            migrationBuilder.RenameColumn(
                name: "naicsNationalIndustry",
                table: "CompanyProfiles",
                newName: "finnhubIndustry");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "CompanyProfiles",
                newName: "exchange");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "CompanyProfiles",
                newName: "country");

            migrationBuilder.AddColumn<double>(
                name: "marketCapitalization",
                table: "CompanyProfiles",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.DropColumn(
                name: "marketCapitalization",
                table: "CompanyProfiles");

            migrationBuilder.RenameColumn(
                name: "shareOutstanding",
                table: "CompanyProfiles",
                newName: "state");

            migrationBuilder.RenameColumn(
                name: "logo",
                table: "CompanyProfiles",
                newName: "naicsSubsector");

            migrationBuilder.RenameColumn(
                name: "ipo",
                table: "CompanyProfiles",
                newName: "naicsSector");

            migrationBuilder.RenameColumn(
                name: "finnhubIndustry",
                table: "CompanyProfiles",
                newName: "naicsNationalIndustry");

            migrationBuilder.RenameColumn(
                name: "exchange",
                table: "CompanyProfiles",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "country",
                table: "CompanyProfiles",
                newName: "address");

            }
    }
}
