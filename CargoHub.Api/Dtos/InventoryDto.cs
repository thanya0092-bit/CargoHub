namespace CargoHub.Api.Dtos;

public record InventoryDto
{
    public int Id { get; init; }
    public int Item_Id {get; init; }
    public int Location_Id {get; init; }
    public int Quantity_On_Hand {get; init; }
    public int Quantity_Expected {get; init; }
    public int Quantity_Ordered { get; init; }
    public int Quantity_Allocate { get; init;}
    public DateTime Created_At { get; init; }
    public DateTime Updated_At { get; init; }
}

public record CreateInventoryDto
{
    public int Item_Id {get; init; }
    public int Location_Id {get; init; }
    public int Quantity_On_Hand {get; init; }
    public int Quantity_Expected {get; init; }
}