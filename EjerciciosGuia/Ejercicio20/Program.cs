using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;


namespace Ejercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            Peso peso = new Peso(17.55);
            Dolar dolar = new Dolar(1);

            dolar = dolar + peso;

            Console.WriteLine("La cantidad de dolares es: " + dolar.GetCantidad());

            Console.ReadKey();
        }
    }
}
