using Microsoft.EntityFrameworkCore;
using ProyectoBarberia.Application.Interfaces;
using ProyectoBarberia.Domain.Entities;
using ProyectoBarberia.Infrastructure.Persistence;

namespace ProyectoBarberia.Infrastructure.Repositories;

public class PagoRepository : IPagoRepository
{
    private readonly BarberiaDbContext _context;

    public PagoRepository(BarberiaDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Pago>> GetAllAsync()
    {
        return await _context.Pagos.ToListAsync();
    }

    public async Task<Pago?> GetByIdAsync(Guid id)
    {
        return await _context.Pagos.FindAsync(id);
    }

    public async Task AddAsync(Pago pago)
    {
        _context.Pagos.Add(pago);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Pago pago)
    {
        _context.Pagos.Update(pago);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var pago = await _context.Pagos.FindAsync(id);
        if (pago != null)
        {
            _context.Pagos.Remove(pago);
            await _context.SaveChangesAsync();
        }
    }
}