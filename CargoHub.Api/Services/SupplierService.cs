using CargoHub.Api.Dtos;
using CargoHub.Api.Models;
using CargoHub.Api.Repositories;

namespace CargoHub.Api.Services;

public class SupplierService : ISupplierService
{
    private readonly IRepository<Supplier> _suppliers;

    public SupplierService(IRepository<Supplier> suppliers)
    {
        _suppliers = suppliers;
    }

    public async Task<List<SupplierDto>> GetAllAsync()
    {
        var suppliers = await _suppliers.GetAllAsync();
        return suppliers.Select(ToDto).ToList();
    }

    public async Task<SupplierDto?> GetByIdAsync(int id)
    {
        var supplier = await _suppliers.GetByIdAsync(id);
        return supplier is null ? null : ToDto(supplier);
    }

    public async Task<SupplierDto> CreateAsync(CreateSupplierDto dto)
    {
        var now = DateTime.UtcNow;
        var supplier = new Supplier
        {
            Code = string.Empty,
            Name = dto.Name,
            Address = dto.Address,
            City = dto.City,
            ZipCode = dto.ZipCode,
            Province = dto.Province,
            Country = dto.Country,
            ContactName = dto.ContactName,
            PhoneNumber = dto.PhoneNumber,
            Reference = dto.Reference,
            CreatedAt = now,
            UpdatedAt = now
        };

        _suppliers.Add(supplier);
        await _suppliers.SaveChangesAsync();

        supplier.Code = $"SUP-{supplier.Id:D6}";
        await _suppliers.SaveChangesAsync();

        return ToDto(supplier);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var supplier = await _suppliers.GetByIdAsync(id);
        if (supplier is null) return false;

        _suppliers.Delete(supplier);
        await _suppliers.SaveChangesAsync();

        return true;
    }

    private static SupplierDto ToDto(Supplier supplier) => new()
    {
        Id = supplier.Id,
        Code = supplier.Code,
        Name = supplier.Name,
        Address = supplier.Address,
        City = supplier.City,
        ZipCode = supplier.ZipCode,
        Province = supplier.Province,
        Country = supplier.Country,
        ContactName = supplier.ContactName,
        PhoneNumber = supplier.PhoneNumber,
        Reference = supplier.Reference,
        CreatedAt = supplier.CreatedAt,
        UpdatedAt = supplier.UpdatedAt
    };
}