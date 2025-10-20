using PremiumSAapi.Data;
using PremiumSAapi.Models;
using Microsoft.EntityFrameworkCore;


namespace PremiumSAapi.Services
{
    public class AuthService
    {

        private readonly InventarioContext _db;
        public AuthService(InventarioContext db) { _db = db; }

        public async Task<(bool ok, string codigo, string? error)> GenerarCodigoAsync(int usuarioId, int minutosValidez = 10)
        {
            var rnd = new Random();
            var codigo = rnd.Next(100000, 999999).ToString();

            var now = DateTime.UtcNow;
            var auth = new AuthCode
            {
                Codigo = codigo,
                UsuarioId = usuarioId,
                FechaGeneracion = now,
                FechaExpiracion = now.AddMinutes(minutosValidez),
                Usado = false
            };
            _db.AuthCodes.Add(auth);
            try
            {
                await _db.SaveChangesAsync();
                return (true, codigo, null);
            }
            catch (Exception ex)
            {
                return (false, string.Empty, ex.Message);
            }
        }

        public async Task<(bool valid, string? message, AuthCode? auth)> ValidarCodigoAsync(string codigo)
        {
            var now = DateTime.UtcNow;
            var auth = await _db.AuthCodes.FirstOrDefaultAsync(a => a.Codigo == codigo);
            if (auth == null) return (false, "Código no encontrado", null);
            if (auth.Usado) return (false, "Código ya usado", auth);
            if (auth.FechaExpiracion < now) return (false, "Código expirado", auth);
            return (true, null, auth);
        }

        public async Task MarcarComoUsadoAsync(AuthCode auth)
        {
            auth.Usado = true;
            await _db.SaveChangesAsync();
        }
    }
}
