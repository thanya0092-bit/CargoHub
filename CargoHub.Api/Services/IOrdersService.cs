using CargoHub.Api.Dtos;

namespace CargoHub.Api.Services;

public interface IOrdersService
{
    Task<List<OrdersDto>> GetAllAsync();
    Task<OrdersDto?> GetByIdAsync(int id);
    Task<OrdersDto> CreateAsync(CreateOrdersDto dto);
    Task<bool> DeleteAsync(int id);
}