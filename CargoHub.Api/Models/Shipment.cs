namespace CargoHub.Api.Models;

public class Shipment : IEntity
{
    public int Id {get; set; }
    public string Reference {get; set; } = string.Empty;
    public int Order_Id {get; set; }
    public DateTime Shipment_Date {get; set; }
    public string Shipment_Type { get; set; } = string.Empty;
    public string Shipment_Status {get; set; } = string.Empty;
    public string? Carrier_Name {get; set; }
    public string? Shipping_Method {get; set; }
    public string? Payment_Type {get; set; }
    public DateTime Created_At {get; set; }
    public DateTime Updated_At {get; set; }
}