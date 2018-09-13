using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio21
{
    class Kelvin
    {
        private double cantidad;
        private static float cambioFahrenheit;

        private Kelvin()
        {
            cambioFahrenheit = (Fahrenheit.GetCambio() + 459.67F) * 5 / 9;
        }

        public Kelvin(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public Kelvin(double cantidad, float cambio) : this(cantidad)
        {
            cambioFahrenheit = cambio;
        }


        public double GetCantidad()
        {
            double cantidad;

            cantidad = this.cantidad;

            cantidad = Math.Round(cantidad, 4);

            return cantidad;
        }

        public static float GetCambio()
        {
            float cambio;

            cambio = cambioFahrenheit;

            return cambio;
        }

        public static explicit operator Fahrenheit(Kelvin kel)
        {
            Fahrenheit fahr = new Fahrenheit(kel.GetCantidad() * (9/5) - 459.67F);

            return fahr;//################
        }

        public static explicit operator Celsius(Kelvin kel)
        {
            Celsius cel = new Celsius((kel.GetCantidad() / Kelvin.GetCambio()) * Celsius.GetCambio());

            return cel;
        }

        public static implicit operator Kelvin(double cantidad)
        {
            Kelvin kel = new Kelvin(cantidad);

            return kel;
        }

        public static bool operator ==(Kelvin k, Fahrenheit f)
        {
            bool ok = false;

            if (((Fahrenheit)k).GetCantidad() == f.GetCantidad())
            {
                ok = true;
            }

            return ok;
        }

        public static bool operator ==(Kelvin k, Celsius c)
        {
            bool ok = false;

            if (((Celsius)k).GetCantidad() == c.GetCantidad())
            {
                ok = true;
            }

            return ok;
        }

        public static bool operator ==(Kelvin k1, Kelvin k2)
        {
            bool ok = false;

            if (k1.GetCantidad() == k2.GetCantidad())
            {
                ok = true;
            }

            return ok;
        }

        public static bool operator !=(Kelvin k1, Kelvin k2)
        {
            return !(k1 == k2);
        }


        public static bool operator !=(Kelvin k, Celsius c)
        {
            return !(k == c);
        }


        public static bool operator !=(Kelvin k, Fahrenheit f)
        {
            return !(k == f);
        }


        public static Kelvin operator +(Kelvin k, Fahrenheit f)
        {
            Kelvin kel = new Kelvin(k.GetCantidad() + ((Kelvin)f).GetCantidad());

            return kel;
        }

        public static Kelvin operator +(Kelvin k, Celsius c)
        {
            Kelvin kel = new Kelvin(k.GetCantidad() + ((Kelvin)c).GetCantidad());

            return kel;
        }

        public static Kelvin operator -(Kelvin k, Fahrenheit f)
        {
            Kelvin kel = new Kelvin(k.GetCantidad() - ((Kelvin)f).GetCantidad());

            return kel;
        }

        public static Kelvin operator -(Kelvin k, Celsius c)
        {
            Kelvin kel = new Kelvin(k.GetCantidad() - ((Kelvin)c).GetCantidad());

            return kel;
        }


    }
}
