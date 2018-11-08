using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio59
{
    class FallaLogException:Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public FallaLogException(string mensaje, string clase, string metodo) : this(mensaje, clase, metodo, null)
        {

        }

        public FallaLogException(string mensaje, string clase, string metodo, Exception innerException) : base(mensaje, innerException)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }
    }
}
