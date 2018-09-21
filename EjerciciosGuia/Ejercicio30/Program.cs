using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoF1 auto = new AutoF1(32, "Ferrari");
            Competencia comp = new Competencia(1, 1);
            AutoF1 auto2 = new AutoF1(43, "Lamborghini");
            bool ok;

            ok = comp + auto;
            Console.WriteLine("OK: " + ok);
            ok = comp + auto2;
            Console.WriteLine("OK: " + ok);

            Console.WriteLine(comp.MostrarDatos());

            Console.ReadLine();
        }
    }
}
