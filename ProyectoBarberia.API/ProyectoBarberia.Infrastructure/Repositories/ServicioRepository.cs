using Microsoft.EntityFrameworkCore;
using ProyectoBarberia.Application.Interfaces;
using ProyectoBarberia.Domain.Entities;
using ProyectoBarberia.Infrastructure.Persistence;

namespace ProyectoBarberia.Infrastructure.Repositories;

public class ServicioRepository : IServicioRepository
{
    private readonly BarberiaDbContext _context;

    public ServicioRepository(BarberiaDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Servicio>> GetAllAsync()
    {
        return await _context.Servicios.ToListAsync();
    }

    public async Task<Servicio?> GetByIdAsync(Guid id)
    {
        return await _context.Servicios.FindAsync(id);
    }

    public async Task AddAsync(Servicio servicio)
    {
        _context.Servicios.Add(servicio);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Servicio servicio)
    {
        _context.Servicios.Update(servicio);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var servicio = await _context.Servicios.FindAsync(id);
        if (servicio != null)
        {
            _context.Servicios.Remove(servicio);
            await _context.SaveChangesAsync();
        }
    }
}