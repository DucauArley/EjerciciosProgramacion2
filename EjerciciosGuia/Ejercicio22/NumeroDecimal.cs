using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio22
{
    class NumeroDecimal
    {
        public double numero;

        public NumeroDecimal(double numero)
        {
            this.numero = numero;
        }

        public static string DecimalBinario(double numero)
        {
            string binario = "";

            while (numero != 0 && numero != 1)
            {
                if (numero % 2 == 0)
                {
                    binario = "0" + binario;
                }
                else
                {
                    binario = "1" + binario;
                }

                numero = Math.Truncate(numero / 2);
            }

            binario = numero + binario;

            return binario;
        }

        public static double operator +(NumeroDecimal numero, NumeroBinario binario)
        {
            double numBinario = NumeroBinario.BinarioDecimal(binario.numero);
            double numSuma;

            numSuma = numBinario + numero.numero;
            
            return numSuma;
        }

        public static double operator -(NumeroDecimal numero, NumeroBinario binario)
        {
            double numBinario = NumeroBinario.BinarioDecimal(binario.numero);
            double numSuma;

            numSuma = numBinario - numero.numero;

            return numSuma;
        }

        public static bool operator ==(NumeroDecimal numero, NumeroBinario binario)
        {
            bool ok = false;
            double numBinario = NumeroBinario.BinarioDecimal(binario.numero);

            if (numBinario == numero.numero)
            {
                ok = true;
            }

            return ok;
        }

        public static bool operator !=(NumeroDecimal numero, NumeroBinario binario)
        {
            return !(numero == binario);
        }
    }
}
