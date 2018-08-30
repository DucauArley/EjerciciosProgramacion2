using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Validar
    {
        public static bool Validacion(int valor, int min, int max)
        {
            bool retorno = true;

            if (valor < min || valor > max)
            {
                retorno = false;
            }

            return retorno;
        }

    }
}
