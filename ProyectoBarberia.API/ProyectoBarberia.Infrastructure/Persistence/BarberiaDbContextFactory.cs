using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ProyectoBarberia.Infrastructure.Persistence
{
    public class BarberiaDbContextFactory 
        : IDesignTimeDbContextFactory<BarberiaDbContext>
    {
        public BarberiaDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BarberiaDbContext>();

            optionsBuilder.UseNpgsql(
                "Host=aws-1-us-east-2.pooler.supabase.com;" +
                "Port=5432;" +
                "Database=postgres;" +
                "Username=postgres.tuvslrkokamhfjxlvdno;" +
                "Password=Saigema7777_;" +
                "SslMode=Require;Trust Server Certificate=true"
            );

            return new BarberiaDbContext(optionsBuilder.Options);
        }
    }
}