using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Gps.Receptor.Servidor
{
    public static class Servidor
    {
        private static TcpListener listener { get; set; }
        private static bool accept { get; set; } = false;

        public static void StartServer(int port)
        {
            IPAddress address = IPAddress.Parse("127.0.0.1");
            listener = new TcpListener(address, port);

            listener.Start();
            accept = true;

            Console.WriteLine($"Server started. Listening to TCP clients at 127.0.0.1:{port}");
        }

        public static void Listen()
        {
            if (listener != null && accept)
            {

                // Continue listening.  
                while (true)
                {
                    Console.WriteLine("Waiting for client...");
                    var clientTask = listener.AcceptTcpClientAsync(); // Get the client  

                    if (clientTask.Result != null)
                    {
                        Console.WriteLine("Client connected. Waiting for data.");
                        var client = clientTask.Result;
                        var Receptor = new Receptor(client);

                        Thread th = new Thread(new ThreadStart(Receptor.Recibir));
                        Receptor.Hilo = th;
                        th.Start();

                         
                    }
                }
            }
        }
    }
}
