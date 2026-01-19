using Microsoft.AspNetCore.Mvc;
using ProyectoBarberia.Application.Interfaces;
using ProyectoBarberia.Domain.Entities;

namespace ProyectoBarberia.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ServiciosController : ControllerBase
{
    private readonly IServicioRepository _repo;

    public ServiciosController(IServicioRepository repo)
    {
        _repo = repo;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var servicios = await _repo.GetAllAsync();
        return Ok(servicios);
    }

    [HttpPost]
    public async Task<IActionResult> Post(Servicio servicio)
    {
        await _repo.AddAsync(servicio);
        return Ok(servicio);
    }
}