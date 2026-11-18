namespace CargoHub.Api.Dtos;

public record ItemLineDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime Created_At { get; set; }
    public DateTime Updated_At { get; set; }
}