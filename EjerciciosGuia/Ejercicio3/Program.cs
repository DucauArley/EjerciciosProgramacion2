using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int contador;

            num = int.Parse(Console.ReadLine());

            for (int j = 1; j <= num; j++)
            {
                contador = 0;
                for (int i = 1; i <= num; i++)
                {
                    if (j % i == 0)
                    {
                        contador++;
                    }

                    if (contador == 3)
                    {
                        break;
                    }
                }

                if (contador == 2)
                {
                    Console.WriteLine(j);
                }
            }

            Console.ReadKey();


        }
    }
}
