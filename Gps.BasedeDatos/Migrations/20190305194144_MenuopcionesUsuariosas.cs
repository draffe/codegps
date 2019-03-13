using Microsoft.EntityFrameworkCore.Migrations;

namespace Gps.BasedeDatos.Migrations
{
    public partial class MenuopcionesUsuariosas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "EsOpcionMaestra",
                table: "MenuOpciones",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EsOpcionMaestra",
                table: "MenuOpciones");
        }
    }
}
