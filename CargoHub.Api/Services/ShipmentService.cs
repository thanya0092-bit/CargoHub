using CargoHub.Api.Dtos;
using CargoHub.Api.Models;
using CargoHub.Api.Repositories;

namespace CargoHub.Api.Services;

public class ShipmentService : IShipmentService
{
    private readonly IRepository<Shipment> _shipments;

    public ShipmentService(IRepository<Shipment> shipments)
    {
        _shipments = shipments;
    }

    public async Task<List<ShipmentDto>> GetAllAsync()
    {
        var shipments = await _shipments.GetAllAsync();
        return shipments.Select(ToDto).ToList();
    }

    public async Task<ShipmentDto?> GetByIdAsync(int id)
    {
        var shipment = await _shipments.GetByIdAsync(id);
        return shipment is null ? null : ToDto(shipment);
    }

    public async Task<ShipmentDto> CreateAsync(CreateShipmentDto shipmentDto)
    {
        var now = DateTime.UtcNow;
        var shipment = new Shipment
        {
            Order_Id = shipmentDto.Order_Id,
            Shipment_Date = shipmentDto.Shipment_Date,
            Shipment_Type = shipmentDto.Shipment_Type,
            Carrier_Name = shipmentDto.Carrier_Name,
            Shipping_Method = shipmentDto.Shipping_Method,
            Payment_Type = shipmentDto.Payment_Type,
            Created_At = now,
            Updated_At = now
        };

        _shipments.Add(shipment);
        await _shipments.SaveChangesAsync();

        return ToDto(shipment);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var shipment = await _shipments.GetByIdAsync(id);
        if (shipment is null) return false;

        _shipments.Delete(shipment);
        await _shipments.SaveChangesAsync();

        return true;
    }

    private static ShipmentDto ToDto(Shipment shipment) => new()
    {
        Id = shipment.Id,
        Reference = shipment.Reference,
        Order_Id = shipment.Order_Id,
        Shipment_Date = shipment.Shipment_Date,
        Shipment_Type = shipment.Shipment_Type,
        Shipment_Status = shipment.Shipment_Status,
        Carrier_Name = shipment.Carrier_Name,
        Shipping_Method = shipment.Shipping_Method,
        Payment_Type = shipment.Payment_Type,
        Created_At = shipment.Created_At,
        Updated_At = shipment.Updated_At
    };
}
