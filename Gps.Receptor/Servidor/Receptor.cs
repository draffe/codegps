using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Gps.Receptor.Servidor
{
    public class Receptor:IReceptor
    {
        private TcpClient _cliente;

        public Thread Hilo { get; internal set; }

        public Receptor(TcpClient cliente)
        {
            this._cliente = cliente;
        }

        public void Recibir()
        {
            string message = "";
            try
            {
                while (message != null)
                {
                    EnviarMensaje("asdasd");
                    byte[] buffer = new byte[1024];
                    _cliente.GetStream().Read(buffer, 0, buffer.Length);

                    message = Encoding.UTF8.GetString(buffer);
                    message = message.Replace("\0", string.Empty);
                     
                }
                Console.WriteLine("Closing connection.");
                _cliente.GetStream().Dispose();
            }
            catch (Exception)
            {
                if (_cliente.Connected)
                {
                    Desconectar();
                }
            }
            finally
            {
                if (_cliente.Connected)
                {
                    Desconectar();
                }
                try
                {
                    Desconectar();
                }
                catch (Exception)
                {
                }
                  
            }
            _cliente.Dispose();
            _cliente = null;
            Hilo = null;
        }


        public void EnviarMensaje(string Mensaje)
        {
            byte[] data = Encoding.ASCII.GetBytes(Mensaje);
            _cliente.GetStream().Write(data, 0, data.Length);

        }

        public void Desconectar()
        {
            try
            {
                _cliente.EndConnect(new Enresult());
            }catch(Exception)
            {

            }
        }

        private class Enresult : IAsyncResult
        {
            public object AsyncState => throw new NotImplementedException();

            public WaitHandle AsyncWaitHandle => throw new NotImplementedException();

            public bool CompletedSynchronously => throw new NotImplementedException();

            public bool IsCompleted => throw new NotImplementedException();
        }
    }




}
