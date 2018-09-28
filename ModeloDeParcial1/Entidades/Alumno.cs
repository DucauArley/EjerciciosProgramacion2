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

            if (doc.Length == 9 && doc.ElementAt(2) == '-' && doc.ElementAt(7) == '-')
            {
                ok = true;
                for (int i = 0; i < doc.Length; i++)
                {
                    if (i != 2 && i != 7)
                    {
                        if (!char.IsNumber(doc[i]))
                        {
                            ok = false;
                            break;
                        }
                    }
                }
            }

            return ok;
        }
    }
}
