using CargoHub.Api.Dtos;

namespace CargoHub.Api.Services;

public interface ILocationService
{
    Task<List<LocationDto>> GetAllAsync();
    Task<LocationDto?> GetByIdAsync(int id);
    Task<LocationDto> CreateAsync(CreateLocationDto dto);
    Task<bool> DeleteAsync(int id);
}