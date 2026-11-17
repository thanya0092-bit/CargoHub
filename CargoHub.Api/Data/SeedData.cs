using CargoHub.Api.Models;
using Microsoft.EntityFrameworkCore;
namespace CargoHub.Api.Data;


public static class SeedData
{
    public static async Task InitializeAsync(WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

        if (await context.Warehouses.AnyAsync())
        {
            return;
        }

        context.Warehouses.AddRange(
            new Warehouse
            {
                Id = 1,
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
}