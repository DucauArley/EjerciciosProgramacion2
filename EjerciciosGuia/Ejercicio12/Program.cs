using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroUno;
            int numeroDos;
            char seguir = 's';

            Console.WriteLine("Ingrese el primer numero a sumar");
            numeroUno = int.Parse(Console.ReadLine());

            while (ValidarRespuesta.ValidaS_N(seguir) == true)
            {
                Console.WriteLine("Ingrese otro numero a sumar");
                numeroDos = int.Parse(Console.ReadLine());

                numeroUno = numeroUno + numeroDos;

                Console.WriteLine("El total de la suma es: " + numeroUno);
                Console.WriteLine("Desea seguir ingresando mas numeros s/n");
                seguir = Console.ReadKey().KeyChar;
            }

            Console.ReadKey();

        }
    }
}
