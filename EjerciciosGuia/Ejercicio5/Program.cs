using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int suma1 = 0;
            int suma2 = -1;

            Console.WriteLine("Ingrese un numero");
            numero = int.Parse(Console.ReadLine());


            for (int i = 1; i < numero; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    suma1 = j + suma1;
                }

                for (int k = i + 1; suma2 < suma1; k++)
                {
                    suma2 = k + suma2;
                }

                if (suma1 == suma2)
                {
                    Console.WriteLine("Entro " + i);
                }

                suma1 = 0;
                suma2 = 0;
            }

            Console.ReadKey();

        }
    }
}
