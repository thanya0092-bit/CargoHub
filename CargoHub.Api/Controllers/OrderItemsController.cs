using CargoHub.Api.Services;
using CargoHub.Api.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace CargoHub.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrderItemController : ControllerBase
{
    private readonly IOrderItemService _orderItems;

    public OrderItemController(IOrderItemService orderItems)
    {
        _orderItems = orderItems;
    }

    [HttpGet]
    public async Task<ActionResult<List<OrderItemDto>>> GetAll()
        => Ok(await _orderItems.GetAllAsync());

    [HttpGet("{id:int}")]
    public async Task<ActionResult<OrderItemDto>> GetById(int id)
    {
        var orderItem = await _orderItems.GetByIdAsync(id);
        return orderItem is null ? NotFound() : Ok(orderItem);
    }
    
    [HttpPost]
    public async Task<ActionResult<OrderItemDto>> Create(CreateOrderItemDto dto)
    {
        var created = await _orderItems.CreateAsync(dto);
        return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var deleted = await _orderItems.DeleteAsync(id);
        return deleted ? NoContent() : NotFound();
    }
}