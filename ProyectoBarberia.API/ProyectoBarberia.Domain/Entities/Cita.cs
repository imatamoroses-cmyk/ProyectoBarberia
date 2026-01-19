using System.ComponentModel.DataAnnotations.Schema;
namespace ProyectoBarberia.Domain.Entities;
[Table("cita")]
public class Cita
{
    public Guid Id { get; private set; }
    public DateTime Fecha { get; private set; }

    // FK
    public Guid ClienteId { get; private set; }

    private Cita() { } // EF Core

    public Cita(DateTime fecha, Guid clienteId)
    {
        Id = Guid.NewGuid();
        Fecha = fecha;
        ClienteId = clienteId;
    }
}


