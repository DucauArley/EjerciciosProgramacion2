using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio51
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita c = new Centralita("Fede Center");
            // Mis 4 llamadas
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);
            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
            try
            {
                c += l1;
                Console.WriteLine(c.ToString());
            }
            catch (CentralitaExcepcion error)
            {
                Console.WriteLine(error.Message);
            }

            try
            {
                c += l2;
                Console.WriteLine(c.ToString());
            }
            catch (CentralitaExcepcion error)
            {
                Console.WriteLine(error.Message);
            }

            try
            {
                c += l3;
                Console.WriteLine(c.ToString());
            }
            catch (CentralitaExcepcion error)
            {
                Console.WriteLine(error.Message);
            }

            try
            {
                c += l4;
                Console.WriteLine(c.ToString());
            }
            catch (CentralitaExcepcion error)
            {
                Console.WriteLine(error.Message);
            }
            c.OrdenarLlamadas();
            Console.WriteLine(c.ToString());
            Console.ReadKey();
        }
    }
}
