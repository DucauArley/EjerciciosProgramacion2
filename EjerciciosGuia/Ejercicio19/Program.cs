using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador a = new Sumador(7);
            Sumador b = new Sumador(8);
            long numero;

            numero = a + b;

            if (a | b)
            {
                Console.WriteLine("El numero es: " + numero);
            }
            else
            {
                Console.WriteLine("No son iguales");
            }

            Console.ReadKey();
        }
    }
}
