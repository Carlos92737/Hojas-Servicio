using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SistemaDeServicios.Migrations
{
    /// <inheritdoc />
    public partial class SeedDireccionesYTipoServicio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Direcciones",
                columns: new[] { "Id", "NombreDir" },
                values: new object[,]
                {
                    { 1, "Despacho del Alcalde" },
                    { 2, "Dirección General" },
                    { 3, "Asuntos Públicos" },
                    { 4, "Atención al Ciudadano" },
                    { 5, "Prensa y Ciudadano" },
                    { 6, "Gestión Urbana" },
                    { 7, "Obras" },
                    { 8, "Servicios Generales" },
                    { 9, "Planeamiento Urbano" },
                    { 10, "Catastro" },
                    { 11, "Seguridad Ciudadana" },
                    { 12, "Protección Civil" },
                    { 13, "Gestión Social" },
                    { 14, "CMDNNA" },
                    { 15, "Administración y Finanzas" },
                    { 16, "Planificación de Presupuesto" },
                    { 17, "Recursos Humanos" },
                    { 18, "Administración Tributaria" },
                    { 19, "Tecnología y Sistemas" },
                    { 20, "Deportes" },
                    { 21, "IMASUR" },
                    { 22, "Registro Civil" },
                    { 23, "Tesorería Municipal" },
                    { 24, "Sindicatura Municipal" },
                    { 25, "Cultura" },
                    { 26, "Instituto Municipal de la Vivienda" },
                    { 27, "Consultoría Jurídica" },
                    { 28, "Cámara Municipal" }
                });

            migrationBuilder.InsertData(
                table: "TiposDeServicios",
                columns: new[] { "Id", "Recurrente", "Texto" },
                values: new object[,]
                {
                    { 1, true, "Mantenimiento de Impresora" },
                    { 2, true, "Formateo de Equipo" },
                    { 3, true, "Mantenimiento preventivo y/o correctivo" },
                    { 4, true, "Instalación y Actualización de Software" },
                    { 5, true, "Instalación y/o Configuración de Impresora" },
                    { 6, true, "Instalación de Dispositivos Internos del CPU" },
                    { 7, true, "Configuración del Sistema Operativo" },
                    { 8, true, "Respaldo de Información" },
                    { 9, true, "Configuración de Red" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Direcciones",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Direcciones",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Direcciones",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Direcciones",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Direcciones",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Direcciones",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Direcciones",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Direcciones",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Direcciones",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Direcciones",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Direcciones",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Direcciones",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Direcciones",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Direcciones",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Direcciones",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Direcciones",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Direcciones",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Direcciones",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Direcciones",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Direcciones",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Direcciones",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Direcciones",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Direcciones",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Direcciones",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Direcciones",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Direcciones",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Direcciones",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Direcciones",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "TiposDeServicios",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TiposDeServicios",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TiposDeServicios",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TiposDeServicios",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TiposDeServicios",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TiposDeServicios",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TiposDeServicios",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TiposDeServicios",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TiposDeServicios",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
