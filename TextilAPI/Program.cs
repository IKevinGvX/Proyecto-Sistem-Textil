using AlmacenSwagger.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.DependencyInjection;
using TextilSwagger.Models;

var builder = WebApplication.CreateBuilder(args);


// Habilitar CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();

    });
});

// Add services to the container.
builder.Services.AddControllers();
//conexion con clientes
builder.Services.AddDbContext<ClientesDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Connection")));
//conexion con almacen
builder.Services.AddDbContext<AlmacenContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Connection")));
//conexion con empleados
builder.Services.AddDbContext<EmpleadosDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Connection")));
// conexion con productos 
builder.Services.AddDbContext<ProductosDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Connection")));
// conexion con proveedores
builder.Services.AddDbContext<ProveedoresDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Connection")));
//conexion con entradas inventario
builder.Services.AddDbContext<EntradasInventarioDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Connection")));
// conexion con salida inventario 
builder.Services.AddDbContext<SalidaInventarioDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Connection")));
//
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Usar CORS
app.UseCors("AllowAll");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();