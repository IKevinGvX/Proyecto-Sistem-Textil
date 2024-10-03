using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TextilSwagger.Migrations.EntradasInventarioDb
{
    /// <inheritdoc />
    public partial class EntradasInventario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EntradasInventario",
                columns: table => new
                {
                    almacenid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    entradaid = table.Column<int>(type: "int", nullable: false),
                    fechaentrada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    productoid = table.Column<int>(type: "int", nullable: false),
                    cantidad = table.Column<int>(type: "int", nullable: false),
                    proveedorid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntradasInventario", x => x.almacenid);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EntradasInventario");
        }
    }
}
