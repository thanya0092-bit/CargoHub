using CargoHub.Api.Dtos;
using CargoHub.Api.Models;
using CargoHub.Api.Repositories;

namespace CargoHub.Api.Services;

public class ItemLineService : IItemLineService
{
    private readonly IRepository<ItemLine> _itemLines;

    public ItemLineService(IRepository<ItemLine> itemLines)
    {
        _itemLines = itemLines;
    }

    public async Task<List<ItemLineDto>> GetAllAsync()
    {
        var itemLines = await _itemLines.GetAllAsync();
        return itemLines.Select(ToDto).ToList();
    }

    public async Task<ItemLineDto?> GetByIdAsync(int id)
    {
        var itemLine = await _itemLines.GetByIdAsync(id);
        return itemLine is null ? null : ToDto(itemLine);
    }

    private static ItemLineDto ToDto(ItemLine itemLine) => new()
    {
        Id = itemLine.Id,
        Name = itemLine.Name,
        Description = itemLine.Description,
        CreatedAt = itemLine.CreatedAt,
        UpdatedAt = itemLine.UpdatedAt
    };
}