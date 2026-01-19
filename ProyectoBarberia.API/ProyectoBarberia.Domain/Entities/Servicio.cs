using System.ComponentModel.DataAnnotations.Schema;
namespace ProyectoBarberia.Domain.Entities;
[Table("servicio")]
public class Servicio
{
    public Guid Id { get; set; }
    public string Nombre { get; set; } = null!;
    public decimal Precio { get; set; }
}