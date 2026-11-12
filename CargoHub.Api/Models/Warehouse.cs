namespace CargoHub.Api.Models;

public class Warehouse : IEntity
{
    public int Id { get; set; }
    public string Code { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Adress { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string Zip_Code { get; set; } = string.Empty;
    public string Province { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string Contact_Name { get; set; } = string.Empty;
    public string Contact_Phone { get; set; } = string.Empty;
    public string Contact_Email { get; set; } = string.Empty;
    public DateTime Created_At { get; set; }
    public DateTime Updated_At { get; set; }
}