using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio17;

namespace Boligrafos
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto; 

            Boligrafo lapicera1 = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo lapicera2 = new Boligrafo(50, ConsoleColor.Red);
            Boligrafo lapicera3 = new Boligrafo(3, ConsoleColor.Yellow);

            if(lapicera1.Pintar(24, out texto) == true)
            {
                Console.BackgroundColor = lapicera1.GetColor();
                Console.WriteLine(texto);
            }

            if (lapicera2.Pintar(40, out texto) == true)
            {
                Console.BackgroundColor = lapicera2.GetColor();
                Console.WriteLine(texto);
            }


            if (lapicera3.Pintar(4, out texto) == true)
            {
                Console.BackgroundColor = lapicera3.GetColor();
                Console.WriteLine(texto);
            }

            if (lapicera3.Pintar(100, out texto) == true)
            {
                Console.BackgroundColor = lapicera3.GetColor();
                Console.WriteLine(texto);
            }


            Console.ReadKey();
        }
    }
}
