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