using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaDeServicios.Migrations
{
    /// <inheritdoc />
    public partial class EliminarServiciosYRelacionarTipoServicio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HojaServicioServicios");

            migrationBuilder.DropTable(
                name: "Servicios");

            migrationBuilder.AddColumn<int>(
                name: "HojaServicioId",
                table: "TiposDeServicios",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "TiposDeServicios",
                keyColumn: "Id",
                keyValue: 1,
                column: "HojaServicioId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TiposDeServicios",
                keyColumn: "Id",
                keyValue: 2,
                column: "HojaServicioId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TiposDeServicios",
                keyColumn: "Id",
                keyValue: 3,
                column: "HojaServicioId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TiposDeServicios",
                keyColumn: "Id",
                keyValue: 4,
                column: "HojaServicioId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TiposDeServicios",
                keyColumn: "Id",
                keyValue: 5,
                column: "HojaServicioId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TiposDeServicios",
                keyColumn: "Id",
                keyValue: 6,
                column: "HojaServicioId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TiposDeServicios",
                keyColumn: "Id",
                keyValue: 7,
                column: "HojaServicioId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TiposDeServicios",
                keyColumn: "Id",
                keyValue: 8,
                column: "HojaServicioId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TiposDeServicios",
                keyColumn: "Id",
                keyValue: 9,
                column: "HojaServicioId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_TiposDeServicios_HojaServicioId",
                table: "TiposDeServicios",
                column: "HojaServicioId");

            migrationBuilder.AddForeignKey(
                name: "FK_TiposDeServicios_HojasDeServicio_HojaServicioId",
                table: "TiposDeServicios",
                column: "HojaServicioId",
                principalTable: "HojasDeServicio",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TiposDeServicios_HojasDeServicio_HojaServicioId",
                table: "TiposDeServicios");

            migrationBuilder.DropIndex(
                name: "IX_TiposDeServicios_HojaServicioId",
                table: "TiposDeServicios");

            migrationBuilder.DropColumn(
                name: "HojaServicioId",
                table: "TiposDeServicios");

            migrationBuilder.CreateTable(
                name: "Servicios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Texto = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HojaServicioServicios",
                columns: table => new
                {
                    HojasId = table.Column<int>(type: "int", nullable: false),
                    ServiciosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HojaServicioServicios", x => new { x.HojasId, x.ServiciosId });
                    table.ForeignKey(
                        name: "FK_HojaServicioServicios_HojasDeServicio_HojasId",
                        column: x => x.HojasId,
                        principalTable: "HojasDeServicio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HojaServicioServicios_Servicios_ServiciosId",
                        column: x => x.ServiciosId,
                        principalTable: "Servicios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HojaServicioServicios_ServiciosId",
                table: "HojaServicioServicios",
                column: "ServiciosId");
        }
    }
}
