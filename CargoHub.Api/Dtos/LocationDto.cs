namespace CargoHub.Api.Dtos;

public record LocationDto
{
    public int Id {get; init; }
    public int Warehouse_Id {get; init; }
    public string Code {get; init; } = string.Empty;
    public string Name {get; init; } = string.Empty;
    public DateTime Created_At {get; init; }
    public DateTime Updated_At {get; init; }
}

public record CreateLocationDto
{
    public int Warehouse_Id {get; init; }
    public string Code {get; init; } = string.Empty;
    public string Name {get; init; } = string.Empty;
}