namespace CargoHub.Api.Dtos;

public record OrderItemDto
{
    public int Id { get; init; }
    public int OrderId { get; init; }
    public int ItemId { get; init;}
    public int Amount { get; init;}
    public decimal UnitPrice { get; init;}

}

public record CreateOrderItemDto
{
    public int OrderId { get; init; }
    public int ItemId { get; init;}
    public int Amount { get; init;}
    public decimal UnitPrice { get; init;}

}
