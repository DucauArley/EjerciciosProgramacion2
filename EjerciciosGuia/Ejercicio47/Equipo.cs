using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio47
{
    public abstract class Equipo
    {
        protected string nombre;
        protected DateTime fechaCreacion;

        public Equipo(string nombre, DateTime fecha)
        {
            this.nombre = nombre;
            this.fechaCreacion = fecha;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public DateTime FechaCreacion
        {
            get
            {
                return this.fechaCreacion;
            }
        }

        public static bool operator ==(Equipo e1, Equipo e2)
        {
            bool ok = false;

            if(e1.FechaCreacion == e2.FechaCreacion && e1.Nombre == e2.Nombre)
            {
                ok = true;
            }

            return ok;
        }

        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }

        public string Ficha()
        {
            StringBuilder str = new StringBuilder();
            string retorno;

            str.AppendLine(this.Nombre + " fundado el " + this.FechaCreacion);

            retorno = str.ToString();

            return retorno;
        }

    }
}
