using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Gps.BasedeDatos.Modelos
{
    public class MenuOpciones
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Guid { get; set; }

        public string Nombre { get; set; }

        public bool EsPrincipal { get; set; }

        public int MenuOpcionPadre { get; set; }

        public bool EsOpcionMaestra { get; set; }
       

    }
}
