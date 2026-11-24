namespace CargoHub.Api.Models;

public record ShipmentItemDto
{
    public int Id {get; init; }
    public int Shipment_Id {get; init; }
    public int Item_Id {get; init; }
    public int Amount {get; init; }
}

public record CreateShipmentItemDto
{
    public int Shipment_Id {get; init; }
    public int Item_Id {get; init; }
    public int Amount {get; init; }
}