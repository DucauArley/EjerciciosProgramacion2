using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio48
{
    class Program
    {
        static void Main(string[] args)
        {
            Recibo d1 = new Recibo(250);
            Factura d2 = new Factura(400);
            Contabilidad<Factura, Recibo> c = new Contabilidad<Factura, Recibo>();

            c += d2;
            c += d1;

            Console.Read();
        }
    }
}
