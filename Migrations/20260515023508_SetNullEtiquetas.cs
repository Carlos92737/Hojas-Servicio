using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaDeServicios.Migrations
{
    /// <inheritdoc />
    public partial class SetNullEtiquetas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HojasDeServicio_Etiquetas_EtiquetaId",
                table: "HojasDeServicio");

            migrationBuilder.AddForeignKey(
                name: "FK_HojasDeServicio_Etiquetas_EtiquetaId",
                table: "HojasDeServicio",
                column: "EtiquetaId",
                principalTable: "Etiquetas",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HojasDeServicio_Etiquetas_EtiquetaId",
                table: "HojasDeServicio");

            migrationBuilder.AddForeignKey(
                name: "FK_HojasDeServicio_Etiquetas_EtiquetaId",
                table: "HojasDeServicio",
                column: "EtiquetaId",
                principalTable: "Etiquetas",
                principalColumn: "Id");
        }
    }
}
