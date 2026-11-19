namespace CargoHub.Api.Dtos;
public record ClientDto
{
    public int Id { get; init; }
    public string Name { get; init; }
    public string Address { get; init; }
    public string City { get; init; }
    public string Zip_Code { get; init; }
    public string Province { get; init; }
    public string Country { get; init; }
    public string Contact_Name { get; init; }
    public string Contact_Phone { get; init; }
    public string Contact_Email { get; init; }
    public DateTime Created_At { get; init; }
    public DateTime Updated_At { get; init; }

}
public record CreateClientDto
{
    public string Name { get; init; }
    public string Address { get; init; }
    public string City { get; init; }
    public string Zip_Code { get; init; }
    public string Province { get; init; }
    public string Country { get; init; }
    public string Contact_Name { get; init; }
    public string Contact_Phone { get; init; }
    public string Contact_Email { get; init; }
}