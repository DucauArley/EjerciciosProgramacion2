using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio27
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            Random ran = new Random();

            for (int i = 0; i < 20; i++)
            {
                numeros.Add(ran.Next(int.MinValue, int.MaxValue));
            }

            for (int i = 0; i < numeros.Count; i++)
            {
                Console.WriteLine(numeros.ElementAt(i));
            }

            numeros.Sort();
            numeros.Reverse();

            Console.WriteLine();
            Console.WriteLine("Numeros positivos");

            for (int i = 0; i < numeros.Count; i++)
            {
                if (numeros.ElementAt(i) > 0)
                {
                    Console.WriteLine(numeros.ElementAt(i));
                }
            }

            numeros.Sort();

            Console.WriteLine();
            Console.WriteLine("Numeros negativos");

            for (int i = 0; i < numeros.Count; i++)
            {
                if(numeros.ElementAt(i) < 0)
                {
                    Console.WriteLine(numeros.ElementAt(i));
                }            
            }
            

            Console.ReadKey();
        }
    }
}
