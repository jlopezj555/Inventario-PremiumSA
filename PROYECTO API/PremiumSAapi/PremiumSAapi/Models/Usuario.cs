namespace PremiumSAapi.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; } = null!;
        public string UsuarioLogin { get; set; } = null!;
        public string ContrasenaHash { get; set; } = null!;
        public string Correo { get; set; } = null!;
        public string? Puesto { get; set; }
        public string? Departamento { get; set; }
        public string? Telefono { get; set; }
        public string Rol { get; set; } = "Empleado"; // Admin | Empleado
    }
}
