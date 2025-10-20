using System.Text.Json.Serialization;

namespace PremiumSAapi.Dtos
{
    public class ValidateCodeDto {
        [JsonPropertyName("codigo")]
        public string Codigo { get; set; } = null!;
    }
}
