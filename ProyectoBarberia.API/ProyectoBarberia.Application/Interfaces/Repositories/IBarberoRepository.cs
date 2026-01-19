using System.Collections.Generic;

namespace ProyectoBarberia.Domain.Entities
{
    public class Barbero
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Especialidad { get; set; } = null!;
        public bool Activo { get; set; } = true;

        public ICollection<Cita> Citas { get; set; } = new List<Cita>();
    }
}