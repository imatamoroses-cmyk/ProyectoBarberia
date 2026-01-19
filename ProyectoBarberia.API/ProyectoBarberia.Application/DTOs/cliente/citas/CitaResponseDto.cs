namespace ProyectoBarberia.Application.DTOs.Cita
{
    public class CitaResponseDto
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int ClienteId { get; set; }
        public string Servicio { get; set; } = string.Empty;
    }
}
