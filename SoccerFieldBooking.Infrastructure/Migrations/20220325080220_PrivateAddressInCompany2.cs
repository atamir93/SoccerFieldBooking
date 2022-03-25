using Microsoft.EntityFrameworkCore.Migrations;

namespace SoccerFieldBooking.Infrastructure.Migrations
{
    public partial class PrivateAddressInCompany2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address_City",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address_Country",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address_PostalCode",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address_State",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address_Street",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address_City",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Address_Country",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Address_PostalCode",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Address_State",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Address_Street",
                table: "Companies");
        }
    }
}
