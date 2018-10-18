using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio41
{
    class CentralitaExcepcion: Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public CentralitaExcepcion(string mensaje, string clase, string metodo):this(mensaje, clase, metodo, null)
        {

        }

        public CentralitaExcepcion(string mensaje, string clase, string metodo, Exception innerException):base(mensaje, innerException)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

        public string NombreClase
        {
            get
            {
                return this.nombreClase;
            }
        }

        public string NombreMetodo
        {
            get
            {
                return this.nombreMetodo;
            }
        }

    }
}
