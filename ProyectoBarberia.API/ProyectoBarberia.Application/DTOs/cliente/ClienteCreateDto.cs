namespace ProyectoBarberia.Application.DTOs.Clientes;

public class ClienteReadDto
{
    public Guid Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Telefono { get; set; } = string.Empty;
}
