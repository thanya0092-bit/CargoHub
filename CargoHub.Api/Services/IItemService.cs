using CargoHub.Api.Dtos;

namespace CargoHub.Api.Services;

public interface IItemService
{
    Task<List<ItemDto>> GetAllAsync();
    Task<ItemDto?> GetByIdAsync(int id);
}