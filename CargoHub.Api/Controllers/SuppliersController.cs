using CargoHub.Api.Services;
using CargoHub.Api.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace CargoHub.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SuppliersController : ControllerBase
{
    private readonly ISupplierService _suppliers;

    public SuppliersController(ISupplierService suppliers)
    {
        _suppliers = suppliers;
    }

    [HttpGet]
    public async Task<ActionResult<List<SupplierDto>>> GetAll()
        => Ok(await _suppliers.GetAllAsync());

    [HttpGet("{id:int}")]
    public async Task<ActionResult<SupplierDto>> GetById(int id)
    {
        var supplier = await _suppliers.GetByIdAsync(id);
        return supplier is null ? NotFound() : Ok(supplier);
    }

    [HttpPost]
    public async Task<ActionResult<SupplierDto>> Create(CreateSupplierDto dto)
    {
        var created = await _suppliers.CreateAsync(dto);
        return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult> Delete(int id)
    {
        var deleted = await _suppliers.DeleteAsync(id);
        return deleted ? NoContent() : NotFound();
    }
}