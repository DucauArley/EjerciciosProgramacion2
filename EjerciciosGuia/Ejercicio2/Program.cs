using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            double cuadrado;
            double cubo;

            num = int.Parse(Console.ReadLine());

            while (num < 0)
            {
                Console.WriteLine("Error. ¡Reingresar numero!");
                num = int.Parse(Console.ReadLine());
            }

            cuadrado = Math.Pow(num, 2);
            cubo = Math.Pow(num, 3);

            Console.WriteLine("El cuadrado del numero es: " + cuadrado);
            Console.WriteLine("El cubo del numero es: " + cubo);

            Console.ReadKey();

        }
    }
}
