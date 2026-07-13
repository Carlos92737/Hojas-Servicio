using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaDeServicios.Migrations
{
    /// <inheritdoc />
    public partial class AjusteEtiqueta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HojasDeServicio_Etiquetas_EtiquetaId",
                table: "HojasDeServicio");

            migrationBuilder.AlterColumn<int>(
                name: "EtiquetaId",
                table: "HojasDeServicio",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_HojasDeServicio_Etiquetas_EtiquetaId",
                table: "HojasDeServicio",
                column: "EtiquetaId",
                principalTable: "Etiquetas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HojasDeServicio_Etiquetas_EtiquetaId",
                table: "HojasDeServicio");

            migrationBuilder.AlterColumn<int>(
                name: "EtiquetaId",
                table: "HojasDeServicio",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_HojasDeServicio_Etiquetas_EtiquetaId",
                table: "HojasDeServicio",
                column: "EtiquetaId",
                principalTable: "Etiquetas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
