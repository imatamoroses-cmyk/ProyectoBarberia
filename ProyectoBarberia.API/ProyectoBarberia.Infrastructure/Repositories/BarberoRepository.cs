using Microsoft.EntityFrameworkCore;
using ProyectoBarberia.Application.Interfaces;
using ProyectoBarberia.Domain.Entities;
using ProyectoBarberia.Infrastructure.Persistence;

namespace ProyectoBarberia.Infrastructure.Repositories;

public class BarberoRepository : IBarberoRepository
{
    private readonly BarberiaDbContext _context;

    public BarberoRepository(BarberiaDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Barbero>> GetAllAsync()
    {
        return await _context.Barberos.ToListAsync();
    }

    public async Task<Barbero?> GetByIdAsync(Guid id)
    {
        return await _context.Barberos.FindAsync(id);
    }

    public async Task AddAsync(Barbero barbero)
    {
        barbero.Id = Guid.NewGuid(); // genera un Id nuevo siempre
        _context.Barberos.Add(barbero);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Barbero barbero)
    {
        _context.Barberos.Update(barbero);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var barbero = await _context.Barberos.FindAsync(id);
        if (barbero != null)
        {
            _context.Barberos.Remove(barbero);
            await _context.SaveChangesAsync();
        }
    }
}