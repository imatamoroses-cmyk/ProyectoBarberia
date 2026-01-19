using Microsoft.EntityFrameworkCore;
using ProyectoBarberia.API.Models;

namespace ProyectoBarberia.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
    }
}