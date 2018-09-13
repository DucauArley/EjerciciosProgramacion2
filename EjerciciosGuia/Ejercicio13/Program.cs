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
            double numero = 46;
            string binario = "10101010";

            numero = Conversor.BinarioDecimal(binario);

            Console.WriteLine(numero);

            Console.ReadKey();
        }
    }
}
