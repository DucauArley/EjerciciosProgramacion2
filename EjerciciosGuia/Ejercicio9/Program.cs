using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura;

            Console.WriteLine("Ingrese la altura de la piramide");
            if (int.TryParse(Console.ReadLine(), out altura))
            {
                for (int i = 1; i < altura * 2; i = i + 2)
                {

                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine("");
                }
            }
            else
            {
                Console.WriteLine("Ingrese un numero");
            }

            Console.ReadKey();


        }
    }
}
