namespace CargoHub.Api.Models;

public class Location : IEntity
{
    public int Id {get; set; }
    public int Warehouse_Id {get; set; }
    public string Code {get; set; } = string.Empty;
    public string Name {get; set; } = string.Empty;
    public DateTime Created_At {get; set; }
    public DateTime Updated_At {get; set; }
}
