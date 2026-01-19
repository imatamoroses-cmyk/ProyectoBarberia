using System;

namespace ProyectoBarberia.Domain.Entities
{
    public class Cita
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; } = null!;

        public int BarberoId { get; set; }
        public Barbero Barbero { get; set; } = null!;

        public int ServicioId { get; set; }
        public Servicio Servicio { get; set; } = null!;

        public Pago? Pago { get; set; }
    }
}
