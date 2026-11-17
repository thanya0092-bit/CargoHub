using CargoHub.Api.Models;
using Microsoft.EntityFrameworkCore;
namespace CargoHub.Api.Data;


public static class SeedData
{
    public static async Task InitializeAsync(WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

        // 1. Warehouses
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

        // 2. Inventory
        if (!await context.Inventory.AnyAsync())
        {
            context.Inventory.AddRange(
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
    }
}
