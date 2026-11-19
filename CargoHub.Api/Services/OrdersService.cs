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
            Client_Id = dto.Client_Id,
            Order_Date = now,
            Request_Date = dto.Request_Date,
            Reference = $"ORD-000001",
            Customer_Po_Number = dto.Customer_Po_Number,
            Order_Status = "Pending",
            Shipping_Notes = dto.Shipping_Notes,
            Warehouse_Id = dto.Warehouse_Id,
            Ship_To_Client_Id = dto.Ship_To_Client_Id,
            Bill_To_Client_Id = dto.Bill_To_Client_Id,
            Created_At = now,
            Updated_At = now
        };

        _orders.Add(order);
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
        Client_Id = order.Client_Id,
        Order_Date = order.Order_Date,
        Request_Date = order.Request_Date,
        Reference = order.Reference,
        Customer_Po_Number = order.Customer_Po_Number,
        Order_Status = order.Order_Status,
        Shipping_Notes = order.Shipping_Notes,
        Warehouse_Id = order.Warehouse_Id,
        Ship_To_Client_Id = order.Ship_To_Client_Id,
        Bill_To_Client_Id = order.Bill_To_Client_Id,
        Created_At = order.Created_At,
        Updated_At = order.Updated_At
    };
}