using System.ComponentModel.DataAnnotations;

namespace ProyectoBarberia.Application.DTOs.Cita
{
    public class CitaCreateDto
    {
        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public int ClienteId { get; set; }

        [Required]
        [MaxLength(200)]
        public string Servicio { get; set; } = string.Empty;
    }
}
