using CargoHub.Api.Dtos;

namespace CargoHub.Api.Services;

public interface IItemLineService
{
    Task<List<ItemLineDto>> GetAllAsync();
    Task<ItemLineDto?> GetByIdAsync(int id);
}