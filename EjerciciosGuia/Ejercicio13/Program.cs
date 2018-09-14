using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero;
            string binario;
            double numeroSalida;
            string binarioSalida;

            Console.WriteLine("Ingrese un numero decimal");
            double.TryParse(Console.ReadLine(), out numero);

            Console.WriteLine("Ingrese un numero en binario");
            binario = Console.ReadLine();
            while (!Conversor.ValidarBinario(binario))
            {
                Console.WriteLine("No se ingreso un numero binario");
                binario = Console.ReadLine();
            }

            numeroSalida = Conversor.BinarioDecimal(binario);
            binarioSalida = Conversor.DecimalBinario(numero);

            Console.WriteLine("Numero binario pasado a decimal: " + numeroSalida);
            Console.WriteLine("Numero decimal pasado a binario: " + binarioSalida);

            Console.ReadKey();
        }
    }
}
