using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Gps.BasedeDatos.Modelos
{
    public class Geocercas
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Guid { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime UpdateDate { get; set; }

        public string Nombre { get; set; }

        public Enumeraciones.TipodeGeocerca Tipo { get; set; }

        public int UsuariosId { get; set; }

        public IEnumerable<PuntosGeocercas> puntosGeocercas{ get; set; }

        public bool NotificacionEntrada { get; set; }
        public bool NotificacionSalida { get; set; }
    }
}
