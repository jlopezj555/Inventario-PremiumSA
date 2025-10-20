using System.Collections.Generic;

namespace PremiumSAapi.Dtos
{
    public class MovimientoRequestDto
    {
        public string CodigoAutorizacion { get; set; } = null!;
        public string TipoMovimiento { get; set; } = null!;
        public int? IdBodega { get; set; }
        public List<ProductoDto> Productos { get; set; } = new();
        public string? Observaciones { get; set; }
    }

    public class ProductoDto
    {
        public int IdEquipo { get; set; }
        public int Cantidad { get; set; } = 1;
    }

}
