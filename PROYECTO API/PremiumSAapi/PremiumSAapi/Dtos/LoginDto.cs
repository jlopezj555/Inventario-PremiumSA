namespace PremiumSAapi.Dtos
{
    public class LoginDto
    {
        public string UsuarioLogin { get; set; } = null!;
        public string Contrasena { get; set; } = null!;
        public int? MinutosValidez { get; set; }
    }
}
