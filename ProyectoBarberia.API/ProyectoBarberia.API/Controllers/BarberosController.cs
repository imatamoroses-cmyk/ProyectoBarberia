using Microsoft.AspNetCore.Mvc;
using ProyectoBarberia.Application.Interfaces;
using ProyectoBarberia.Domain.Entities;

namespace ProyectoBarberia.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BarberosController : ControllerBase
{
    private readonly IBarberoRepository _repo;

    public BarberosController(IBarberoRepository repo)
    {
        _repo = repo;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var barberos = await _repo.GetAllAsync();
        return Ok(barberos);
    }

    [HttpPost]
    public async Task<IActionResult> Post(Barbero barbero)
    {
        await _repo.AddAsync(barbero);
        return Ok(barbero);
    }
}