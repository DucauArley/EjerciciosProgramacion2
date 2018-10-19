using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio47
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoBasquet> t1 = new Torneo<EquipoBasquet>("NBA");
            Torneo<EquipoFutbol> t2 = new Torneo<EquipoFutbol>("Libertadores");
            EquipoBasquet lakers = new EquipoBasquet("Lakers", DateTime.Now);
            EquipoBasquet spurs = new EquipoBasquet("Spurs", DateTime.Now);
            EquipoBasquet miamiHeats = new EquipoBasquet("Miami Heats", DateTime.Now);
            EquipoFutbol river = new EquipoFutbol("River", DateTime.Now);
            EquipoFutbol boca = new EquipoFutbol("Boca", DateTime.Now);
            EquipoFutbol independiente = new EquipoFutbol("Independiente", DateTime.Now);

            t1 += lakers;
            t1 += spurs;
            t1 += miamiHeats;

            t2 += river;
            t2 += boca;
            t2 += independiente;

            Console.WriteLine(t1.Mostrar());

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(t1.JugarPartido);
                Thread.Sleep(200);
            }


            Console.WriteLine(t2.Mostrar());
            
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(t2.JugarPartido);
                Thread.Sleep(200);
            }
            

            Console.ReadKey();
        }
    }
}
