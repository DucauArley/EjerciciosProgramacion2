﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio29
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador j1 = new Jugador(41856345, "Juan Carlos", 5, 2);

            Console.WriteLine(j1.MostrarDatos());


            Console.ReadKey();
        }
    }
}
