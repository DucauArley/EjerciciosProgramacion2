using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio34
{
    class Program
    {
        static void Main(string[] args)
        {
            Camion cam = new Camion(6, 2, VehiculoTerrestre.Colores.gris, 10, 50000);
            Automovil auto = new Automovil(4, 4, VehiculoTerrestre.Colores.azul, 5, 5);
            Moto moto = new Moto(2, 0, VehiculoTerrestre.Colores.rojo, 120);
            
            Console.ReadKey();
        }
    }
}
