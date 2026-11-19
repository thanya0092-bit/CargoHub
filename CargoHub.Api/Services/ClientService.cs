using CargoHub.Api.Dtos;
using CargoHub.Api.Models;
using CargoHub.Api.Repositories;

namespace CargoHub.Api.Services;

public class ClientService : IClientService
{
    private readonly IRepository<Client> _clients;

    public ClientService(IRepository<Client> clients)
    {
        _clients = clients;
    }

    public async Task<List<ClientDto>> GetAllAsync()
    {
        var clients = await _clients.GetAllAsync();
        return clients.Select(ToDto).ToList();
    }

    public async Task<ClientDto?> GetByIdAsync(int id)
    {
        var client = await _clients.GetByIdAsync(id);
        return client is null ? null : ToDto(client);
    }

    public async Task<ClientDto> CreateAsync(CreateClientDto dto)
    {
        var now = DateTime.UtcNow;
        var client = new Client
        {
            Name = dto.Name,
            Address = dto.Address,
            City = dto.City,
            Zip_Code = dto.Zip_Code,
            Province = dto.Province,
            Country = dto.Country,
            Contact_Name = dto.Contact_Name,
            Contact_Phone = dto.Contact_Phone,
            Contact_Email = dto.Contact_Email,
            Created_At = now,
            Updated_At = now
        };

        _clients.Add(client);
        await _clients.SaveChangesAsync();

        return ToDto(client);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var client = await _clients.GetByIdAsync(id);
        if (client is null) return false;

        _clients.Delete(client);
        await _clients.SaveChangesAsync();

        return true;
    }

    private static ClientDto ToDto(Client client) => new()
    {
        Id = client.Id,
        Name = client.Name,
        Address = client.Address,
        City = client.City,
        Zip_Code = client.Zip_Code,
        Province = client.Province,
        Country = client.Country,
        Contact_Name = client.Contact_Name,
        Contact_Phone = client.Contact_Phone,
        Contact_Email = client.Contact_Email,
        Created_At = client.Created_At,
        Updated_At = client.Updated_At
    };
}