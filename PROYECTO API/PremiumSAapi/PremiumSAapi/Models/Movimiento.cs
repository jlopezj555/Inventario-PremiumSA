using System;

namespace PremiumSAapi.Models
{
    public class Movimiento
    {
        public int Id { get; set; }
        public int EquipoId { get; set; }
        public int UsuarioId { get; set; }
        public int? BodegaOrigenId { get; set; }
        public int? BodegaDestinoId { get; set; }
        public string TipoMovimiento { get; set; } = null!;
        public DateTime FechaMovimiento { get; set; } = DateTime.UtcNow;
        public string? Observaciones { get; set; }
    }
}
