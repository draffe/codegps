using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Gps.BasedeDatos.Modelos
{
    public class Usuarios
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Enumeraciones.TipoUsuarioEmpresa TipodeUsuarioEmpresa { get; set; }
        public Enumeraciones.TipoUsuarioMaestro TipodeUsuarioMaestro { get; set; }
        public Enumeraciones.TipoUsuarioCliente TipodeUsuarioCliente { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }

        public Enumeraciones.EstatusUsuarioCliente EstatusUsuarioFinal { get; set; }

        public int IdEmpresa { get; set; }

        public int UsuarioPrincipalID { get; set; }
        public DireccionUsuarios direccionUsuarios { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Guid { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime UpdateDate { get; set; }


        public IEnumerable<Geocercas> geocercas { get; set; }

        public IEnumerable<Notificacion> Notificacion { get; set; }

        public IEnumerable<Vistas> Vistas { get; set; }

    }
}
