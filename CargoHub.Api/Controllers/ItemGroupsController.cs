using CargoHub.Api.Dtos;
using CargoHub.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace CargoHub.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ItemGroupsController : ControllerBase
{
    private readonly IItemGroupService _itemGroups;

    public ItemGroupsController(IItemGroupService itemGroups)
    {
        _itemGroups = itemGroups;
    }

    [HttpGet]
    public async Task<ActionResult<List<ItemGroupDto>>> GetAll()
        => Ok(await _itemGroups.GetAllAsync());

    [HttpGet("{id:int}")]
    public async Task<ActionResult<ItemGroupDto>> GetById(int id)
    {
        var itemGroup = await _itemGroups.GetByIdAsync(id);
        return itemGroup is null ? NotFound() : Ok(itemGroup);
    }
}