using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 1;
            int sumador;
            int perfectos = 0;

            do
            {
                sumador = 0;

                for (int i = numero - 1; i > 0; i--)
                {
                    if (numero % i == 0)
                    {
                        sumador = i + sumador;
                    }
                }

                if (sumador == numero)
                {
                    perfectos++;
                    Console.WriteLine(numero);
                }

                numero++;

            } while (perfectos < 4);

            Console.ReadKey();

        }
    }
}
