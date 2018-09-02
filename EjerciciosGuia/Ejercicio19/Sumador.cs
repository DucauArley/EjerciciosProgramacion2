using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Sumador
    {
        private int cantidadSumas;

        public Sumador(int numero)
        {
            this.cantidadSumas = numero;
        }

        public Sumador() : this(0)
        {
            
        }

        public long Sumar(long num1, long num2)
        {
            long resultado;

            this.cantidadSumas = this.cantidadSumas + 1;

            resultado = num1 + num2;

            return resultado;
        }

        public string Sumar(string num1, string num2)
        {
            string resultado;

            this.cantidadSumas = this.cantidadSumas + 1;

            resultado = num1 + num2;

            return resultado;
        }

        public static explicit operator int(Sumador s)
        {
            int cantidad;

            cantidad = s.cantidadSumas;

            return cantidad;
        }

        public static long operator+(Sumador s1, Sumador s2)
        {
            long respuesta;

            respuesta = (int)s1 + (int)s2;
            
            return respuesta;
        }

        public static bool operator|(Sumador s1, Sumador s2)
        {
            bool ok = false;

            if((int)s1 == (int)s2)
            {
                ok = true;
            }

            return ok;
        }
        
    }
}
