namespace CargoHub.Api.Dtos;

public record OrderItemDto
{
    public int Id { get; init; }
    public int Order_Id { get; init; }

    public int Item_Id { get; init;}

    public int Amount { get; init;}

    public decimal Unit_Price { get; init;}

}

public record CreateOrderItemDto
{
    public int Order_Id { get; init; }

    public int Item_Id { get; init;}

    public int Amount { get; init;}

    public decimal Unit_Price { get; init;}

}
