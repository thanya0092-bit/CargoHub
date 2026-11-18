using CargoHub.Api.Models;
using Microsoft.EntityFrameworkCore;
namespace CargoHub.Api.Data;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Warehouse> Warehouses => Set<Warehouse>();
    public DbSet<Inventory> Inventories => Set<Inventory>();
    public DbSet<Shipment> Shipments => Set<Shipment>();
    public DbSet<Location> Locations => Set<Location>();
}
