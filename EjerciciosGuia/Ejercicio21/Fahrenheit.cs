using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio21
{
    class Fahrenheit
    {
        private double cantidad;
        private static float cambioFahrenheit;

        private Fahrenheit()
        {
            cambioFahrenheit = 1;
        }

        public Fahrenheit(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public Fahrenheit(double cantidad, float cambio) : this(cantidad)
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

        public static explicit operator Celsius(Fahrenheit fahr)
        {
            Celsius cel = new Celsius(fahr.GetCantidad() * Celsius.GetCambio());

            return cel;
        }

        public static explicit operator Kelvin(Fahrenheit fahr)
        {
            Kelvin kel = new Kelvin(fahr.GetCantidad() / Kelvin.GetCambio());

            return kel;
        }

        public static implicit operator Fahrenheit(double cantidad)
        {
            Fahrenheit fahr = new Fahrenheit(cantidad);

            return fahr;
        }

        public static bool operator ==(Fahrenheit f, Celsius c)
        {
            bool ok = false;

            if (((Celsius)f).GetCantidad() == c.GetCantidad())
            {
                ok = true;
            }

            return ok;
        }

        public static bool operator ==(Fahrenheit f, Kelvin k)
        {
            bool ok = false;

            if (f.GetCantidad() == ((Fahrenheit)k).GetCantidad())
            {
                ok = true;
            }

            return ok;
        }

        public static bool operator ==(Fahrenheit f1, Fahrenheit f2)
        {
            bool ok = false;

            if (f1.GetCantidad() == f2.GetCantidad())
            {
                ok = true;
            }

            return ok;
        }

        public static bool operator !=(Fahrenheit f1, Fahrenheit f2)
        {
            return !(f1 == f2);
        }


        public static bool operator !=(Fahrenheit f, Kelvin k)
        {
            return !(f == k);
        }


        public static bool operator !=(Fahrenheit f, Celsius c)
        {
            return !(f == c);
        }


        public static Fahrenheit operator +(Fahrenheit f, Celsius c)
        {
            Fahrenheit fahr = new Fahrenheit(f.GetCantidad() + ((Fahrenheit)c).GetCantidad());

            return fahr;
        }

        public static Fahrenheit operator +(Fahrenheit f, Kelvin k)
        {
            Fahrenheit fahr = new Fahrenheit(f.GetCantidad() + ((Fahrenheit)k).GetCantidad());

            return fahr;
        }

        public static Fahrenheit operator -(Fahrenheit f, Celsius c)
        {
            Fahrenheit fahr = new Fahrenheit(f.GetCantidad() - ((Fahrenheit)c).GetCantidad());

            return fahr;
        }

        public static Fahrenheit operator -(Fahrenheit f, Kelvin k)
        {
            Fahrenheit fahr = new Fahrenheit(f.GetCantidad() - ((Fahrenheit)k).GetCantidad());

            return fahr;
        }

    }
}
