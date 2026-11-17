using CargoHub.Api.Dtos;
using CargoHub.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace CargoHub.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WarehousesController : ControllerBase
{
    private readonly IWarehouseService _warehouses;

    public WarehousesController(IWarehouseService warehouses)
    {
        _warehouses = warehouses;
    }

    [HttpGet]
    public async Task<ActionResult<List<WarehouseDto>>> GetAll()
        => Ok(await _warehouses.GetAllAsync());

    [HttpGet("{id:int}")]
    public async Task<ActionResult<WarehouseDto>> GetById(int id)
    {
        var warehouse = await _warehouses.GetByIdAsync(id);
        return warehouse is null ? NotFound() : Ok(warehouse);
    }
}