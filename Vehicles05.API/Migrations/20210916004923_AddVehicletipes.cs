using Microsoft.EntityFrameworkCore.Migrations;

namespace Vehicles05.API.Migrations
{
    public partial class AddVehicletipes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Desription",
                table: "VehicleTypes",
                newName: "Description");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleTypes_Desription",
                table: "VehicleTypes",
                newName: "IX_VehicleTypes_Description");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "VehicleTypes",
                newName: "Desription");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleTypes_Description",
                table: "VehicleTypes",
                newName: "IX_VehicleTypes_Desription");
        }
    }
}
