using CargoHub.Api.Dtos;
using CargoHub.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace CargoHub.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ItemLinesController : ControllerBase
{
    private readonly IItemLineService _itemLines;

    public ItemLinesController(IItemLineService itemLines)
    {
        _itemLines = itemLines;
    }

    [HttpGet]
    public async Task<ActionResult<List<ItemLineDto>>> GetAll()
        => Ok(await _itemLines.GetAllAsync());

    [HttpGet("{id:int}")]
    public async Task<ActionResult<ItemLineDto>> GetById(int id)
    {
        var itemLine = await _itemLines.GetByIdAsync(id);
        return itemLine is null ? NotFound() : Ok(itemLine);
    }
}