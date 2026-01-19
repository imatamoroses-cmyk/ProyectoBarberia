using Microsoft.AspNetCore.Mvc;
using ProyectoBarberia.Application.Interfaces;
using ProyectoBarberia.Domain.Entities;

namespace ProyectoBarberia.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PagosController : ControllerBase
{
    private readonly IPagoRepository _repo;

    public PagosController(IPagoRepository repo)
    {
        _repo = repo;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var pagos = await _repo.GetAllAsync();
        return Ok(pagos);
    }

    [HttpPost]
    public async Task<IActionResult> Post(Pago pago)
    {
        await _repo.AddAsync(pago);
        return Ok(pago);
    }
}