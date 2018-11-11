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
            n.Clientes.Add("Juan Perez");
            n.Clientes.Add("Mariano Burgos");
            n.Clientes.Add("Mauricio Cerizza");
            n.Clientes.Add("Daniel Apellido");
            n.Clientes.Add("Federico Dávila");

            n.Clientes.Add("Juan Perez");
            n.Clientes.Add("Mariano Burgos");
            n.Clientes.Add("Mauricio Cerizza");
            n.Clientes.Add("Daniel Apellido");
            n.Clientes.Add("Federico Dávila");

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

            Console.WriteLine("Todos los clientes han sido atendidos, presione una tecla");
            Console.ReadKey();
        }
    }
}
