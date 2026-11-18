using CargoHub.Api.Dtos;
using CargoHub.Api.Models;
using CargoHub.Api.Repositories;

namespace CargoHub.Api.Services;

public class InventoryService : IInventoryService
{
    private readonly IRepository<Inventory> _inventories;

    public InventoryService(IRepository<Inventory> inventories)
    {
        _inventories = inventories;
    }

    public async Task<List<InventoryDto>> GetAllAsync()
    {
        var inventories = await _inventories.GetAllAsync();
        return inventories.Select(ToDto).ToList();
    }

    public async Task<InventoryDto?> GetByIdAsync(int id)
    {
        var inventory = await _inventories.GetByIdAsync(id);
        return inventory is null ? null : ToDto(inventory);
    }

    public async Task<InventoryDto> CreateAsync(CreateInventoryDto dto)
    {
        var now = DateTime.UtcNow;
        var inventory = new Inventory
        {
            Item_Id = dto.Item_Id,
            Location_Id = dto.Location_Id,
            Quantity_On_Hand = dto.Quantity_On_Hand,
            Quantity_Expected = dto.Quantity_Expected,
            Updated_At = now
        };

        _inventories.Add(inventory);
        await _inventories.SaveChangesAsync();

        return ToDto(inventory);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var inventory = await _inventories.GetByIdAsync(id);
        if (inventory is null) return false;

        _inventories.Delete(inventory);
        await _inventories.SaveChangesAsync();

        return true;
    }

    private static InventoryDto ToDto(Inventory inventory) => new()
    {
        Id = inventory.Id,
        Item_Id = inventory.Item_Id,
        Quantity_On_Hand = inventory.Quantity_On_Hand,
        Quantity_Expected = inventory.Quantity_Expected,
        Quantity_Ordered = inventory.Quantity_Ordered,
        Quantity_Allocate = inventory.Quantity_Allocate,
        Created_At = inventory.Created_At,
        Updated_At = inventory.Updated_At
    };
}
