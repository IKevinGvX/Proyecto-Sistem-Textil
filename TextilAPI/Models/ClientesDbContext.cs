using Microsoft.EntityFrameworkCore;

namespace TextilSwagger.Models
{
    public class ClientesDbContext : DbContext
    {
        
            public ClientesDbContext(DbContextOptions<ClientesDbContext> options) : base(options)
            {

            }
            public DbSet<Clientes> Clientes { get; set; }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
                modelBuilder.Entity<Clientes>().HasKey(p => p.clientesid
                );
            }
        
    }
}
