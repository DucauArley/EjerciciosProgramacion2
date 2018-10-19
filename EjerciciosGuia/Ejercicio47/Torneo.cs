using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio47
{
    class Torneo<T> where T: Equipo
    {
        private List<T> equipos;
        private string nombre;

        private Torneo()
        {
            this.equipos = new List<T>();
        }
        
        public Torneo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public string JugarPartido
        {
            get
            {
                Random ran = new Random();
                string retorno;
                T e1;
                T e2;

                e1 = this.equipos.ElementAt((ran.Next(this.equipos.Count)));
                e2 = this.equipos.ElementAt((ran.Next(this.equipos.Count)));

                while(e1 == e2)
                {
                    e2 = this.equipos.ElementAt((ran.Next(this.equipos.Count)));
                }

                retorno = CalcularPartido(e1, e2);

                return retorno;
            }
        }

        
        public static bool operator ==(Torneo<T> t, T e)
        {
            bool ok = false;

            if (t.equipos.Contains(e))
            {
                ok = true;
            }

            return ok;
        }

        public static bool operator !=(Torneo<T> t, T e)
        {
            return !(t == e);
        }

        public static Torneo<T> operator +(Torneo<T> t, T e)
        {
            if(t != e)
            {
                t.equipos.Add(e);
            }

            return t;
        }

        public string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            string retorno;

            str.AppendLine("Torneo " + this.nombre);
            str.AppendLine("Equipos participantes: ");

            foreach (T e in this.equipos)
            {
                str.Append(e.Ficha());
            }

            retorno = str.ToString();

            return retorno;
        }

        private string CalcularPartido(T e1, T e2)
        {
            StringBuilder str = new StringBuilder();
            Random ran = new Random();
            string retorno;

            str.AppendLine(e1.Nombre + " " + ran.Next(40) + " - " + e2.Nombre + " " + ran.Next(40));

            retorno = str.ToString();

            return retorno;
        }



    }
}
