using Microsoft.EntityFrameworkCore.Migrations;

namespace Gps.BasedeDatos.Migrations
{
    public partial class MenuopcionesUsuarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuariosId",
                table: "MenuOpcionesUsuario",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UsuariosId",
                table: "MenuOpcionesUsuario");
        }
    }
}
