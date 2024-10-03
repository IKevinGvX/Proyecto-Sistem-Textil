using Microsoft.EntityFrameworkCore;

namespace TextilSwagger.Models
{
    public class ProductosDbContext  : DbContext
    {
        public ProductosDbContext(DbContextOptions<ProductosDbContext> options) : base(options)
        {

        }
        public DbSet<Productos> Productos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Productos>().HasKey(p => p.productoid
            );
        }
    }
}
