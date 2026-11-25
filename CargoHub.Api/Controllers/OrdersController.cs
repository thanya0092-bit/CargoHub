using CargoHub.Api.Services;
using CargoHub.Api.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace CargoHub.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrdersController : ControllerBase
{
    private readonly IOrdersService _orders;

    public OrdersController(IOrdersService orders)
    {
        _orders = orders;
    }

    [HttpGet]
    public async Task<ActionResult<List<OrdersDto>>> GetAll()
        => Ok(await _orders.GetAllAsync());

    [HttpGet("{id:int}")]
    public async Task<ActionResult<OrdersDto>> GetById(int id)
    {
        var order = await _orders.GetByIdAsync(id);
        return order is null ? NotFound() : Ok(order);
    }

    [HttpPost]
    public async Task<ActionResult<OrdersDto>> Create(CreateOrdersDto dto)
    {
        var created = await _orders.CreateAsync(dto);
        return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult> Delete(int id)
    {
        var deleted = await _orders.DeleteAsync(id);
        return deleted ? NoContent() : NotFound();
    }
}