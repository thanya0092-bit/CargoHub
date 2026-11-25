using CargoHub.Api.Dtos;
using CargoHub.Api.Models;
using CargoHub.Api.Repositories;

namespace CargoHub.Api.Services;

public class OrdersService : IOrdersService
{
    private readonly IRepository<Order> _orders;

    public OrdersService(IRepository<Order> orders)
    {
        _orders = orders;
    }

    public async Task<List<OrdersDto>> GetAllAsync()
    {
        var orders = await _orders.GetAllAsync();
        return orders.Select(ToDto).ToList();
    }

    public async Task<OrdersDto?> GetByIdAsync(int id)
    {
        var order = await _orders.GetByIdAsync(id);
        return order is null ? null : ToDto(order);
    }

    public async Task<OrdersDto> CreateAsync(CreateOrdersDto dto)
    {
        var now = DateTime.UtcNow;
        var order = new Order
        {
            ClientId = dto.ClientId,
            OrderDate = now,
            RequestDate = dto.RequestDate,
            Reference = string.Empty,
            CustomerPoNumber = dto.CustomerPoNumber,
            OrderStatus = "Pending",
            ShippingNotes = dto.ShippingNotes,
            WarehouseId = dto.WarehouseId,
            ShipToClientId = dto.ShipToClientId,
            BillToClientId = dto.BillToClientId,
            CreatedAt = now,
            UpdatedAt = now
        };

        _orders.Add(order);
        await _orders.SaveChangesAsync();

        // id word pas na het opslaan aangemaakt daarna word kan reference pas worden aangemaakt
        order.Reference = $"ORD-{order.Id:D6}";
        await _orders.SaveChangesAsync();

        return ToDto(order);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var order = await _orders.GetByIdAsync(id);
        if (order is null) return false;

        _orders.Delete(order);
        await _orders.SaveChangesAsync();

        return true;
    }

    private static OrdersDto ToDto(Order order) => new()
    {
        Id = order.Id,
        ClientId = order.ClientId,
        OrderDate = order.OrderDate,
        RequestDate = order.RequestDate,
        Reference = order.Reference,
        CustomerPoNumber = order.CustomerPoNumber,
        OrderStatus = order.OrderStatus,
        ShippingNotes = order.ShippingNotes,
        WarehouseId = order.WarehouseId,
        ShipToClientId = order.ShipToClientId,
        BillToClientId = order.BillToClientId,
        CreatedAt = order.CreatedAt,
        UpdatedAt = order.UpdatedAt
    };
}