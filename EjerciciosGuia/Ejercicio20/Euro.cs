using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        static Euro()
        {
            cotizRespectoDolar = 0.7330F;
        }

        public Euro(double cantidad)
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

            cantidad = Math.Round(cantidad, 4);

            return cantidad;
        }

        public static float GetCotizacion()
        {
            float cotizacion;

            cotizacion = cotizRespectoDolar;

            return cotizacion;
        }

        public static explicit operator Dolar(Euro euro)
        {
            Dolar dolar = new Dolar(euro.GetCantidad() / Euro.GetCotizacion());

            return dolar;
        }

        public static explicit operator Peso(Euro euro)
        {
            Peso peso = new Peso((euro.GetCantidad() / Euro.GetCotizacion()) * Peso.GetCotizacion());

            return peso;
        }

        public static implicit operator Euro(double cantidad)
        {
            Euro euro = new Euro(cantidad);

            return euro;
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            bool ok = false;

            if (((Dolar)e).GetCantidad() == d.GetCantidad())
            {
                ok = true;
            }

            return ok;
        }

        public static bool operator ==(Euro e, Peso p)
        {
            bool ok = false;

            if (((Peso)e).GetCantidad() == p.GetCantidad())
            {
                ok = true;
            }

            return ok;
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            bool ok = false;

            if (e1.GetCantidad() == e2.GetCantidad())
            {
                ok = true;
            }

            return ok;
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }


        public static bool operator !=(Euro e, Peso p)
        {
            return !(e == p);
        }


        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }


        public static Euro operator +(Euro e, Dolar d)
        {
            Euro euro = new Euro(e.GetCantidad() + ((Euro)d).GetCantidad());

            return euro;
        }

        public static Euro operator +(Euro e, Peso p)
        {
            Euro euro = new Euro(e.GetCantidad() + ((Euro)p).GetCantidad());

            return euro;
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            Euro euro = new Euro(e.GetCantidad() - ((Euro)d).GetCantidad());

            return euro;
        }

        public static Euro operator -(Euro e, Peso p)
        {
            Euro euro = new Euro(e.GetCantidad() - ((Euro)p).GetCantidad());

            return euro;
        }




    }
}
