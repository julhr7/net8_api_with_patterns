using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        // Constructor que recibe las opciones de configuración del DbContext
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // DbSet para la entidad Product
        public DbSet<Product> Products { get; set; }

        // Método para configurar el modelo de la base de datos (opcional)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().ToTable("Product");

            // Configuraciones adicionales del modelo (por ejemplo, restricciones, índices, etc.)
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(p => p.Id);
                //entity.Property(p => p.Id).HasColumnName("_id");
                entity.Property(p => p.ProductName).HasColumnName("productName").IsRequired().HasMaxLength(100);
                entity.Property(p => p.ProductTypeName).HasColumnName("productTypeName").IsRequired().HasMaxLength(50);
                entity.Property(p => p.NumeracioTerminal).HasColumnName("numeracioTerminal");
                entity.Property(p => p.SoldAt).HasColumnName("soldAt");
                entity.Property(p => p.CustomerId).HasColumnName("customerId").IsRequired().HasMaxLength(20);
            });
        }
    }
}
