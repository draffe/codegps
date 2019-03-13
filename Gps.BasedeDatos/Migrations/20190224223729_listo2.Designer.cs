﻿// <auto-generated />
using System;
using Gps.BasedeDatos.BasedeDatos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetTopologySuite.Geometries;

namespace Gps.BasedeDatos.Migrations
{
    [DbContext(typeof(SqlServerAplicationContext))]
    [Migration("20190224223729_listo2")]
    partial class listo2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Gps.BasedeDatos.Modelos.DetalleFactura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FacturasId");

                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("NumerodeVehiculos");

                    b.Property<int>("Plan");

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.HasIndex("FacturasId");

                    b.ToTable("DetalleFactura");
                });

            modelBuilder.Entity("Gps.BasedeDatos.Modelos.DireccionEmpresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApptoCasa");

                    b.Property<string>("CodigoPostal");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Direccion");

                    b.Property<int>("DireccionEmpresaId");

                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Pais");

                    b.Property<string>("Region");

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("DireccionesEmpresas");
                });

            modelBuilder.Entity("Gps.BasedeDatos.Modelos.DireccionUsuarios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApptoCasa");

                    b.Property<string>("CodigoPostal");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Direccion");

                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Pais");

                    b.Property<string>("Region");

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("UsuariosId");

                    b.HasKey("Id");

                    b.HasIndex("UsuariosId")
                        .IsUnique();

                    b.ToTable("DireccionUsuarios");
                });

            modelBuilder.Entity("Gps.BasedeDatos.Modelos.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DiferenciaHoraria");

                    b.Property<string>("Documento");

                    b.Property<string>("Email");

                    b.Property<int>("EmpresaPadreID");

                    b.Property<int>("EstatusEmpresa");

                    b.Property<int>("EstatusVentas");

                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Imagen");

                    b.Property<string>("Nombre");

                    b.Property<string>("PaginaWeb");

                    b.Property<bool>("Principal");

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("direccionEmpresaId");

                    b.HasKey("Id");

                    b.HasIndex("direccionEmpresaId");

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("Gps.BasedeDatos.Modelos.Facturas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EmpresaId");

                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Impuesto");

                    b.Property<DateTime>("PeriodoFin");

                    b.Property<DateTime>("PeriodoInicio");

                    b.Property<decimal>("SubTotal");

                    b.Property<decimal>("Total");

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("Facturas");
                });

            modelBuilder.Entity("Gps.BasedeDatos.Modelos.Geocercas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre");

                    b.Property<bool>("NotificacionEntrada");

                    b.Property<bool>("NotificacionSalida");

                    b.Property<int>("Tipo");

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("UsuariosId");

                    b.HasKey("Id");

                    b.HasIndex("UsuariosId");

                    b.ToTable("Geocercas");
                });

            modelBuilder.Entity("Gps.BasedeDatos.Modelos.Notificacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Destino");

                    b.Property<int>("EstatusNotificacion");

                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IdComun");

                    b.Property<int>("TipoNotificacion");

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("UsuariosId");

                    b.HasKey("Id");

                    b.HasIndex("UsuariosId");

                    b.ToTable("Notificacion");
                });

            modelBuilder.Entity("Gps.BasedeDatos.Modelos.Planes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CantidadVehiculos");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("FechaFin");

                    b.Property<DateTime?>("FechaInicio");

                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IdUsuarioCreador");

                    b.Property<decimal>("MontoNotificaicon");

                    b.Property<decimal>("MontoPorVehiculo");

                    b.Property<string>("Nombre");

                    b.Property<bool>("TodaslasEmpresas");

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("Planes");
                });

            modelBuilder.Entity("Gps.BasedeDatos.Modelos.PuntosGeocercas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("GeocercasId");

                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd();

                    b.Property<Point>("Location");

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.HasIndex("GeocercasId");

                    b.ToTable("PuntosGeocercas");
                });

            modelBuilder.Entity("Gps.BasedeDatos.Modelos.UltimaPosicion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Altura");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Direccion");

                    b.Property<DateTime?>("FechaPosicion");

                    b.Property<float>("Grados");

                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd();

                    b.Property<Point>("Location");

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("VehiculosId");

                    b.HasKey("Id");

                    b.HasIndex("VehiculosId")
                        .IsUnique();

                    b.ToTable("UltimaPosicion");
                });

            modelBuilder.Entity("Gps.BasedeDatos.Modelos.Usuarios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido");

                    b.Property<string>("Contrasena");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EstatusUsuarioFinal");

                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IdEmpresa");

                    b.Property<string>("Nombre");

                    b.Property<string>("NombreUsuario");

                    b.Property<int>("TipodeUsuarioCliente");

                    b.Property<int>("TipodeUsuarioEmpresa");

                    b.Property<int>("TipodeUsuarioMaestro");

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("UsuarioPrincipalID");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Gps.BasedeDatos.Modelos.Vehiculos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodigDisppositivo");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DiferenciaHoraria");

                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IdEmpresa");

                    b.Property<int>("IdUsuario");

                    b.Property<string>("Nombre");

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("Vehiculos");
                });

            modelBuilder.Entity("Gps.BasedeDatos.Modelos.Vistas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre");

                    b.Property<Point>("Punto");

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("UsuarioId");

                    b.Property<int?>("UsuariosId");

                    b.HasKey("Id");

                    b.HasIndex("UsuariosId");

                    b.ToTable("Vistas");
                });

            modelBuilder.Entity("Gps.BasedeDatos.Relaciones.NotificacionVehiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IdNotificacion");

                    b.Property<int>("IdVehiculo");

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("NotificacionVehiculo");
                });

            modelBuilder.Entity("Gps.BasedeDatos.Relaciones.RelacionEmpresaPlanes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EmpresasId");

                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PlanesId");

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("RelacionEmpresaPlanes");
                });

            modelBuilder.Entity("Gps.BasedeDatos.Relaciones.RelacionGeocercasVehiculos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IdGeocerca");

                    b.Property<int>("IdVehiculo");

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("RelacionGeocercasVehiculos");
                });

            modelBuilder.Entity("Gps.BasedeDatos.Modelos.DetalleFactura", b =>
                {
                    b.HasOne("Gps.BasedeDatos.Modelos.Facturas")
                        .WithMany("DetallesFactura")
                        .HasForeignKey("FacturasId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Gps.BasedeDatos.Modelos.DireccionUsuarios", b =>
                {
                    b.HasOne("Gps.BasedeDatos.Modelos.Usuarios")
                        .WithOne("direccionUsuarios")
                        .HasForeignKey("Gps.BasedeDatos.Modelos.DireccionUsuarios", "UsuariosId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Gps.BasedeDatos.Modelos.Empresa", b =>
                {
                    b.HasOne("Gps.BasedeDatos.Modelos.DireccionEmpresa", "direccionEmpresa")
                        .WithMany()
                        .HasForeignKey("direccionEmpresaId");
                });

            modelBuilder.Entity("Gps.BasedeDatos.Modelos.Geocercas", b =>
                {
                    b.HasOne("Gps.BasedeDatos.Modelos.Usuarios")
                        .WithMany("geocercas")
                        .HasForeignKey("UsuariosId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Gps.BasedeDatos.Modelos.Notificacion", b =>
                {
                    b.HasOne("Gps.BasedeDatos.Modelos.Usuarios")
                        .WithMany("Notificacion")
                        .HasForeignKey("UsuariosId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Gps.BasedeDatos.Modelos.PuntosGeocercas", b =>
                {
                    b.HasOne("Gps.BasedeDatos.Modelos.Geocercas")
                        .WithMany("puntosGeocercas")
                        .HasForeignKey("GeocercasId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Gps.BasedeDatos.Modelos.UltimaPosicion", b =>
                {
                    b.HasOne("Gps.BasedeDatos.Modelos.Vehiculos")
                        .WithOne("posicionReciente")
                        .HasForeignKey("Gps.BasedeDatos.Modelos.UltimaPosicion", "VehiculosId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Gps.BasedeDatos.Modelos.Vistas", b =>
                {
                    b.HasOne("Gps.BasedeDatos.Modelos.Usuarios")
                        .WithMany("Vistas")
                        .HasForeignKey("UsuariosId");
                });
#pragma warning restore 612, 618
        }
    }
}
