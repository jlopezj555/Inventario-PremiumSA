using System.Text.Json.Serialization;

namespace PremiumSAapi.Dtos
{
    public class LoginDto
    {
        [JsonPropertyName("usuario_login")]
        public string UsuarioLogin { get; set; } = null!;

        [JsonPropertyName("contrasena")]
        public string Contrasena { get; set; } = null!;

        [JsonPropertyName("minutos_validez")]
        public int? MinutosValidez { get; set; }
    }
}
