using System;
using System.Collections.Generic;
using System.Text;

namespace Gps.Receptor.Servidor
{
    interface IReceptor
    {
        void Recibir();
        void EnviarMensaje(string Mensaje);
        void Desconectar();

    }
}
