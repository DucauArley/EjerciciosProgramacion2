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

            Persona.Guardar(p);

            p2 = Persona.Leer("Persona.xml");

            Console.WriteLine(p2.ToString());

            Console.ReadLine();
        }
    }
}
