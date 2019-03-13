using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Gps.BasedeDatos.Modelos
{
    public class Notificacion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Guid { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime UpdateDate { get; set; }

        public Enumeraciones.TipodeNotificacion TipoNotificacion { get; set; }

        public string Destino { get; set; }

        public Enumeraciones.EstatusNotificacion EstatusNotificacion { get; set; }

        public int UsuariosId { get; set; }

        public int IdComun { get; set; }

    }
}
