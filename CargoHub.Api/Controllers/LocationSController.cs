using CargoHub.Api.Services;
using CargoHub.Api.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace CargoHub.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LocationsController : ControllerBase
{
    private readonly ILocationService _locations;

    public LocationsController(ILocationService locations)
    {
        _locations = locations;
    }

    [HttpGet]
    public async Task<ActionResult<List<LocationDto>>> GetAll()
        => Ok(await _locations.GetAllAsync());

    [HttpGet("{id:int}")]
    public async Task<ActionResult<LocationDto>> GetById(int id)
    {
        var location = await _locations.GetByIdAsync(id);
        return location is null ? NotFound() : Ok(location);
    }

    [HttpPost]
    public async Task<ActionResult<LocationDto>> Create(CreateLocationDto dto)
    {
        var created = await _locations.CreateAsync(dto);
        return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var deleted = await _locations.DeleteAsync(id);
        return deleted ? NoContent() : NotFound();
    }
}