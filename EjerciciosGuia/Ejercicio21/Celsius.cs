using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio21
{
    class Celsius
    {
        private double cantidad;
        private static float cambioFahrenheit;

        private Celsius()
        {
            cambioFahrenheit = (Fahrenheit.GetCambio() - 32) * 5 / 9;
        }

        public Celsius(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public Celsius(double cantidad, float cambio) : this(cantidad)
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

        public static explicit operator Fahrenheit(Celsius cel)
        {
            Fahrenheit fahr = new Fahrenheit(cel.GetCantidad() / Celsius.GetCambio());

            return fahr;
        }

        public static explicit operator Kelvin(Celsius cel)
        {
            Kelvin kel = new Kelvin((cel.GetCantidad() / Celsius.GetCambio()) * Kelvin.GetCambio());

            return kel;
        }

        public static implicit operator Celsius(double cantidad)
        {
            Celsius cel = new Celsius(cantidad);

            return cel;
        }

        public static bool operator ==(Celsius c, Fahrenheit f)
        {
            bool ok = false;

            if (((Fahrenheit)c).GetCantidad() == f.GetCantidad())
            {
                ok = true;
            }

            return ok;
        }

        public static bool operator ==(Celsius c, Kelvin k)
        {
            bool ok = false;

            if (((Kelvin)c).GetCantidad() == k.GetCantidad())
            {
                ok = true;
            }

            return ok;
        }

        public static bool operator ==(Celsius c1, Celsius c2)
        {
            bool ok = false;

            if (c1.GetCantidad() == c2.GetCantidad())
            {
                ok = true;
            }

            return ok;
        }

        public static bool operator !=(Celsius c1, Celsius c2)
        {
            return !(c1 == c2);
        }


        public static bool operator !=(Celsius c, Kelvin k)
        {
            return !(c == k);
        }


        public static bool operator !=(Celsius c, Fahrenheit f)
        {
            return !(c == f);
        }


        public static Celsius operator +(Celsius c, Fahrenheit f)
        {
            Celsius cel = new Celsius(c.GetCantidad() + ((Celsius)f).GetCantidad());

            return cel;
        }

        public static Celsius operator +(Celsius c, Kelvin k)
        {
            Celsius cel = new Celsius(c.GetCantidad() + ((Celsius)k).GetCantidad());

            return cel;
        }

        public static Celsius operator -(Celsius c, Fahrenheit f)
        {
            Celsius cel = new Celsius(c.GetCantidad() - ((Celsius)f).GetCantidad());

            return cel;
        }

        public static Celsius operator -(Celsius c, Kelvin k)
        {
            Celsius cel = new Celsius(c.GetCantidad() - ((Celsius)k).GetCantidad());

            return cel;
        }
    }
}
