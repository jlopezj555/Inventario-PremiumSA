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

            if (dto.Productos == null || dto.Productos.Count == 0)
            {
                return BadRequest(new { success = false, message = "Debe enviar al menos un producto." });
            }

            var tipo = dto.TipoMovimiento?.Trim() ?? string.Empty;
            var esRetiro = string.Equals(tipo, "Retiro", StringComparison.OrdinalIgnoreCase);
            var esDevolucion = string.Equals(tipo, "Devolución", StringComparison.OrdinalIgnoreCase) || string.Equals(tipo, "Devolucion", StringComparison.OrdinalIgnoreCase);

            await using var trx = await _db.Database.BeginTransactionAsync();
            try
            {
                // Registrar movimientos por producto y ajustar stock según cantidad
                foreach (var p in dto.Productos)
                {
                    var cantidad = p.Cantidad <= 0 ? 1 : p.Cantidad;

                    var mov = new Movimiento
                    {
                        EquipoId = p.IdEquipo,
                        UsuarioId = auth!.UsuarioId,
                        BodegaOrigenId = dto.IdBodega,
                        TipoMovimiento = dto.TipoMovimiento,
                        Observaciones = dto.Observaciones
                    };
                    _db.Movimientos.Add(mov);

                    int delta = 0;
                    if (esRetiro) delta = -cantidad;
                    else if (esDevolucion) delta = cantidad;

                    if (delta != 0)
                    {
                        // Intentar actualizar inventario existente
                        var rows = await _db.Database.ExecuteSqlRawAsync(
                            "UPDATE Inventario_Equipos SET stock_actual = GREATEST(stock_actual + {0}, 0) WHERE id_equipo = {1}",
                            delta, p.IdEquipo);

                        if (rows == 0)
                        {
                            // Si no existe fila de inventario, crearla y aplicar delta positivo si corresponde
                            int initialStock = Math.Max(delta, 0);
                            await _db.Database.ExecuteSqlRawAsync(
                                "INSERT INTO Inventario_Equipos (id_equipo, stock_actual, stock_minimo) VALUES ({0}, {1}, 1)",
                                p.IdEquipo, initialStock);
                        }
                    }
                }

                // Marcar código como usado
                auth!.Usado = true;

                await _db.SaveChangesAsync();
                await trx.CommitAsync();
                return Ok(new { success = true, message = "Movimiento registrado" });
            }
            catch (Exception ex)
            {
                await trx.RollbackAsync();
                return StatusCode(500, new { success = false, message = "Error al registrar movimiento", error = ex.Message });
            }
        }
    }
}
