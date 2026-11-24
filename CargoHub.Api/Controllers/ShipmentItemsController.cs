using CargoHub.Api.Dtos;
using CargoHub.Api.Models;
using CargoHub.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace CargoHub.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ShipmentItemsController : ControllerBase
{
    private readonly IShipmentItemService _shipmentItems;

    public ShipmentItemsController(IShipmentItemService shipmentItems)
    {
        _shipmentItems = shipmentItems;
    }

    [HttpGet]
    public async Task<ActionResult<List<ShipmentItemDto>>> GetAll()
        => Ok(await _shipmentItems.GetAllAsync());

    [HttpGet("{id:int}")]
    public async Task<ActionResult<ShipmentItemDto>> GetById(int id)
    {
        var shipmentItem = await _shipmentItems.GetByIdAsync(id);
        return shipmentItem is null ? NotFound() : Ok(shipmentItem);
    }

    [HttpPost]
    public async Task<ActionResult<ShipmentItemDto>> Create(CreateShipmentItemDto dto)
    {
        var created = await _shipmentItems.CreateAsync(dto);
        return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var deleted = await _shipmentItems.DeleteAsync(id);
        return deleted ? NoContent() : NotFound();
    }
}