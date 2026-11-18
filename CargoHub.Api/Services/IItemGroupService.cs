using CargoHub.Api.Dtos;

namespace CargoHub.Api.Services;

public interface IItemGroupService
{
    Task<List<ItemGroupDto>> GetAllAsync();
    Task<ItemGroupDto?> GetByIdAsync(int id);
}