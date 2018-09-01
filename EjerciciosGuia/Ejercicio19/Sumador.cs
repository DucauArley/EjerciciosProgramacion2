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

    }
}
