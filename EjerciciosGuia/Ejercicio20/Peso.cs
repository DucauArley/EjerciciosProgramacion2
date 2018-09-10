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
            cotizRespectoDolar = 17.55F;
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

            cantidad = Math.Round(cantidad, 4);

            return cantidad;
        }

        public static float GetCotizacion()
        {
            float cotizacion;

            cotizacion = cotizRespectoDolar;

            return cotizacion;
        }

        public static explicit operator Euro(Peso peso)
        {
            Euro euro = new Euro((peso.GetCantidad() / Peso.GetCotizacion())  * Euro.GetCotizacion());

            return euro;
        }

        public static explicit operator Dolar(Peso peso)
        {
            Dolar dolar = new Dolar(peso.GetCantidad() / Peso.GetCotizacion());

            return dolar;
        }

        public static implicit operator Peso(double cantidad)
        {
            Peso peso = new Peso(cantidad);

            return peso;
        }

        public static bool operator ==(Peso p, Euro e)
        {
            bool ok = false;

            if (((Euro)p).GetCantidad() == e.GetCantidad())
            {
                ok = true;
            }

            return ok;
        }

        public static bool operator ==(Peso p, Dolar d)
        {
            bool ok = false;

            if (((Dolar)p).GetCantidad() == d.GetCantidad())
            {
                ok = true;
            }

            return ok;
        }

        public static bool operator ==(Peso p1, Peso p2)
        {
            bool ok = false;

            if (p1.GetCantidad() == p2.GetCantidad())
            {
                ok = true;
            }

            return ok;
        }

        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p1 == p2);
        }


        public static bool operator !=(Peso p, Dolar d)
        {
            return !(p == d);
        }


        public static bool operator !=(Peso p, Euro e)
        {
            return !(p == e);
        }

        public static Peso operator +(Peso p, Euro e)
        {
            Peso peso = new Peso(p.GetCantidad() + ((Peso)e).GetCantidad());

            return peso;
        }

        public static Peso operator +(Peso p, Dolar d)
        {
            Peso peso = new Peso(p.GetCantidad() + ((Peso)d).GetCantidad());

            return peso;
        }

        public static Peso operator -(Peso p, Euro e)
        {
            Peso peso = new Peso(p.GetCantidad() - ((Peso)e).GetCantidad());

            return peso;
        }

        public static Peso operator -(Peso p, Dolar d)
        {
            Peso peso = new Peso(p.GetCantidad() - ((Peso)d).GetCantidad());

            return peso;
        }


    }
}
