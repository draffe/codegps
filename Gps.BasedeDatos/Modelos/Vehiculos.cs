using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Gps.BasedeDatos.Modelos
{
    public class Vehiculos
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Guid { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime UpdateDate { get; set; }

     
        public string CodigDisppositivo { get; set; }

        public string Nombre { get; set; }

        public int IdEmpresa { get; set; }

        public int DiferenciaHoraria { get; set; }

        public int IdUsuario { get; set; }

        public UltimaPosicion posicionReciente { get; set; }
 

    }
}
