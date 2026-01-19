using System.ComponentModel.DataAnnotations.Schema;
namespace ProyectoBarberia.Domain.Entities;
[Table("pago")]
public class Pago
{
    public Guid Id { get; set; }
    public Guid CitaId { get; set; }
    public decimal Monto { get; set; }
    public DateTime Fecha { get; set; }
    public string Metodo { get; set; } = string.Empty;
}
