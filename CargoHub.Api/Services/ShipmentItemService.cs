using CargoHub.Api.Dtos;
using CargoHub.Api.Models;
using CargoHub.Api.Repositories;

namespace CargoHub.Api.Services;

public class ShipmentItemService : IShipmentItemService
{
    private readonly IRepository<ShipmentItem> _shipmentItems;

    public ShipmentItemService(IRepository<ShipmentItem> shipmentItems)
    {
        _shipmentItems = shipmentItems;
    }

    public async Task<List<ShipmentItemDto>> GetAllAsync()
    {
        var shipmentItems = await _shipmentItems.GetAllAsync();
        return shipmentItems.Select(ToDto).ToList();
    }

    public async Task<ShipmentItemDto?> GetByIdAsync(int id)
    {
        var shipmentItem = await _shipmentItems.GetByIdAsync(id);
        return shipmentItem is null ? null : ToDto(shipmentItem);
    }

    public async Task<ShipmentItemDto> CreateAsync(CreateShipmentItemDto dto)
    {
        var shipmentItem = new ShipmentItem
        {
            Shipment_Id = dto.Shipment_Id,
            Item_Id = dto.Item_Id,
            Amount = dto.Amount
        };

        _shipmentItems.Add(shipmentItem);
        await _shipmentItems.SaveChangesAsync();

        return ToDto(shipmentItem);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var shipmentItem = await _shipmentItems.GetByIdAsync(id);
        if (shipmentItem is null) return false;

        _shipmentItems.Delete(shipmentItem);
        await _shipmentItems.SaveChangesAsync();

        return true;
    }

    private static ShipmentItemDto ToDto(ShipmentItem shipmentItem) => new()
    {
        Id = shipmentItem.Id,
        Shipment_Id = shipmentItem.Shipment_Id,
        Item_Id = shipmentItem.Item_Id,
        Amount = shipmentItem.Amount
    };
}