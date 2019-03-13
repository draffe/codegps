using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gps.BasedeDatos.Migrations
{
    public partial class Menuopciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MenuOpcionesUsuario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Guid = table.Column<Guid>(nullable: false),
                    MenuOpcionesId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuOpcionesUsuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuOpciones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Guid = table.Column<Guid>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    EsPrincipal = table.Column<bool>(nullable: false),
                    MenuOpcionPadre = table.Column<int>(nullable: false),
                    MenuOpcionesUsuarioId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuOpciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuOpciones_MenuOpcionesUsuario_MenuOpcionesUsuarioId",
                        column: x => x.MenuOpcionesUsuarioId,
                        principalTable: "MenuOpcionesUsuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MenuOpciones_MenuOpcionesUsuarioId",
                table: "MenuOpciones",
                column: "MenuOpcionesUsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuOpciones");

            migrationBuilder.DropTable(
                name: "MenuOpcionesUsuario");
        }
    }
}
