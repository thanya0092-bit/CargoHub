namespace CargoHub.Api.Models;

public class Order : IEntity
{
    public int Id { get; set; }
    public int Client_Id { get; set; }
    public DateTime Order_Date { get; set; }
    public DateTime Request_Date { get; set; }
    public string Reference { get; set; }
    public string Customer_Po_Number { get; set; }
    public string Order_Status { get; set; }
    public string? Shipping_Notes { get; set; }
    public int Warehouse_Id { get; set; }
    public int Ship_To_Client_Id { get; set; }
    public int Bill_To_Client_Id { get; set; }
    public DateTime Created_At { get; set; }
    public DateTime Updated_At { get; set; }
}

