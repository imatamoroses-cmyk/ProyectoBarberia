using Microsoft.EntityFrameworkCore;
using ProyectoBarberia.Application.Interfaces;
using ProyectoBarberia.Domain.Entities;
using ProyectoBarberia.Infrastructure.Persistence;

namespace ProyectoBarberia.Infrastructure.Repositories;

public class CitaRepository : ICitaRepository
{
    private readonly BarberiaDbContext _context;

    public CitaRepository(BarberiaDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Cita>> GetAllAsync()
    {
        return await _context.Citas.ToListAsync();
    }

    public async Task<Cita?> GetByIdAsync(Guid id)
    {
        return await _context.Citas.FindAsync(id);
    }

    public async Task AddAsync(Cita cita)
    {
        _context.Citas.Add(cita);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Cita cita)
    {
        _context.Citas.Update(cita);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var cita = await _context.Citas.FindAsync(id);
        if (cita != null)
        {
            _context.Citas.Remove(cita);
            await _context.SaveChangesAsync();
        }
    }
}
