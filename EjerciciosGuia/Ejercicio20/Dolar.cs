using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Dolar
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        private Dolar()
        {
            cotizRespectoDolar = 1;
        }

        public Dolar(double cantidad): this()
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, float cotizacion): this(cantidad)
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

        public static explicit operator Euro(Dolar dolar)
        {
            Euro euro = new Euro(dolar.GetCantidad() / Euro.GetCotizacion());

            return euro;
        }

        public static explicit operator Peso(Dolar dolar)
        {
            Peso peso = new Peso(dolar.GetCantidad() * Peso.GetCotizacion());

            return peso;
        }

        public static implicit operator Dolar(double cantidad)
        {
            Dolar dolar = new Dolar(cantidad);

            return dolar; 
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            bool ok = false;

            if(((Euro) d).GetCantidad() == e.GetCantidad())
            {
                ok = true;
            }
            
            return ok;
        }

        public static bool operator ==(Dolar d, Peso p)
        {
            bool ok = false;

            if(((Peso) d).GetCantidad() == p.GetCantidad())
            {
                ok = true;
            }

            return ok;
        }

        public static bool operator ==(Dolar d1, Dolar d2)
        {
            bool ok = false;

            if(d1.GetCantidad() == d2.GetCantidad())
            {
                ok = true;
            }

            return ok;
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }


        public static bool operator !=(Dolar d, Peso p)
        {
            return !(d == p);
        }


        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            Dolar dolar = new Dolar(d.GetCantidad() + ((Dolar)e).GetCantidad());

            return dolar;
        }

        public static Dolar operator +(Dolar d, Peso p)
        {
            Dolar dolar = new Dolar(d.GetCantidad() + ((Dolar) p).GetCantidad());

            return dolar;
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            Dolar dolar = new Dolar(d.GetCantidad() - ((Dolar) e).GetCantidad());

            return dolar;
        }

        public static Dolar operator -(Dolar d, Peso p)
        {
            Dolar dolar = new Dolar(d.GetCantidad() - ((Dolar)p).GetCantidad());

            return dolar;
        }



    }
}
