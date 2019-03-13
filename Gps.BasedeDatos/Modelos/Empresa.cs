using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Gps.BasedeDatos.Modelos
{
    public class Empresa
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Documento { get; set; }
        public string Imagen { get; set; }
        public bool Principal { get; set; }
        public int EmpresaPadreID { get; set; }
        public string Email { get; set; }
        public string PaginaWeb { get; set; }

        public Enumeraciones.EstatusEmpresa EstatusEmpresa{ get; set; }
        public Enumeraciones.EstatusEmpresaVentas EstatusVentas { get; set; }
        public int DiferenciaHoraria { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Guid { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime UpdateDate { get; set; }

        public DireccionEmpresa direccionEmpresa { get; set; }

         
    }
}
