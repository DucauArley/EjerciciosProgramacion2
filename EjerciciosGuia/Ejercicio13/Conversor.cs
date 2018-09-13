using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Conversor
    {
        public static string DecimalBinario(double numero)
        {
            string binario = "";

            while (numero != 0 && numero != 1)
            {
                if (numero % 2 == 0)
                {
                    binario += "0";

                }
                else
                {
                    binario += "1";
                }

                numero = Math.Truncate(numero / 2);
            }

            binario += numero;

            binario.Reverse();

            return binario;
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




            return 0;
        }

    }
}
