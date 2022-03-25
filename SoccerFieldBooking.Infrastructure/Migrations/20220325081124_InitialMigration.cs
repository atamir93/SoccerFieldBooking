using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SoccerFieldBooking.Infrastructure.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateTimeRange_End",
                table: "Schedules",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTimeRange_Start",
                table: "Schedules",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTimeRange_End",
                table: "Reservations",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTimeRange_Start",
                table: "Reservations",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateTimeRange_End",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "DateTimeRange_Start",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "DateTimeRange_End",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "DateTimeRange_Start",
                table: "Reservations");
        }
    }
}
