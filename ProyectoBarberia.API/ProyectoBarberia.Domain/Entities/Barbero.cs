using System.ComponentModel.DataAnnotations.Schema;
namespace ProyectoBarberia.Domain.Entities;
[Table("barberos")]
public class Barbero
{
    public Guid Id { get; set; }
    public string Nombre { get; set; } = null!;
    public string Especialidad { get; set; } = null!;
}