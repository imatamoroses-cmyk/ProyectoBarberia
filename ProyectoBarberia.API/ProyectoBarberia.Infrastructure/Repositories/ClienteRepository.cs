using Microsoft.EntityFrameworkCore;
using ProyectoBarberia.Application.Interfaces.Repositories;
using ProyectoBarberia.Domain.Entities;
using ProyectoBarberia.Infrastructure.Persistence;

namespace ProyectoBarberia.Infrastructure.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly BarberiaDbContext _context;

        public ClienteRepository(BarberiaDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Cliente>> GetAllAsync()
            => await _context.Clientes.ToListAsync();

        public async Task<Cliente?> GetByIdAsync(int id)
            => await _context.Clientes.FindAsync(id);

        public async Task AddAsync(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Cliente cliente)
        {
            _context.Clientes.Update(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                await _context.SaveChangesAsync();
            }
        }
    }
}