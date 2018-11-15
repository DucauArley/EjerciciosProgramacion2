using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio64
{
    class Program
    {
        static void Main(string[] args)
        {
            Caja c1 = new Caja();
            Caja c2 = new Caja();
            Negocio n = new Negocio(c1, c2);
            n.Clientes.Add("Arley Ducau");
            n.Clientes.Add("Roman Pellitta");
            n.Clientes.Add("Andres Centurion");
            n.Clientes.Add("Federico Alaniz");
            n.Clientes.Add("Lautaro Medeiros");

            n.Clientes.Add("Arley Ducau");
            n.Clientes.Add("Roman Pellitta");
            n.Clientes.Add("Andres Centurion");
            n.Clientes.Add("Federico Alaniz");
            n.Clientes.Add("Lautaro Medeiros");

            Thread t1 = new Thread(n.AsignarCaja);

            Thread t2 = new Thread(c1.AtenderClientes);
            t2.Name = "Caja 1";

            Thread t3 = new Thread(c2.AtenderClientes);
            t3.Name = "Caja 2";

            t1.Start();
            t1.Join();
            t2.Start();
            t3.Start();
            t2.Join();
            t3.Join();
            t1.Abort();
            t2.Abort();
            t3.Abort();

            Console.WriteLine("Todos los clientes han sido atendidos, presione una tecla");
            Console.ReadKey();
        }
    }
}
