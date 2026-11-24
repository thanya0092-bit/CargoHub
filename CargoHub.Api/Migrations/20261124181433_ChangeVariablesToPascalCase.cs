using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CargoHub.Api.Migrations
{
    /// <inheritdoc />
    public partial class ChangeVariablesToPascalCase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Zip_Code",
                table: "Suppliers",
                newName: "ZipCode");

            migrationBuilder.RenameColumn(
                name: "Updated_At",
                table: "Suppliers",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "Phone_Number",
                table: "Suppliers",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "Created_At",
                table: "Suppliers",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "Contact_Name",
                table: "Suppliers",
                newName: "ContactName");

            migrationBuilder.RenameColumn(
                name: "Warehouse_Id",
                table: "Orders",
                newName: "WarehouseId");

            migrationBuilder.RenameColumn(
                name: "Updated_At",
                table: "Orders",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "Shipping_Notes",
                table: "Orders",
                newName: "ShippingNotes");

            migrationBuilder.RenameColumn(
                name: "Ship_To_Client_Id",
                table: "Orders",
                newName: "ShipToClientId");

            migrationBuilder.RenameColumn(
                name: "Request_Date",
                table: "Orders",
                newName: "RequestDate");

            migrationBuilder.RenameColumn(
                name: "Order_Status",
                table: "Orders",
                newName: "OrderStatus");

            migrationBuilder.RenameColumn(
                name: "Order_Date",
                table: "Orders",
                newName: "OrderDate");

            migrationBuilder.RenameColumn(
                name: "Customer_Po_Number",
                table: "Orders",
                newName: "CustomerPoNumber");

            migrationBuilder.RenameColumn(
                name: "Created_At",
                table: "Orders",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "Client_Id",
                table: "Orders",
                newName: "ClientId");

            migrationBuilder.RenameColumn(
                name: "Bill_To_Client_Id",
                table: "Orders",
                newName: "BillToClientId");

            migrationBuilder.RenameColumn(
                name: "Unit_Price",
                table: "OrderItems",
                newName: "UnitPrice");

            migrationBuilder.RenameColumn(
                name: "Order_Id",
                table: "OrderItems",
                newName: "OrderId");

            migrationBuilder.RenameColumn(
                name: "Item_Id",
                table: "OrderItems",
                newName: "ItemId");

            migrationBuilder.RenameColumn(
                name: "Zip_Code",
                table: "Clients",
                newName: "ZipCode");

            migrationBuilder.RenameColumn(
                name: "Updated_At",
                table: "Clients",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "Created_At",
                table: "Clients",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "Contact_Phone",
                table: "Clients",
                newName: "ContactPhone");

            migrationBuilder.RenameColumn(
                name: "Contact_Name",
                table: "Clients",
                newName: "ContactName");

            migrationBuilder.RenameColumn(
                name: "Contact_Email",
                table: "Clients",
                newName: "ContactEmail");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ZipCode",
                table: "Suppliers",
                newName: "Zip_Code");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Suppliers",
                newName: "Updated_At");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Suppliers",
                newName: "Phone_Number");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Suppliers",
                newName: "Created_At");

            migrationBuilder.RenameColumn(
                name: "ContactName",
                table: "Suppliers",
                newName: "Contact_Name");

            migrationBuilder.RenameColumn(
                name: "WarehouseId",
                table: "Orders",
                newName: "Warehouse_Id");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Orders",
                newName: "Updated_At");

            migrationBuilder.RenameColumn(
                name: "ShippingNotes",
                table: "Orders",
                newName: "Shipping_Notes");

            migrationBuilder.RenameColumn(
                name: "ShipToClientId",
                table: "Orders",
                newName: "Ship_To_Client_Id");

            migrationBuilder.RenameColumn(
                name: "RequestDate",
                table: "Orders",
                newName: "Request_Date");

            migrationBuilder.RenameColumn(
                name: "OrderStatus",
                table: "Orders",
                newName: "Order_Status");

            migrationBuilder.RenameColumn(
                name: "OrderDate",
                table: "Orders",
                newName: "Order_Date");

            migrationBuilder.RenameColumn(
                name: "CustomerPoNumber",
                table: "Orders",
                newName: "Customer_Po_Number");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Orders",
                newName: "Created_At");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Orders",
                newName: "Client_Id");

            migrationBuilder.RenameColumn(
                name: "BillToClientId",
                table: "Orders",
                newName: "Bill_To_Client_Id");

            migrationBuilder.RenameColumn(
                name: "UnitPrice",
                table: "OrderItems",
                newName: "Unit_Price");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "OrderItems",
                newName: "Order_Id");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "OrderItems",
                newName: "Item_Id");

            migrationBuilder.RenameColumn(
                name: "ZipCode",
                table: "Clients",
                newName: "Zip_Code");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Clients",
                newName: "Updated_At");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Clients",
                newName: "Created_At");

            migrationBuilder.RenameColumn(
                name: "ContactPhone",
                table: "Clients",
                newName: "Contact_Phone");

            migrationBuilder.RenameColumn(
                name: "ContactName",
                table: "Clients",
                newName: "Contact_Name");

            migrationBuilder.RenameColumn(
                name: "ContactEmail",
                table: "Clients",
                newName: "Contact_Email");
        }
    }
}
