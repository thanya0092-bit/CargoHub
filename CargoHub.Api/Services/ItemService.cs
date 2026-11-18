
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
        Model_Number = item.Model_Number,
        Commodity_Code = item.Commodity_Code,
        Unit_Weight = item.Unit_Weight,
        Item_Line_Id = item.Item_Line_Id,
        Item_Group_Id = item.Item_Group_Id,
        Item_Type_Id = item.Item_Type_Id,
        Min_Purchase_Qty = item.Min_Purchase_Qty,
        Case_Size = item.Case_Size,
        Packaging_Type = item.Packaging_Type,
        Order_Multiple = item.Order_Multiple,
        Supplier_Id = item.Supplier_Id,
        Supplier_Sku = item.Supplier_Sku,
        Created_At = item.Created_At,
        Updated_At = item.Updated_At
    };
}