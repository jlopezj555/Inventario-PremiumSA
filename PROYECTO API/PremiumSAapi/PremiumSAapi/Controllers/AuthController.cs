using BCrypt.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PremiumSAapi.Data;
using PremiumSAapi.Dtos;
using PremiumSAapi.Models;
using PremiumSAapi.Services;

namespace PremiumSAapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController: ControllerBase
    {
        private readonly InventarioContext _db;
        private readonly AuthService _authService;
        public AuthController(InventarioContext db, AuthService authService)
        {
            _db = db;
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto dto)
        {
            var usuario = await _db.Usuarios.FirstOrDefaultAsync(u => u.UsuarioLogin == dto.UsuarioLogin);
            if (usuario == null) return BadRequest(new { message = "Usuario no encontrado" });

            if (!BCrypt.Net.BCrypt.Verify(dto.Contrasena, usuario.ContrasenaHash))
                return BadRequest(new { message = "Credenciales inválidas" });

            var (ok, codigo, error) = await _authService.GenerarCodigoAsync(usuario.Id, minutosValidez: dto.MinutosValidez ?? 10);
            if (!ok) return StatusCode(500, new { message = "No fue posible generar el código", error });

            return Ok(new { codigo, expiracionMinutos = dto.MinutosValidez ?? 10 });
        }

        [HttpPost("validate-code")]
        public async Task<IActionResult> ValidateCode([FromBody] ValidateCodeDto dto)
        {
            var (valid, message, auth) = await _authService.ValidarCodigoAsync(dto.Codigo);
            if (!valid) return BadRequest(new { valid = false, message });

            return Ok(new { valid = true, usuarioId = auth!.UsuarioId });
        }
    }
}
