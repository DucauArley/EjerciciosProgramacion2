using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        private short anio;
        private Divisiones division;

        public Alumno(string nombre, string apellido, string documento, short anio, Divisiones division):base(nombre, apellido, documento)
        {
            this.anio = anio;
            this.division = division;
        }

        public string AnioDivision
        {
            get
            {
                string retorno = this.anio + "º" + this.division;
                return retorno;
            }
        }



        public override string ExponerDatos()
        {
            string retorno;
            StringBuilder str = new StringBuilder();

            str.Append(base.ExponerDatos());
            str.AppendLine("Año/Division: " + this.AnioDivision);

            retorno = str.ToString();
            return retorno;
        }

        protected override bool ValidarDocumentacion(string doc)
        {
            bool ok = false;
            int i = 0;

            if (doc.ElementAt(2) == '-' && doc.ElementAt(7) == '-' && doc.Length == 9)
            {
                ok = true;
                doc.TrimStart('-', '-');
                foreach(char numero in doc)
                {
                    if(!int.TryParse(numero.ToString(), out i))
                    {
                        ok = false;
                    }

                }

            }

            return ok;
        }
    }
}
