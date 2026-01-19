using System;

namespace ProyectoBarberia.Domain.Entities
{
    public class Pago
    {
        public int Id { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaPago { get; set; }
        public string MetodoPago { get; set; } = null!;

        public int CitaId { get; set; }
        public Cita Cita { get; set; } = null!;
    }
}