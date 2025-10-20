using System;

namespace PremiumSAapi.Models
{
    public class AuthCode
    {
        public int Id { get; set; }
        public string Codigo { get; set; } = null!; // 6 dígitos
        public int UsuarioId { get; set; }
        public DateTime FechaGeneracion { get; set; } = DateTime.UtcNow;
        public DateTime FechaExpiracion { get; set; }
        public bool Usado { get; set; } = false;
    }
}
