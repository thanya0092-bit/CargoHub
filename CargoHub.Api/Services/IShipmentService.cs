using CargoHub.Api.Dtos;

namespace CargoHub.Api.Services;

public interface IShipmentService
{
    Task<List<ShipmentDto>> GetAllAsync();
    Task<ShipmentDto?> GetByIdAsync(int id);
    Task<ShipmentDto> CreateAsync(CreateShipmentDto shipmentDto);
    Task<bool> DeleteAsync(int id);
}
