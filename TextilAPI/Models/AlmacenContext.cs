using Microsoft.EntityFrameworkCore;
using TextilAPI.Models;

namespace AlmacenSwagger.Models
{
    public class AlmacenContext : DbContext
    {
        public AlmacenContext(DbContextOptions<AlmacenContext> options ) : base( options )
        {

        }
        public DbSet<Almacen> Almacen { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Almacen>().HasKey(p=> p.almacenid);
        }
    }
}
