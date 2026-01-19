using Microsoft.AspNetCore.Mvc;
using ProyectoBarberia.Application.Interfaces;
using ProyectoBarberia.Domain.Entities;

namespace ProyectoBarberia.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CitasController : ControllerBase
    {
        private readonly ICitaRepository _citaRepository;

        public CitasController(ICitaRepository citaRepository)
        {
            _citaRepository = citaRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var citas = await _citaRepository.GetAllAsync();
            return Ok(citas);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Cita cita)
        {
            await _citaRepository.AddAsync(cita);
            return Ok(cita);
        }
    }   // ← cierra la clase
}       // ← cierra el namespace
