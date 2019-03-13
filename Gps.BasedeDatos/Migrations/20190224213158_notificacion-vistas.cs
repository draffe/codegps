using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

namespace Gps.BasedeDatos.Migrations
{
    public partial class notificacionvistas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Geocercas_Vehiculos_VehiculosId",
                table: "Geocercas");

            migrationBuilder.DropIndex(
                name: "IX_Geocercas_VehiculosId",
                table: "Geocercas");

            migrationBuilder.DropColumn(
                name: "VehiculosId",
                table: "Geocercas");

            migrationBuilder.AddColumn<decimal>(
                name: "MontoNotificaicon",
                table: "Planes",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<bool>(
                name: "NotificacionEntrada",
                table: "Geocercas",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "NotificacionSalida",
                table: "Geocercas",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Notificacion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    TipoNotificacion = table.Column<int>(nullable: false),
                    Destino = table.Column<string>(nullable: true),
                    EstatusNotificacion = table.Column<int>(nullable: false),
                    UsuariosId = table.Column<int>(nullable: false),
                    IdComun = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notificacion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notificacion_Usuarios_UsuariosId",
                        column: x => x.UsuariosId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NotificacionVehiculo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    IdNotificacion = table.Column<int>(nullable: false),
                    IdVehiculo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificacionVehiculo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vistas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    Punto = table.Column<Point>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    UsuarioId = table.Column<int>(nullable: false),
                    UsuariosId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vistas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vistas_Usuarios_UsuariosId",
                        column: x => x.UsuariosId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Geocercas_UsuariosId",
                table: "Geocercas",
                column: "UsuariosId");

            migrationBuilder.CreateIndex(
                name: "IX_Notificacion_UsuariosId",
                table: "Notificacion",
                column: "UsuariosId");

            migrationBuilder.CreateIndex(
                name: "IX_Vistas_UsuariosId",
                table: "Vistas",
                column: "UsuariosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Geocercas_Usuarios_UsuariosId",
                table: "Geocercas",
                column: "UsuariosId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Geocercas_Usuarios_UsuariosId",
                table: "Geocercas");

            migrationBuilder.DropTable(
                name: "Notificacion");

            migrationBuilder.DropTable(
                name: "NotificacionVehiculo");

            migrationBuilder.DropTable(
                name: "Vistas");

            migrationBuilder.DropIndex(
                name: "IX_Geocercas_UsuariosId",
                table: "Geocercas");

            migrationBuilder.DropColumn(
                name: "MontoNotificaicon",
                table: "Planes");

            migrationBuilder.DropColumn(
                name: "NotificacionEntrada",
                table: "Geocercas");

            migrationBuilder.DropColumn(
                name: "NotificacionSalida",
                table: "Geocercas");

            migrationBuilder.AddColumn<int>(
                name: "VehiculosId",
                table: "Geocercas",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Geocercas_VehiculosId",
                table: "Geocercas",
                column: "VehiculosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Geocercas_Vehiculos_VehiculosId",
                table: "Geocercas",
                column: "VehiculosId",
                principalTable: "Vehiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
