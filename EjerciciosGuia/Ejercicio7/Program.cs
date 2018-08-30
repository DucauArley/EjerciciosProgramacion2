using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia;
            int mes;
            int año;
            DateTime fechaActual = DateTime.Now;
            int cantDias;

            Console.WriteLine("Ingrese su fecha de nacimiento. Ej 23/10/1980");
            dia = int.Parse(Console.ReadLine());
            mes = int.Parse(Console.ReadLine());
            año = int.Parse(Console.ReadLine());

            DateTime fecha = new DateTime(año, mes, dia);

            cantDias = (int)(fechaActual - fecha).TotalDays;

            Console.WriteLine("La cantidad de dias vividos es: " + cantDias);



            Console.ReadKey();

        }
    }
}
