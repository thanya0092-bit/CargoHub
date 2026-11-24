using CargoHub.Api.Models;
using Microsoft.EntityFrameworkCore;
namespace CargoHub.Api.Data;


public static class SeedData
{
    public static async Task InitializeAsync(WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

        //Warehouses
        if (!await context.Warehouses.AnyAsync())
        {
            context.Warehouses.AddRange(
                new Warehouse
                {
                    Code = "VGH-AMB",
                    Name = "Jumbo DC Veghel Ambient",
                    Address = "De Amert 409",
                    City = "Veghel",
                    Zip_Code = "5462 GH",
                    Province = "Noord-Brabant",
                    Country = "Netherlands",
                    Contact_Name = "Ali Schellekens",
                    Contact_Phone = "(032) 1819600",
                    Contact_Email = "vgh-amb@jumbo-logistiek.nl",
                    Created_At = new DateTime(2024, 6, 21, 22, 43, 23, DateTimeKind.Utc),
                    Updated_At = new DateTime(2024, 6, 23, 4, 51, 45, DateTimeKind.Utc)
                }
            );

            await context.SaveChangesAsync();
        }

        //Inventory
        if (!await context.Inventories.AnyAsync())
        {
            context.Inventories.AddRange(
                new Inventory
                {
                    Item_Id = 10,
                    Location_Id = 9,
                    Quantity_On_Hand = 1000,
                    Quantity_Expected = 100,
                    Quantity_Ordered = 500,
                    Quantity_Allocate = 100,
                    Created_At = DateTime.UtcNow,
                    Updated_At = DateTime.UtcNow
                },
                new Inventory
                {
                    Item_Id = 99,
                    Location_Id = 9,
                    Quantity_On_Hand = 2000,
                    Quantity_Expected = 100,
                    Quantity_Ordered = 500,
                    Quantity_Allocate = 100,
                    Created_At = DateTime.UtcNow,
                    Updated_At = DateTime.UtcNow
                }
            );

            await context.SaveChangesAsync();
        }

        // Shipment
        if (!await context.Shipments.AnyAsync())
        {
            context.Shipments.AddRange(
                new Shipment
                {
                    
                    Reference = "SHP-000001",
                    Order_Id = 1,
                    Shipment_Date = new DateTime(2025, 3, 5, 18, 51, 53, DateTimeKind.Utc),
                    Shipment_Type = "Outgoing",
                    Shipment_Status = "Transit",
                    Carrier_Name = "GLS",
                    Shipping_Method = "Standard",
                    Payment_Type = "Automated",
                    Created_At = new DateTime(2025, 3, 5, 18, 51, 53, DateTimeKind.Utc),
                    Updated_At = new DateTime(2025, 3, 6, 21, 12, 23, DateTimeKind.Utc)
                }
            );
    
            await context.SaveChangesAsync();
        }

        //Location
        if (!await context.Locations.AnyAsync())
        {
            context.Locations.AddRange(
                new Location
                {
                    Warehouse_Id = 1,
                    Code = "VGH-AMB-B12-R6-B7",
                    Name = "Zone B Aisle 12 Rack 6 Bin 7",
                    Created_At =  new DateTime(2024, 12, 8, 10, 37, 19, DateTimeKind.Utc),
                    Updated_At = new DateTime(2024, 12, 30, 6, 59, 18, DateTimeKind.Utc)
                }
            );
    
            await context.SaveChangesAsync();
        }

        //Shipment_Item
        if (!await context.ShipmentItems.AnyAsync())
        {
            context.ShipmentItems.AddRange(
                new ShipmentItem
                {
                    Shipment_Id = 1,
                    Item_Id = 99,
                    Amount = 100
                }
            );
    
            await context.SaveChangesAsync();
        }

        // Item
        if (!await context.Items.AnyAsync())
        {
            context.Items.AddRange(
                new Item
                {
                    Id = 585,
                    Code = "ITM-000585",
                    Description = "Jumbo Klassiek Gehakt 1500 g",
                    Barcode = "6815724500002",
                    ModelNumber = "OH-14086",
                    CommodityCode = 1406129,
                    UnitWeight = 1.5,
                    ItemLineId = 12,
                    ItemGroupId = 1,
                    ItemTypeId = 1,
                    MinPurchaseQty = 1,
                    CaseSize = 6,
                    PackagingType = "Case",
                    OrderMultiple = 1,
                    SupplierId = 17,
                    SupplierSku = "SKU-2509522",
                    CreatedAt = new DateTime(2024, 4, 20, 23, 17, 54, DateTimeKind.Utc),
                    UpdatedAt = new DateTime(2024, 5, 19, 10, 51, 7, DateTimeKind.Utc)
                }
            );

            await context.SaveChangesAsync();
        }

        // ItemLine
        if (!await context.ItemLines.AnyAsync())
        {
            context.ItemLines.AddRange(
                new ItemLine
                {
                    Id = 1,
                    Name = "Aardappelen, groente en fruit",
                    Description = "Jumbo assortment line: Aardappelen, groente en fruit",
                    CreatedAt = new DateTime(2025, 8, 1, 15, 30, 26, DateTimeKind.Utc),
                    UpdatedAt = new DateTime(2025, 8, 23, 22, 38, 58, DateTimeKind.Utc)
                }
            );

            await context.SaveChangesAsync();
        }

        // ItemGroup
        if (!await context.ItemGroups.AnyAsync())
        {
            context.ItemGroups.AddRange(
                new ItemGroup
                {
                    Id = 1,
                    Name = "Vers",
                    Description = "Temperature/handling regime: Vers",
                    CreatedAt = new DateTime(2025, 8, 1, 15, 30, 26, DateTimeKind.Utc),
                    UpdatedAt = new DateTime(2025, 8, 15, 20, 20, 03, DateTimeKind.Utc)
                }
            );

            await context.SaveChangesAsync();
        }
    }
}
