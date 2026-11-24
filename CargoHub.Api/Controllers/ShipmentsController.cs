using CargoHub.Api.Dtos;
using CargoHub.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace CargoHub.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ShipmentsController : ControllerBase
{
    private readonly IShipmentService _shipments;

    public ShipmentsController(IShipmentService shipments)
    {
        _shipments = shipments;
    }

    [HttpGet]
    public async Task<ActionResult<List<ShipmentDto>>> GetAll()
        => Ok(await _shipments.GetAllAsync());

    [HttpGet("{id:int}")]
    public async Task<ActionResult<ShipmentDto>> GetById(int id)
    {
        var shipment = await _shipments.GetByIdAsync(id);
        return shipment is null ? NotFound() : Ok(shipment);
    }

    [HttpPost]
    public async Task<ActionResult<ShipmentDto>> Create(CreateShipmentDto dto)
    {
        var created = await _shipments.CreateAsync(dto);
        return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }
    

    [HttpDelete("{id:int}")]
    public async Task<ActionResult> Delete(int id)
    {
        var deleted = await _shipments.DeleteAsync(id);
        return deleted ? NoContent() : NotFound();
    }
}