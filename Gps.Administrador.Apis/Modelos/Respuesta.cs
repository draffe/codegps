using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gps.Administrador.Apis.Modelos
{
    public class Respuesta
    {
        public Respuesta(object Datos,bool error,int NumerodeError,string errorrespuesta = null)
        {
            this.Datos = Datos;
            this.Error = error;
            this.NumerodeError = NumerodeError;
            this.ErrorMensaje = errorrespuesta;
        }
        public object Datos { get; set; }
        public bool Error { get; set; }
        public int NumerodeError { get; set; }
        public string ErrorMensaje { get; }
    }
}
