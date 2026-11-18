using CargoHub.Api.Dtos;

namespace CargoHub.Api.Services;

public interface IInventoryService
{
    Task<List<InventoryDto>> GetAllAsync();
    Task<InventoryDto?> GetByIdAsync(int id);
    Task<InventoryDto> CreateAsync(CreateInventoryDto dto);
    Task<bool> DeleteAsync(int id);
}
