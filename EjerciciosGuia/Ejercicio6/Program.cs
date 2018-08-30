using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int año;
            String texto;


            Console.WriteLine("Ingrese un año");
            año = int.Parse(Console.ReadLine());

            if (año % 4 == 0)
            {
                if (año % 100 == 0 && año % 400 == 0)
                {
                    texto = "El año es bisiesto";
                }
                else
                {
                    texto = "El año no es bisiesto";
                }
            }
            else
            {
                texto = "El año no es bisisesto";
            }

            Console.WriteLine(texto);

            Console.ReadKey();

        }
    }
}
