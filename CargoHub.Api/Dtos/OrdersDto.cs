namespace CargoHub.Api.Dtos;

public record OrdersDto
{
    public int Id { get; init; }
    public int ClientId { get; init; }
    public DateTime OrderDate { get; init; }
    public DateTime RequestDate { get; init; }
    public string Reference { get; init; } = string.Empty;
    public string CustomerPoNumber { get; init; } = string.Empty;
    public string OrderStatus { get; init; } = string.Empty;
    public string? ShippingNotes { get; init; }
    public int WarehouseId { get; init; }
    public int ShipToClientId { get; init; }
    public int BillToClientId { get; init; }
    public DateTime CreatedAt { get; init; }
    public DateTime UpdatedAt { get; init; }
}

public record CreateOrdersDto
{
    public int ClientId { get; init; }
    public DateTime RequestDate { get; init; }
    public string CustomerPoNumber { get; init; } = string.Empty;
    public string? ShippingNotes { get; init; }
    public int WarehouseId { get; init; }
    public int ShipToClientId { get; init; }
    public int BillToClientId { get; init; }
} 