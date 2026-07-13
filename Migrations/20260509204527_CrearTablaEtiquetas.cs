using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaDeServicios.Migrations
{
    /// <inheritdoc />
    public partial class CrearTablaEtiquetas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EtiquetaId",
                table: "HojasDeServicio",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Etiquetas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Texto = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etiquetas", x => x.Id);
                });

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
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HojasDeServicio_Etiquetas_EtiquetaId",
                table: "HojasDeServicio");

            migrationBuilder.DropTable(
                name: "Etiquetas");

            migrationBuilder.DropIndex(
                name: "IX_HojasDeServicio_EtiquetaId",
                table: "HojasDeServicio");

            migrationBuilder.DropColumn(
                name: "EtiquetaId",
                table: "HojasDeServicio");
        }
    }
}
