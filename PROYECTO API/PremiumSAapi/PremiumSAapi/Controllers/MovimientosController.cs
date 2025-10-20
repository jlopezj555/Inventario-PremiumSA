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
    public class MovimientosController:ControllerBase
    {

        private readonly InventarioContext _db;
        private readonly AuthService _authService;
        public MovimientosController(InventarioContext db, AuthService authService)
        {
            _db = db;
            _authService = authService;
        }

        [HttpPost]
        public async Task<IActionResult> RegistrarMovimiento([FromBody] MovimientoRequestDto dto)
        {
            var (valid, message, auth) = await _authService.ValidarCodigoAsync(dto.CodigoAutorizacion);
            if (!valid) return BadRequest(new { success = false, message });

            // Registrar movimientos por producto
            foreach (var p in dto.Productos)
            {
                var mov = new Movimiento
                {
                    EquipoId = p.IdEquipo,
                    UsuarioId = auth!.UsuarioId,
                    BodegaOrigenId = dto.IdBodega,
                    TipoMovimiento = dto.TipoMovimiento,
                    Observaciones = dto.Observaciones
                };
                _db.Movimientos.Add(mov);
            }

            // Marcar código como usado
            auth!.Usado = true;

            await _db.SaveChangesAsync();
            return Ok(new { success = true, message = "Movimiento registrado" });
        }
    }
}
