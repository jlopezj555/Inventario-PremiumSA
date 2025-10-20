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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Usuarios -> tabla y columnas existentes
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("Usuarios");
                entity.HasKey(e => e.Id).HasName("PK_Usuarios");
                entity.Property(e => e.Id).HasColumnName("id_usuario");
                entity.Property(e => e.NombreCompleto).HasColumnName("nombre_completo");
                entity.Property(e => e.UsuarioLogin).HasColumnName("usuario_login");
                entity.Property(e => e.ContrasenaHash).HasColumnName("contrasena");
                entity.Property(e => e.Correo).HasColumnName("correo");
                entity.Property(e => e.Puesto).HasColumnName("puesto");
                entity.Property(e => e.Departamento).HasColumnName("departamento");
                entity.Property(e => e.Telefono).HasColumnName("telefono");
                entity.Ignore(e => e.Rol); // la BD actual no expone esta columna
            });

            // AuthCodes
            modelBuilder.Entity<AuthCode>(entity =>
            {
                entity.ToTable("AuthCodes");
                entity.HasKey(e => e.Id).HasName("PK_AuthCodes");
                entity.Property(e => e.Id).HasColumnName("id_authcode");
                entity.Property(e => e.Codigo).HasColumnName("codigo");
                entity.Property(e => e.UsuarioId).HasColumnName("id_usuario");
                entity.Property(e => e.FechaGeneracion).HasColumnName("fecha_generacion");
                entity.Property(e => e.FechaExpiracion).HasColumnName("fecha_expiracion");
                entity.Property(e => e.Usado).HasColumnName("usado");
                // id_movimiento existe en BD pero no se usa en el modelo
            });

            // Movimientos
            modelBuilder.Entity<Movimiento>(entity =>
            {
                entity.ToTable("Movimientos");
                entity.HasKey(e => e.Id).HasName("PK_Movimientos");
                entity.Property(e => e.Id).HasColumnName("id_movimiento");
                entity.Property(e => e.EquipoId).HasColumnName("id_equipo");
                entity.Property(e => e.UsuarioId).HasColumnName("id_usuario");
                entity.Property(e => e.BodegaOrigenId).HasColumnName("id_bodega_origen");
                entity.Property(e => e.BodegaDestinoId).HasColumnName("id_bodega_destino");
                entity.Property(e => e.TipoMovimiento).HasColumnName("tipo_movimiento");
                entity.Property(e => e.FechaMovimiento).HasColumnName("fecha_movimiento");
                entity.Property(e => e.Observaciones).HasColumnName("observaciones");
            });
        }
    }
}
