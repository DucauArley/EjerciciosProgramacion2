using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio26
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vec = new int[20];
            Random ran = new Random();
            int numero = 0;

            for (int i = 0; i < vec.Length; i++)
            {
                vec[i] = ran.Next(int.MinValue, int.MaxValue);
            }

            for (int i = 0; i < vec.Length; i++)
            {
                Console.WriteLine(vec[i]);
            }

            for (int i = 0; i < vec.Length - 1; i++)
            {
                for (int j = i + 1; j < vec.Length; j++)
                {
                    if(vec[i] < vec[j])
                    {
                        numero = vec[i];
                        vec[i] = vec[j];
                        vec[j] = numero;
                    }
                }
            }


            Console.WriteLine("");
            Console.WriteLine("Numeros positivos");

            for (int i = 0; i < vec.Length; i++)
            {
                if(vec[i] > 0)
                {
                    Console.WriteLine(vec[i]);
                }
            }

            for (int i = 0; i < vec.Length - 1; i++)
            {
                for (int j = i + 1; j < vec.Length; j++)
                {
                    if (vec[i] < vec[j])
                    {
                        numero = vec[i];
                        vec[i] = vec[j];
                        vec[j] = numero;
                    }
                }
            }


            Console.WriteLine("");
            Console.WriteLine("Numeros Negativos");

            for (int i = 0; i < vec.Length; i++)
            {
                if (vec[i] < 0)
                {
                    Console.WriteLine(vec[i]);
                }
            }
            
            Console.ReadKey();
        }
    }
}
