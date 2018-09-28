using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Divisiones
    {
        A,
        B,
        C,
        D,
        E   
    }


    public abstract class Persona
    {
        private string apellido;
        private string documento;
        private string nombre;

        public Persona(string nombre, string apellido, string documento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            if (ValidarDocumentacion(documento))
            {
                this.documento = documento;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string Documento
        {
            get
            {
                return this.documento;
            }

            set
            {

                if (ValidarDocumentacion(value))
                {
                    this.documento = value;
                }
            }


        }


        public virtual string ExponerDatos()
        {
            StringBuilder str = new StringBuilder();
            string retorno;

            str.AppendLine("Nombre: " + Nombre);
            str.AppendLine("Apellido: " + Apellido);
            str.AppendLine("Documento: " + Documento);

            retorno = str.ToString();

            return retorno;                                       
        }

        protected abstract bool ValidarDocumentacion(string doc);





    }
}
