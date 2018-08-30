using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorHora;
            String nombre;
            int antiguedad;
            int cantHoras;
            int importeBruto;
            char seguir = 's';
            int importe;
            int dineroPorAño;
            int importeNeto;
            int descuento;


            while (seguir == 's')
            {
                Console.WriteLine("Ingrese su nombre");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el valor de las horas");
                valorHora = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la antiguedad");
                antiguedad = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la cantidad de horas trabajadas");
                cantHoras = int.Parse(Console.ReadLine());

                importe = valorHora * cantHoras;
                dineroPorAño = antiguedad * 150;
                importeBruto = importe + dineroPorAño;
                descuento = (importeBruto * 13) / 100;
                importeNeto = importeBruto - descuento;


                Console.WriteLine("Nombre: " + nombre);
                Console.WriteLine("Antiguedad: " + antiguedad);
                Console.WriteLine("Valor hora: " + valorHora);
                Console.WriteLine("Total a cobrar en bruto: " + importeBruto);
                Console.WriteLine("Total de descuento: " + descuento);
                Console.WriteLine("Valor neto a cobrar: " + importeNeto);


                Console.WriteLine("Desea seguir ingresando empleados? s/n");
                seguir = Console.ReadKey().KeyChar;
            }


            Console.ReadKey();

        }
    }
}
