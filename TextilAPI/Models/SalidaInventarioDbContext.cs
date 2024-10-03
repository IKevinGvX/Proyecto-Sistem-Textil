using Microsoft.EntityFrameworkCore;

namespace TextilSwagger.Models
{
    public class SalidaInventarioDbContext : DbContext
    {
        public SalidaInventarioDbContext(DbContextOptions<SalidaInventarioDbContext> options) : base(options)
        {

        }
        public DbSet<SalidaInventario> SalidasInventario { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<SalidaInventario>().HasKey(p => p.salidaid
            );
        }
    }
}
