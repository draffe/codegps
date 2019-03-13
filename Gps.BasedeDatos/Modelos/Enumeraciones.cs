using System;
using System.Collections.Generic;
using System.Text;

namespace Gps.BasedeDatos.Modelos
{
    public class Enumeraciones
    {
        public enum EstatusNotificacion
        {
            Activa,
            Desactivada
        }
        public enum TipodeNotificacion
        {
            Geocerca,
            EventoVehiculo,
        }

        public enum TipodeGeocerca
        {
             Polygono,
             Circulo
        }

        public enum TipoUsuarioMaestro
        {
            Maestro,
            Administrador,
            Monitoreo,
            Ventas,
            NA
        }

        public enum TipoUsuarioEmpresa
        {
            Maestro,
            Administrador,
            Monitoreo,
            Ventas,
            NA
        }
        public enum TipoUsuarioCliente
        {
            Principal,
            SubUsuario,
            NA
        }

        public enum EstatusEmpresa
        {
            Aderida,
            Activa,
            Desactivada
        }

        public enum EstatusEmpresaVentas
        {

            Activa,
            Desactivada
        }

        public enum EstatusUsuarioCliente
        {
            Activo,
            Desactivado,
            DesactivadoPorEmpresa,
            DesactivadoMaestro,
            Eliminado
        }
    }
}
