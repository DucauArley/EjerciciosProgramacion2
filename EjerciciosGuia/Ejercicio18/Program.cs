﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria;

namespace PruebaGeometria
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rectangulo1 = new Rectangulo( new Punto(4, 6), new Punto(7, 2));

            rectangulo1.Area();
            rectangulo1.Perimertro();

            rectangulo1.Mostrar();



            Console.ReadKey();

        }
    }
}
