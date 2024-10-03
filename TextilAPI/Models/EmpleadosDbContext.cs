using Microsoft.EntityFrameworkCore;

namespace TextilSwagger.Models
{
    public class EmpleadosDbContext : DbContext
    {
        public EmpleadosDbContext(DbContextOptions<EmpleadosDbContext> options) : base(options)
        {

        }
        public DbSet<Empleados> Empleados { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Empleados>().HasKey(p => p.empleadoid
            );
            modelBuilder.Entity<Empleados>().Property(p => p.sueldo).HasColumnType("decimal(10,2)");
        }
    }
}
