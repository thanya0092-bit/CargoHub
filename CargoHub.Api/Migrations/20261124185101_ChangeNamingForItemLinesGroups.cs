using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CargoHub.Api.Migrations
{
    /// <inheritdoc />
    public partial class ChangeNamingForItemLinesGroups : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Case_Size",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "Updated_At",
                table: "Items",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "Unit_Weight",
                table: "Items",
                newName: "SupplierId");

            migrationBuilder.RenameColumn(
                name: "Supplier_Sku",
                table: "Items",
                newName: "SupplierSku");

            migrationBuilder.RenameColumn(
                name: "Supplier_Id",
                table: "Items",
                newName: "OrderMultiple");

            migrationBuilder.RenameColumn(
                name: "Packaging_Type",
                table: "Items",
                newName: "PackagingType");

            migrationBuilder.RenameColumn(
                name: "Order_Multiple",
                table: "Items",
                newName: "MinPurchaseQty");

            migrationBuilder.RenameColumn(
                name: "Model_Number",
                table: "Items",
                newName: "ModelNumber");

            migrationBuilder.RenameColumn(
                name: "Min_Purchase_Qty",
                table: "Items",
                newName: "ItemTypeId");

            migrationBuilder.RenameColumn(
                name: "Item_Type_Id",
                table: "Items",
                newName: "ItemLineId");

            migrationBuilder.RenameColumn(
                name: "Item_Line_Id",
                table: "Items",
                newName: "ItemGroupId");

            migrationBuilder.RenameColumn(
                name: "Item_Group_Id",
                table: "Items",
                newName: "CommodityCode");

            migrationBuilder.RenameColumn(
                name: "Created_At",
                table: "Items",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "Commodity_Code",
                table: "Items",
                newName: "CaseSize");

            migrationBuilder.RenameColumn(
                name: "Updated_At",
                table: "ItemLines",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "Created_At",
                table: "ItemLines",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "Updated_At",
                table: "ItemGroups",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "Created_At",
                table: "ItemGroups",
                newName: "CreatedAt");

            migrationBuilder.AddColumn<double>(
                name: "UnitWeight",
                table: "Items",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UnitWeight",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Items",
                newName: "Updated_At");

            migrationBuilder.RenameColumn(
                name: "SupplierSku",
                table: "Items",
                newName: "Supplier_Sku");

            migrationBuilder.RenameColumn(
                name: "SupplierId",
                table: "Items",
                newName: "Unit_Weight");

            migrationBuilder.RenameColumn(
                name: "PackagingType",
                table: "Items",
                newName: "Packaging_Type");

            migrationBuilder.RenameColumn(
                name: "OrderMultiple",
                table: "Items",
                newName: "Supplier_Id");

            migrationBuilder.RenameColumn(
                name: "ModelNumber",
                table: "Items",
                newName: "Model_Number");

            migrationBuilder.RenameColumn(
                name: "MinPurchaseQty",
                table: "Items",
                newName: "Order_Multiple");

            migrationBuilder.RenameColumn(
                name: "ItemTypeId",
                table: "Items",
                newName: "Min_Purchase_Qty");

            migrationBuilder.RenameColumn(
                name: "ItemLineId",
                table: "Items",
                newName: "Item_Type_Id");

            migrationBuilder.RenameColumn(
                name: "ItemGroupId",
                table: "Items",
                newName: "Item_Line_Id");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Items",
                newName: "Created_At");

            migrationBuilder.RenameColumn(
                name: "CommodityCode",
                table: "Items",
                newName: "Item_Group_Id");

            migrationBuilder.RenameColumn(
                name: "CaseSize",
                table: "Items",
                newName: "Commodity_Code");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "ItemLines",
                newName: "Updated_At");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "ItemLines",
                newName: "Created_At");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "ItemGroups",
                newName: "Updated_At");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "ItemGroups",
                newName: "Created_At");

            migrationBuilder.AddColumn<int>(
                name: "Case_Size",
                table: "Items",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
