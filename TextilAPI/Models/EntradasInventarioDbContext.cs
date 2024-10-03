using AlmacenSwagger.Models;
using Microsoft.EntityFrameworkCore;

namespace TextilSwagger.Models
{
    public class EntradasInventarioDbContext :DbContext
    {
        public EntradasInventarioDbContext(DbContextOptions<EntradasInventarioDbContext> options) : base(options)
        {

        }
        public DbSet<EntradasInventario> EntradasInventario { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<EntradasInventario>().HasKey(p => p.entradaid);
        }
    }
}
