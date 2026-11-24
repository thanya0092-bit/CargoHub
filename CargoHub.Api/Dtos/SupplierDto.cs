
namespace CargoHub.Api.Dtos;

public record SupplierDto
{
    public int Id { get; init; }
    public string Code { get; init; } = string.Empty;
    public string Name { get; init; } = string.Empty;
    public string Address { get; init; } = string.Empty;
    public string City { get; init; } = string.Empty;
    public string Zip_Code { get; init; } = string.Empty;
    public string Province { get; init; } = string.Empty;
    public string Country { get; init; } = string.Empty;
    public string Contact_Name { get; init; } = string.Empty;
    public string Phone_Number { get; init; } = string.Empty;
    public string Reference { get; init; } = string.Empty;
    public DateTime Created_At { get; init; }
    public DateTime Updated_At { get; init; }
}

public record CreateSupplierDto
{
    public string Name { get; init; } = string.Empty;
    public string Address { get; init; } = string.Empty;
    public string City { get; init; } = string.Empty;
    public string Zip_Code { get; init; } = string.Empty;
    public string Province { get; init; } = string.Empty;
    public string Country { get; init; } = string.Empty;
    public string Contact_Name { get; init; } = string.Empty;
    public string Phone_Number { get; init; } = string.Empty;
    public string Reference { get; init; } = string.Empty;
}
