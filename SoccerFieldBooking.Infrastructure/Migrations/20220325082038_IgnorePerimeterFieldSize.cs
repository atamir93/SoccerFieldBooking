using Microsoft.EntityFrameworkCore.Migrations;

namespace SoccerFieldBooking.Infrastructure.Migrations
{
    public partial class IgnorePerimeterFieldSize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Size_Perimeter",
                table: "Fields");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Size_Perimeter",
                table: "Fields",
                type: "decimal(18,2)",
                nullable: true);
        }
    }
}
