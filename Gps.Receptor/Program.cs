using System;
using Gps.Receptor.Servidor;
namespace Gps.Receptor
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Servidor.Servidor.StartServer(5678);
            Servidor.Servidor.Listen(); // Start listening.  
            Console.WriteLine("Hello World!");
        }
    }
}
