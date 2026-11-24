using CargoHub.Api.Dtos;
using CargoHub.Api.Models;
using CargoHub.Api.Repositories;

namespace CargoHub.Api.Services;

public class OrderItemService : IOrderItemService
{
    private readonly IRepository<OrderItem> _orderItems;

    public OrderItemService(IRepository<OrderItem> orderItems)
    {
        _orderItems = orderItems;
    }

    public async Task<List<OrderItemDto>> GetAllAsync()
    {
        var orderItems = await _orderItems.GetAllAsync();
        return orderItems.Select(ToDto).ToList();
    }

    public async Task<OrderItemDto?> GetByIdAsync(int id)
    {
        var orderItem = await _orderItems.GetByIdAsync(id);
        return orderItem is null ? null : ToDto(orderItem);
    }

    public async Task<OrderItemDto> CreateAsync(CreateOrderItemDto dto)
    {
        var orderItem = new OrderItem
        {
            OrderId = dto.OrderId,
            ItemId = dto.ItemId,
            Amount = dto.Amount,
            UnitPrice = dto.UnitPrice
        };

        _orderItems.Add(orderItem);
        await _orderItems.SaveChangesAsync();

        return ToDto(orderItem);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var orderItem = await _orderItems.GetByIdAsync(id);
        if (orderItem is null) return false;

        _orderItems.Delete(orderItem);
        await _orderItems.SaveChangesAsync();

        return true;
    }

    private static OrderItemDto ToDto(OrderItem orderItem) => new()
    {
        Id = orderItem.Id,
        OrderId = orderItem.OrderId,
        ItemId = orderItem.ItemId,
        Amount = orderItem.Amount,
        UnitPrice = orderItem.UnitPrice
    };
}