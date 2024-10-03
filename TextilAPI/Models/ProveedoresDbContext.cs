using Microsoft.EntityFrameworkCore;

namespace TextilSwagger.Models
{
    public class ProveedoresDbContext : DbContext
    {
        public ProveedoresDbContext(DbContextOptions<ProveedoresDbContext> options) : base(options)
        {

        }
        public DbSet<Proveedores> Proveedores { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Proveedores>().HasKey(p => p.proveedorid
            );
        }
    }
}
