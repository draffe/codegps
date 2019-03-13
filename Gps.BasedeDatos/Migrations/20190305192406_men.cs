using Microsoft.EntityFrameworkCore.Migrations;

namespace Gps.BasedeDatos.Migrations
{
    public partial class men : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuOpciones_MenuOpcionesUsuario_MenuOpcionesUsuarioId",
                table: "MenuOpciones");

            migrationBuilder.DropIndex(
                name: "IX_MenuOpciones_MenuOpcionesUsuarioId",
                table: "MenuOpciones");

            migrationBuilder.DropColumn(
                name: "MenuOpcionesUsuarioId",
                table: "MenuOpciones");

            migrationBuilder.RenameColumn(
                name: "UsuariosId",
                table: "MenuOpcionesUsuario",
                newName: "IdUsuarios");

            migrationBuilder.RenameColumn(
                name: "MenuOpcionesId",
                table: "MenuOpcionesUsuario",
                newName: "IdMenuOpciones");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdUsuarios",
                table: "MenuOpcionesUsuario",
                newName: "UsuariosId");

            migrationBuilder.RenameColumn(
                name: "IdMenuOpciones",
                table: "MenuOpcionesUsuario",
                newName: "MenuOpcionesId");

            migrationBuilder.AddColumn<int>(
                name: "MenuOpcionesUsuarioId",
                table: "MenuOpciones",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MenuOpciones_MenuOpcionesUsuarioId",
                table: "MenuOpciones",
                column: "MenuOpcionesUsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuOpciones_MenuOpcionesUsuario_MenuOpcionesUsuarioId",
                table: "MenuOpciones",
                column: "MenuOpcionesUsuarioId",
                principalTable: "MenuOpcionesUsuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
