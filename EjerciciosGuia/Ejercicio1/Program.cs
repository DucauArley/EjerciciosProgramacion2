using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int max = int.MaxValue;
            int min = int.MinValue;
            int promedio = 0;
            int sumaNumero = 0;



            for (int i = 0; i < 5; i++)
            {
                num = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    max = num;
                    min = num;
                }
                else
                {
                    if (num > max)
                    {
                        max = num;
                    }
                    else
                    {
                        if (num < min)
                        {
                            min = num;
                        }
                    }
                }

                sumaNumero = num + sumaNumero;
            }

            promedio = sumaNumero / 5;

            Console.WriteLine("Maximo " + max);
            Console.WriteLine("Minimo" + min);
            Console.WriteLine("Promedio " + promedio);

            Console.ReadKey();




        }
    }
}
