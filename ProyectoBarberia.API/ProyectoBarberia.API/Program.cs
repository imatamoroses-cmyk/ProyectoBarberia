using Microsoft.EntityFrameworkCore;
using ProyectoBarberia.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);

// 👉 Controllers
builder.Services.AddControllers();

// 👉 Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 👉 DbContext (NO importa si la BD falla, Swagger igual debe abrir)
builder.Services.AddDbContext<BarberiaDbContext>(options =>
    options.UseNpgsql("Host=localhost;Database=barberia;Username=postgres;Password=postgres")
);

var app = builder.Build();

// 👉 Swagger SIEMPRE visible
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();



