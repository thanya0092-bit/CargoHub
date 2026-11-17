namespace CargoHub.Api.Dtos;

public record InventoryDto
{
    public int Id { get; init; }
    public int Item_Id {get; set; }
    public int Location_Id {get; set; }
    public int Quantity_On_Hand {get; set; }
    public int Quantity_Expected {get; set; }
    public int Quantity_Ordered { get; set; }
    public int Quantity_Allocate { get; set;}
    public DateTime Created_At { get; set; }
    public DateTime Updated_At { get; set; }
}

public record CreateInventoryDto
{
    public int Item_Id {get; set; }
    public int Location_Id {get; set; }
    public int Quantity_On_Hand {get; set; }
    public int Quantity_Expected {get; set; }
    public int Quantity_Ordered { get; set; }
    public int Quantity_Allocate { get; set;}
}