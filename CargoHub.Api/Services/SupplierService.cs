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
            Code = $"SUP-000001",
            Name = dto.Name,
            Address = dto.Address,
            City = dto.City,
            Zip_Code = dto.Zip_Code,
            Province = dto.Province,
            Country = dto.Country,
            Contact_Name = dto.Contact_Name,
            Phone_Number = dto.Phone_Number,
            Reference = dto.Reference,
            Created_At = now,
            Updated_At = now
        };

        _suppliers.Add(supplier);
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
        Zip_Code = supplier.Zip_Code,
        Province = supplier.Province,
        Country = supplier.Country,
        Contact_Name = supplier.Contact_Name,
        Phone_Number = supplier.Phone_Number,
        Reference = supplier.Reference,
        Created_At = supplier.Created_At,
        Updated_At = supplier.Updated_At
    };
}