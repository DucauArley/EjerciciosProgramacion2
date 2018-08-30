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

                numero = numero / 2;
            }

            binario += numero;

            return binario;
        }

        public static double BinarioDecimal(string binario)
        {
            return 0;
        }

    }
}
