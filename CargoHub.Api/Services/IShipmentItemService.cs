using CargoHub.Api.Dtos;
using CargoHub.Api.Models;

namespace CargoHub.Api.Services;

public interface IShipmentItemService
{
    Task<List<ShipmentItemDto>> GetAllAsync();
    Task<ShipmentItemDto?> GetByIdAsync(int id);
    Task<ShipmentItemDto> CreateAsync(CreateShipmentItemDto dto);
    Task<bool> DeleteAsync(int id);
}