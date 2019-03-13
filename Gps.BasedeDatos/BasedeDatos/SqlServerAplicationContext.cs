using Gps.BasedeDatos.Modelos;
using Gps.BasedeDatos.Relaciones;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gps.BasedeDatos.BasedeDatos
{
    public class SqlServerAplicationContext : DbContext
    {
        public SqlServerAplicationContext(DbContextOptions<SqlServerAplicationContext> option) : base(option)
        {

        }

        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<DireccionEmpresa> DireccionesEmpresas { get; set; }
        public DbSet<DireccionUsuarios> DireccionUsuarios { get; set; }
        public DbSet<Vehiculos> Vehiculos { get; set; }
        public DbSet<UltimaPosicion> UltimaPosicion { get; set; }
        public DbSet<Planes> Planes { get; set; }
        public DbSet<RelacionEmpresaPlanes> RelacionEmpresaPlanes { get; set; }
        public DbSet<Geocercas> Geocercas  { get;set;}
        public DbSet<PuntosGeocercas> PuntosGeocercas { get; set; }
        public DbSet<RelacionGeocercasVehiculos> RelacionGeocercasVehiculos { get; set; }
        public DbSet<Notificacion> Notificacion { get; set; }
        public DbSet<NotificacionVehiculo> NotificacionVehiculo { get; set; }
        public DbSet<Vistas> Vistas { get; set; }
        public DbSet<Facturas> Facturas { get; set; }
        public DbSet<DetalleFactura> DetalleFactura { get; set; }
        public DbSet<MenuOpciones> MenuOpciones { get; set; }
        public DbSet<MenuOpcionesUsuario> MenuOpcionesUsuario { get; set; }

    }
}
