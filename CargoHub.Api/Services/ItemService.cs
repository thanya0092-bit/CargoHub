
using CargoHub.Api.Dtos;
using CargoHub.Api.Models;
using CargoHub.Api.Repositories;

namespace CargoHub.Api.Services;

public class ItemService : IItemService
{
    private readonly IRepository<Item> _items;

    public ItemService(IRepository<Item> items)
    {
        _items = items;
    }

    public async Task<List<ItemDto>> GetAllAsync()
    {
        var items = await _items.GetAllAsync();
        return items.Select(ToDto).ToList();
    }

    public async Task<ItemDto?> GetByIdAsync(int id)
    {
        var item = await _items.GetByIdAsync(id);
        return item is null ? null : ToDto(item);
    }

    private static ItemDto ToDto(Item item) => new()
    {
        Id = item.Id,
        Code = item.Code,
        Description = item.Description,
        Barcode = item.Barcode,
        ModelNumber = item.ModelNumber,
        CommodityCode = item.CommodityCode,
        UnitWeight = item.UnitWeight,
        ItemLineId = item.ItemLineId,
        ItemGroupId = item.ItemGroupId,
        ItemTypeId = item.ItemTypeId,
        MinPurchaseQty = item.MinPurchaseQty,
        CaseSize = item.CaseSize,
        PackagingType = item.PackagingType,
        OrderMultiple = item.OrderMultiple,
        SupplierId = item.SupplierId,
        SupplierSku = item.SupplierSku,
        CreatedAt = item.CreatedAt,
        UpdatedAt = item.UpdatedAt
    };
}