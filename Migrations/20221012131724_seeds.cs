using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpiServerAPI.Migrations
{
    public partial class seeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Beacons",
                columns: new[] { "Id", "LocationX", "LocationY", "MapId", "Status", "Uuid" },
                values: new object[] { 1, 200, 300, 3, true, "dadadada" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Beacons",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
