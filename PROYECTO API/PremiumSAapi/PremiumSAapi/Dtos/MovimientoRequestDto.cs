using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PremiumSAapi.Dtos
{
    public class MovimientoRequestDto
    {
        [JsonPropertyName("codigo_autorizacion")]
        public string CodigoAutorizacion { get; set; } = null!;

        [JsonPropertyName("tipo_movimiento")]
        public string TipoMovimiento { get; set; } = null!;

        [JsonPropertyName("id_bodega")]
        public int? IdBodega { get; set; }

        [JsonPropertyName("productos")]
        public List<ProductoDto> Productos { get; set; } = new();

        [JsonPropertyName("observaciones")]
        public string? Observaciones { get; set; }
    }

    public class ProductoDto
    {
        [JsonPropertyName("id_equipo")]
        public int IdEquipo { get; set; }

        [JsonPropertyName("cantidad")]
        public int Cantidad { get; set; } = 1;
    }

}
