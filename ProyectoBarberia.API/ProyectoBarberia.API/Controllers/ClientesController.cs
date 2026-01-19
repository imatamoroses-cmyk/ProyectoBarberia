using Microsoft.AspNetCore.Mvc;
using ProyectoBarberia.API.Data;
using ProyectoBarberia.API.Models;

namespace ProyectoBarberia.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ClientesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Clientes.ToList());
        }

        [HttpPost]
        public IActionResult Post(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
            return Ok(cliente);
        }
    }
}