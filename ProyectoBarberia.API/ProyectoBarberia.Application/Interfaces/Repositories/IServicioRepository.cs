using System.Collections.Generic;

namespace ProyectoBarberia.Domain.Entities
{
    public class Servicio
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public decimal Precio { get; set; }
        public int DuracionMinutos { get; set; }

        public ICollection<Cita> Citas { get; set; } = new List<Cita>();
    }
}