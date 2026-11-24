namespace CargoHub.Api.Dtos;

public record ShipmentDto
{
    public int Id { get; init; }
    public string Reference { get; init; } = string.Empty;
    public int Order_Id { get; init; }
    public DateTime Shipment_Date {get; init; }
    public string Shipment_Type { get; init; } = string.Empty;
    public string Shipment_Status {get; init; } = string.Empty;
    public string? Carrier_Name {get; init; }
    public string? Shipping_Method {get; init; }
    public string? Payment_Type {get; init; }
    public DateTime Created_At {get; init; }
    public DateTime Updated_At {get; init; }
}

public record CreateShipmentDto
{
    public int Order_Id { get; init; }
    public DateTime Shipment_Date {get; init; }
    public string Shipment_Type { get; init; } = string.Empty;
    public string? Carrier_Name {get; init; }
    public string? Shipping_Method {get; init; }
    public string? Payment_Type {get; init; }
}
