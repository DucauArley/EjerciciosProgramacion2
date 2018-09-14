using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio22
{
    class NumeroBinario
    {
        public string numero;

        public NumeroBinario(string numero)
        {
            this.numero = numero;
        }

        public static double BinarioDecimal(string binario)
        {
            double numero = 0;
            int j = binario.Length - 1;

            for (int i = 0; i < binario.Length; i++)
            {
                numero += double.Parse(binario[j].ToString()) * Math.Pow(2, i);
                j--;
            }

            return numero;
        }

        public static bool ValidarBinario(string binario)
        {
            bool ok = true;
            int numero = -1;

            for (int i = 0; i < binario.Length; i++)
            {
                numero = int.Parse(binario[i].ToString());

                if (numero != 0 && numero != 1)
                {
                    ok = false;
                    break;
                }
            }

            return ok;
        }

        public static string operator +(NumeroBinario binario, NumeroDecimal numero)
        {
            double numBinario = BinarioDecimal(binario.numero);
            double numSuma;
            string numTotal;

            numSuma = numBinario + numero.numero;

            numTotal = NumeroDecimal.DecimalBinario(numSuma);


            return numTotal;
        }

        public static string operator -(NumeroBinario binario, NumeroDecimal numero)
        {
            double numBinario = BinarioDecimal(binario.numero);
            double numSuma;
            string numTotal;

            numSuma = numBinario - numero.numero;

            numTotal = NumeroDecimal.DecimalBinario(numSuma);


            return numTotal;
        }

        public static bool operator ==(NumeroBinario binario, NumeroDecimal numero)
        {
            bool ok = false;
            double numBinario = BinarioDecimal(binario.numero);

            if(numBinario == numero.numero)
            {
                ok = true;
            }

            return ok;
        }

        public static bool operator !=(NumeroBinario binario, NumeroDecimal numero)
        {
            return !(binario == numero);
        }
































    }
}
