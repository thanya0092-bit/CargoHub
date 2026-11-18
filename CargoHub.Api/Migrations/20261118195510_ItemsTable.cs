using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CargoHub.Api.Migrations
{
    /// <inheritdoc />
    public partial class ItemsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Barcode = table.Column<string>(type: "text", nullable: false),
                    Model_Number = table.Column<string>(type: "text", nullable: false),
                    Commodity_Code = table.Column<int>(type: "integer", nullable: false),
                    Unit_Weight = table.Column<int>(type: "integer", nullable: false),
                    Item_Line_Id = table.Column<int>(type: "integer", nullable: false),
                    Item_Group_Id = table.Column<int>(type: "integer", nullable: false),
                    Item_Type_Id = table.Column<int>(type: "integer", nullable: false),
                    Min_Purchase_Qty = table.Column<int>(type: "integer", nullable: false),
                    Case_Size = table.Column<int>(type: "integer", nullable: false),
                    Packaging_Type = table.Column<string>(type: "text", nullable: false),
                    Order_Multiple = table.Column<int>(type: "integer", nullable: false),
                    Supplier_Id = table.Column<int>(type: "integer", nullable: false),
                    Supplier_Sku = table.Column<string>(type: "text", nullable: false),
                    Created_At = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Updated_At = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
