using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno();
            Alumno alumno2 = new Alumno();
            Alumno alumno3 = new Alumno();

            alumno1.nombre = "Carlos";
            alumno1.apellido = "Suarez";
            alumno1.legajo = 2324;
            
            alumno2.nombre = "Maria";
            alumno2.apellido = "Gomez";
            alumno2.legajo = 3452;

            alumno3.nombre = "Roberto";
            alumno3.apellido = "Diaz";
            alumno3.legajo = 6342;
            
            alumno1.Estudiar(2, 8);
            alumno2.Estudiar(10, 7);
            alumno3.Estudiar(4, 4);

            alumno1.CalcularFinal();
            alumno2.CalcularFinal();
            alumno3.CalcularFinal();

            Console.WriteLine(alumno1.Mostrar());
            Console.WriteLine(alumno2.Mostrar());
            Console.WriteLine(alumno3.Mostrar());

            Console.ReadKey();
        }
    }
}
