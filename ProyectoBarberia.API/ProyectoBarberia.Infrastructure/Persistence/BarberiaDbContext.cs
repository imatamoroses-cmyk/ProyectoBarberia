using Microsoft.EntityFrameworkCore;
using ProyectoBarberia.Domain.Entities;

namespace ProyectoBarberia.Infrastructure.Persistence
{
    public class BarberiaDbContext : DbContext
    {
        public BarberiaDbContext(DbContextOptions<BarberiaDbContext> options)
            : base(options)
        {
        }

        public DbSet<Barbero> Barberos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Cita> Citas { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<Pago> Pagos { get; set; }
    }
}

