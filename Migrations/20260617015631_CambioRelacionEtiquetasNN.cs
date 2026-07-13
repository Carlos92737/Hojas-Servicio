using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SistemaDeServicios.Migrations
{
    /// <inheritdoc />
    public partial class CambioRelacionEtiquetasNN : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HojasDeServicio_Etiquetas_EtiquetaId",
                table: "HojasDeServicio");

            migrationBuilder.DropIndex(
                name: "IX_HojasDeServicio_EtiquetaId",
                table: "HojasDeServicio");

            migrationBuilder.DropColumn(
                name: "EtiquetaId",
                table: "HojasDeServicio");

            migrationBuilder.CreateTable(
                name: "HojaServicioEtiqueta",
                columns: table => new
                {
                    EtiquetasId = table.Column<int>(type: "int", nullable: false),
                    HojasDeServicioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HojaServicioEtiqueta", x => new { x.EtiquetasId, x.HojasDeServicioId });
                    table.ForeignKey(
                        name: "FK_HojaServicioEtiqueta_Etiquetas_EtiquetasId",
                        column: x => x.EtiquetasId,
                        principalTable: "Etiquetas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HojaServicioEtiqueta_HojasDeServicio_HojasDeServicioId",
                        column: x => x.HojasDeServicioId,
                        principalTable: "HojasDeServicio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Etiquetas",
                columns: new[] { "Id", "Texto" },
                values: new object[,]
                {
                    { 1, "Cambio de toner" },
                    { 2, "Reconexión de impresora" },
                    { 3, "Instalación de impresora" },
                    { 4, "Reconexión de internet" },
                    { 5, "Asistencia técnica a PC" },
                    { 6, "Gestión de cuenta de correo" },
                    { 7, "Proceso de respaldo de información" },
                    { 8, "Instalación de antivirus" },
                    { 9, "Desinstalación de software" },
                    { 10, "Cableado estructurado" },
                    { 11, "Creación de cuenta de correo" },
                    { 12, "Instalación de impresora" },
                    { 13, "Configuración de impresora" },
                    { 14, "Inducción de uso de correos" },
                    { 15, "Inducción de uso de software" },
                    { 16, "Sustitución de hardware" },
                    { 17, "Limpieza de memoria RAM" },
                    { 18, "Inducción de uso de correos" },
                    { 19, "Inducción de uso de software" },
                    { 20, "Instalación de software" },
                    { 21, "Activación de licencia de software" },
                    { 22, "Instalación de Sistema Operativo" },
                    { 23, "Activación de licencia de Sistema Operativo" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_HojaServicioEtiqueta_HojasDeServicioId",
                table: "HojaServicioEtiqueta",
                column: "HojasDeServicioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HojaServicioEtiqueta");

            migrationBuilder.DeleteData(
                table: "Etiquetas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Etiquetas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Etiquetas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Etiquetas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Etiquetas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Etiquetas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Etiquetas",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Etiquetas",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Etiquetas",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Etiquetas",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Etiquetas",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Etiquetas",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Etiquetas",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Etiquetas",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Etiquetas",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Etiquetas",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Etiquetas",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Etiquetas",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Etiquetas",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Etiquetas",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Etiquetas",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Etiquetas",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Etiquetas",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.AddColumn<int>(
                name: "EtiquetaId",
                table: "HojasDeServicio",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_HojasDeServicio_EtiquetaId",
                table: "HojasDeServicio",
                column: "EtiquetaId");

            migrationBuilder.AddForeignKey(
                name: "FK_HojasDeServicio_Etiquetas_EtiquetaId",
                table: "HojasDeServicio",
                column: "EtiquetaId",
                principalTable: "Etiquetas",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
