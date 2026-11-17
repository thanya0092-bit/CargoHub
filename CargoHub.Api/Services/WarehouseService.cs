using CargoHub.Api.Dtos;
using CargoHub.Api.Models;
using CargoHub.Api.Repositories;

namespace CargoHub.Api.Services;

public class WarehouseService : IWarehouseService
{
    private readonly IRepository<Warehouse> _warehouses;

    public WarehouseService(IRepository<Warehouse> warehouses)
    {
        _warehouses = warehouses;
    }

    public async Task<List<WarehouseDto>> GetAllAsync()
    {
        var warehouses = await _warehouses.GetAllAsync();
        return warehouses.Select(ToDto).ToList();
    }

    public async Task<WarehouseDto?> GetByIdAsync(int id)
    {
        var warehouse = await _warehouses.GetByIdAsync(id);
        return warehouse is null ? null : ToDto(warehouse);
    }

    private static WarehouseDto ToDto(Warehouse warehouse) => new()
    {
        Id = warehouse.Id,
        Code = warehouse.Code,
        Name = warehouse.Name,
        City = warehouse.City
    };
}