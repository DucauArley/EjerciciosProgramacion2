using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            Kelvin kel = new Kelvin(255.9277);
            Celsius cel = new Celsius(-17.2222);
            Fahrenheit fahr = new Fahrenheit(1);
            

            if(fahr == kel)
            {
                Console.WriteLine("Entro");
            }


            Console.ReadKey();
        }
    }
}
