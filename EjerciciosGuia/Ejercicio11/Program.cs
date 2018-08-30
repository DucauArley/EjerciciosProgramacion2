using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeros;
            int maximo = int.MinValue;
            int minimo = int.MaxValue;
            int sumaNumero = 0;
            int promedio;

            Console.WriteLine("Ingrese 10 numeros");

            for (int i = 0; i < 10; i++)
            {
                numeros = int.Parse(Console.ReadLine());

                while (!Validar.Validacion(numeros, -100, 100))
                {
                    Console.WriteLine("Reingrese el numero");
                    numeros = int.Parse(Console.ReadLine());
                }


                if (i == 0)
                {
                    maximo = numeros;
                    minimo = numeros;
                }
                else
                {
                    if (maximo < numeros)
                    {
                        maximo = numeros;
                    }
                    else
                    {
                        if (minimo > numeros)
                        {
                            minimo = numeros;
                        }
                    }
                }

                sumaNumero = numeros + sumaNumero;

            }


            promedio = sumaNumero / 10;

            Console.WriteLine("El numero maximo es: " + maximo);
            Console.WriteLine("El numero minimo es: " + minimo);
            Console.WriteLine("El promedio es: " + promedio);

            Console.ReadKey();

        }
    }
}
