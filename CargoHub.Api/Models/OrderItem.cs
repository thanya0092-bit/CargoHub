namespace CargoHub.Api.Models;

public class OrderItem : IEntity
{
    public int Id { get; set; }
    public int Order_Id { get; set; }

    public int Item_Id { get; set;}

    public int Amount { get; set;}

    public decimal Unit_Price { get; set;}

}