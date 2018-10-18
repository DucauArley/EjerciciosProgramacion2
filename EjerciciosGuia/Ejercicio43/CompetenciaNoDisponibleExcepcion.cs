using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio43
{
    class CompetenciaNoDisponibleExcepcion: Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public CompetenciaNoDisponibleExcepcion(string mensaje, string clase, string metodo):this(mensaje, clase, metodo, null)
        {
        }

        public CompetenciaNoDisponibleExcepcion(string mensaje, string clase, string metodo, Exception innerException):base(mensaje, innerException)
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
                return this.NombreMetodo;
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            string retorno;

            str.AppendFormat("Excepcion en el metodo {0} de la clase {1}", NombreMetodo, NombreClase);
            str.AppendLine(this.Message);

            Exception e = this.InnerException;
            do
            {
                str.AppendLine(e.Message);
                e = this.InnerException;
            } while (!ReferenceEquals(e.InnerException, null));

            retorno = str.ToString();
            
            return retorno;
        }
    }
}
