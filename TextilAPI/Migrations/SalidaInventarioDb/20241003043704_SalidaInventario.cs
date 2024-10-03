using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TextilSwagger.Migrations.SalidaInventarioDb
{
    /// <inheritdoc />
    public partial class SalidaInventario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SalidaInventario",
                columns: table => new
                {
                    salidaid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fechasalida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    empleadoid = table.Column<int>(type: "int", nullable: false),
                    productoid = table.Column<int>(type: "int", nullable: false),
                    cantidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalidaInventario", x => x.salidaid);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SalidaInventario");
        }
    }
}
