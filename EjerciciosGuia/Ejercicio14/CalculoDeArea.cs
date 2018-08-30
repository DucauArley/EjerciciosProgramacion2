using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)
        {
            double respuesta;

            respuesta = lado * lado;

            return respuesta;
        }

        public static double CalcularTriangulo(double largo, double altura)
        {
            double respuesta;

            respuesta = (largo * altura) / 2;

            return respuesta;
        }

        public static double CalcularCirculo(double radio)
        {
            double resultado;

            resultado = Math.Pow(radio, 2) * 3.14;

            return resultado;
        }

    }
}
