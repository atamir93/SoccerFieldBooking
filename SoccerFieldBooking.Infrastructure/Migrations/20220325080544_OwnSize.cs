using Microsoft.EntityFrameworkCore.Migrations;

namespace SoccerFieldBooking.Infrastructure.Migrations
{
    public partial class OwnSize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Size_Length",
                table: "Fields",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Size_Perimeter",
                table: "Fields",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Size_Width",
                table: "Fields",
                type: "decimal(18,2)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Size_Length",
                table: "Fields");

            migrationBuilder.DropColumn(
                name: "Size_Perimeter",
                table: "Fields");

            migrationBuilder.DropColumn(
                name: "Size_Width",
                table: "Fields");
        }
    }
}
