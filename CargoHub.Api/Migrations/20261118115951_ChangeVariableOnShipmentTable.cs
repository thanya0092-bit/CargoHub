using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CargoHub.Api.Migrations
{
    /// <inheritdoc />
    public partial class ChangeVariableOnShipmentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "carrier_Name",
                table: "Shipments",
                newName: "Carrier_Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Carrier_Name",
                table: "Shipments",
                newName: "carrier_Name");
        }
    }
}
