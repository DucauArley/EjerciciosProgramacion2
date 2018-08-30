using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura;

            Console.WriteLine("Ingrese la altura de la piramide");
            altura = int.Parse(Console.ReadLine());

            for (int i = 1; i < altura * 2; i = i + 2)
            {

                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }

            Console.ReadKey();

        }
    }
}
