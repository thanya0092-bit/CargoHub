namespace CargoHub.Api.Dtos;

public record OrdersDto
{
    public int Id { get; init; }
    public int Client_Id { get; init; }
    public DateTime Order_Date { get; init; }
    public DateTime Request_Date { get; init; }
    public string Reference { get; init; } = string.Empty;
    public string Customer_Po_Number { get; init; } = string.Empty;
    public string Order_Status { get; init; } = string.Empty;
    public string? Shipping_Notes { get; init; }
    public int Warehouse_Id { get; init; }
    public int Ship_To_Client_Id { get; init; }
    public int Bill_To_Client_Id { get; init; }
    public DateTime Created_At { get; init; }
    public DateTime Updated_At { get; init; }
}

public record CreateOrdersDto
{
    public int Client_Id { get; init; }
    public DateTime Request_Date { get; init; }
    public string Customer_Po_Number { get; init; } = string.Empty;
    public string? Shipping_Notes { get; init; }
    public int Warehouse_Id { get; init; }
    public int Ship_To_Client_Id { get; init; }
    public int Bill_To_Client_Id { get; init; }
} 