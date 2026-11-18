using CargoHub.Api.Dtos;

namespace CargoHub.Api.Services;

public interface IWarehouseService
{
    Task<List<WarehouseDto>> GetAllAsync();
    Task<WarehouseDto?> GetByIdAsync(int id);
}
