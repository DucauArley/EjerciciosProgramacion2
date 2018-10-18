using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio43
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia c1 = new Competencia(15, 3, Competencia.TipoCompetencia.MotoCross);
            AutoF1 a1 = new AutoF1(1, "Mercedes");
            AutoF1 a2 = new AutoF1(2, "Ferrari");
            AutoF1 a3 = new AutoF1(3, "RedBull");
            MotoCross m1 = new MotoCross(4, "escuderia");

            Console.ReadKey();

            try
            {
                if (c1 + m1)
                {
                    Console.WriteLine(c1.MostrarDatos());
                }
            }
            catch (CompetenciaNoDisponibleExcepcion e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.ReadKey();

            try
            {
                if (c1 + a2)
                {
                    Console.WriteLine(c1.MostrarDatos());
                }
            }
            catch (CompetenciaNoDisponibleExcepcion e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.ReadKey();
            
        }
    }
}
