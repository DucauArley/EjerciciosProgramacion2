using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Peso
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        private Peso()
        {
            cotizRespectoDolar = float.Parse("17.55");
        }

        public Peso(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public Peso(double cantidad, float cotizacion) : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }


        public double GetCantidad()
        {
            double cantidad;

            cantidad = this.cantidad;

            return cantidad;
        }

        public static float GetCotizacion()
        {
            float cotizacion;

            cotizacion = cotizRespectoDolar;

            return cotizacion;
        }

    }
}
