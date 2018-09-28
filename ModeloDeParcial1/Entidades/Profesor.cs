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
