using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Euro
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        private Euro()
        {
            cotizRespectoDolar = float.Parse("0,7330");
        }

        public Euro(double cantidad): this ()
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, float cotizacion): this(cantidad)
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
