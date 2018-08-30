using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            double bases;
            double altura;
            double lado;
            double radio;

            Console.WriteLine("Ingrese la base");
            bases = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la altura");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el largo del lado");
            lado = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el radio");
            radio = double.Parse(Console.ReadLine());

            Console.WriteLine("Area de cuadrado " + CalculoDeArea.CalcularCuadrado(lado));
            Console.WriteLine("Area de triangulo " + CalculoDeArea.CalcularTriangulo(bases, altura));
            Console.WriteLine("Area de circulo " + CalculoDeArea.CalcularCirculo(radio));

            Console.ReadKey();
        }
    }
}
