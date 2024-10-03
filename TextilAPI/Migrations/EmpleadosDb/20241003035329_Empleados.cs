using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TextilSwagger.Migrations.EmpleadosDb
{
    /// <inheritdoc />
    public partial class Empleados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    empleadoid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dni = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rango = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sueldo = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.empleadoid);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empleados");
        }
    }
}
