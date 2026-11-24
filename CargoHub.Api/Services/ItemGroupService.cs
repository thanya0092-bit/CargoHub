using CargoHub.Api.Dtos;
using CargoHub.Api.Models;
using CargoHub.Api.Repositories;

namespace CargoHub.Api.Services;

public class ItemGroupService : IItemGroupService
{
    private readonly IRepository<ItemGroup> _itemGroups;

    public ItemGroupService(IRepository<ItemGroup> itemGroups)
    {
        _itemGroups = itemGroups;
    }

    public async Task<List<ItemGroupDto>> GetAllAsync()
    {
        var itemGroups = await _itemGroups.GetAllAsync();
        return itemGroups.Select(ToDto).ToList();
    }

    public async Task<ItemGroupDto?> GetByIdAsync(int id)
    {
        var itemGroup = await _itemGroups.GetByIdAsync(id);
        return itemGroup is null ? null : ToDto(itemGroup);
    }

    private static ItemGroupDto ToDto(ItemGroup itemGroup) => new()
    {
        Id = itemGroup.Id,
        Name = itemGroup.Name,
        Description = itemGroup.Description,
        CreatedAt = itemGroup.CreatedAt,
        UpdatedAt = itemGroup.UpdatedAt
    };
}