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
            Euro euro = new Euro(0.733);

            Console.WriteLine("La cantidad de dolares es: " + dolar.GetCantidad());
            Console.WriteLine("La cantidad de pesos es: " + peso.GetCantidad());

            dolar = (Dolar)(euro + peso);
            
            if (euro == peso)
            {
                Console.WriteLine("La cantidad de dolares es: " + dolar.GetCantidad());
            }

            Console.ReadKey();
        }
    }
}
