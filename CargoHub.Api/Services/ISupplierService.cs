using CargoHub.Api.Dtos;

namespace CargoHub.Api.Services;

public interface ISupplierService
{
    Task<List<SupplierDto>> GetAllAsync();
    Task<SupplierDto?> GetByIdAsync(int id);
    Task<SupplierDto> CreateAsync(CreateSupplierDto dto);
    Task<bool> DeleteAsync(int id);
}