using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio68
{
    public delegate void DelegadoString(string msg);

    class Persona
    {
        private string nombre;
        private string apellido;

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }

            set
            {
                this.nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }

            set
            {
                this.apellido = value;
            }
        }

        public string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            string retorno;

            str.AppendLine("Nombre: " + this.Nombre);
            str.AppendLine("Apellido: " + this.Apellido);

            retorno = str.ToString();

            return retorno;
        }


    }
}
