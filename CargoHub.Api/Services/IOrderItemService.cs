using CargoHub.Api.Dtos;

namespace CargoHub.Api.Services;

public interface IOrderItemService
{
    Task<List<OrderItemDto>> GetAllAsync();
    Task<OrderItemDto?> GetByIdAsync(int id);
    Task<OrderItemDto> CreateAsync(CreateOrderItemDto dto);
    Task<bool> DeleteAsync(int id);
}