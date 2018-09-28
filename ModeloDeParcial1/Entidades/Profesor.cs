using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Persona
    {
        private DateTime fechaIngreso;

        public Profesor(string nombre, string apellido, string documento):this(nombre, apellido, documento, DateTime.Now)
        {
        }

        public Profesor(string nombre, string apellido, string documento, DateTime fecha):base(nombre, apellido, documento)
        {
            this.fechaIngreso = fecha;
        }

        public int antiguedad
        {
            get
            {
                int retorno;
                DateTime fecha = DateTime.Now;

                retorno = (int) (fecha - this.fechaIngreso).TotalDays;

                return retorno;
            }
        }


        public override string ExponerDatos()
        {
            string retorno;
            StringBuilder str = new StringBuilder();

            str.Append(base.ExponerDatos());
            str.AppendLine("Antiguedad: " + this.antiguedad + " dias");

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
                foreach (char numero in doc)
                {
                    if (!int.TryParse(numero.ToString(), out i))
                    {
                        ok = false;
                    }
                }
            }

            return ok;
        }
    }
}
