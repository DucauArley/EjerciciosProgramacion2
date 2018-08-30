using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            double numeroUno;
            double numeroDos;
            char operacion;
            double resultado;
            bool ok;

            Console.WriteLine("Ingrese el primer numero");
            numeroUno = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero");
            numeroDos = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el signo de la operacion que desea efectuar");

            ok = char.TryParse(Console.ReadLine(), out operacion);

            while (ok == false || operacion != '+' && operacion != '-' && operacion != '*' && operacion != '/')
            {
                Console.WriteLine("No ingreso un simbolo valido");
                ok = char.TryParse(Console.ReadLine(), out operacion);
            }

            resultado = Calculadora.Calcular(numeroUno, numeroDos, operacion);

            if (numeroDos != 0 && operacion != '/')
            {
                Calculadora.Mostrar(resultado);
            }

            Console.ReadKey();

        }
    }
}
