using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio57
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("Arley", "Ducau");
            Persona p2;

            try
            {
                Persona.Guardar(p);
            }
            catch (Exception)
            {
                Console.WriteLine("Excepciones en guardar");
            }

            try
            {
                p2 = Persona.Leer("Persona.bin");
                Console.WriteLine(p2.ToString());
            }
            catch (Exception)
            {
                Console.WriteLine("Excepciones en leer");
            }

            Console.ReadLine();
        }
    }
}
