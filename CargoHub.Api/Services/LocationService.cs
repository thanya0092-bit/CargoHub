using CargoHub.Api.Dtos;
using CargoHub.Api.Models;
using CargoHub.Api.Repositories;

namespace CargoHub.Api.Services;

public class LocationService : ILocationService
{
    private readonly IRepository<Location> _locations;

    public LocationService(IRepository<Location> locations)
    {
        _locations = locations;
    }

    public async Task<List<LocationDto>> GetAllAsync()
    {
        var locations = await _locations.GetAllAsync();
        return locations.Select(ToDto).ToList();
    }

    public async Task<LocationDto?> GetByIdAsync(int id)
    {
        var location = await _locations.GetByIdAsync(id);
        return location is null ? null : ToDto(location);
    }

    public async Task<LocationDto> CreateAsync(CreateLocationDto dto)
    {
        var location = new Location
        {
            Warehouse_Id = dto.Warehouse_Id,
            Code = dto.Code,
            Name = dto.Name
        };

        _locations.Add(location);
        await _locations.SaveChangesAsync();

        return ToDto(location);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var location = await _locations.GetByIdAsync(id);
        if (location is null) return false;

        _locations.Delete(location);
        await _locations.SaveChangesAsync();

        return true;
    }

    private static LocationDto ToDto(Location location) => new()
    {
        Id = location.Id,
        Warehouse_Id = location.Warehouse_Id,
        Code = location.Code,
        Name = location.Name,
        Created_At = location.Created_At,
        Updated_At = location.Updated_At
    };
}
