using Microsoft.EntityFrameworkCore;
using PremiumSAapi.Models;


namespace PremiumSAapi.Data
{
    public class InventarioContext:DbContext
    {
        public InventarioContext(DbContextOptions<InventarioContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; } = null!;
        public DbSet<AuthCode> AuthCodes { get; set; } = null!;
        public DbSet<Movimiento> Movimientos { get; set; } = null!;
        // Agrega más DbSet si creas más modelos
    }
}
