using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30
{
    class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores):this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }
        
        public string MostrarDatos()
        {
            StringBuilder retorno = new StringBuilder();
            string info;

            retorno.Append("Cantidad de competidores: " + this.cantidadCompetidores);
            retorno.AppendLine("Cantidad de vueltas: " + this.cantidadVueltas);
            for (int i = 0; i < this.competidores.Count; i++)
            {
                retorno.AppendLine("Competidor " + (i + 1) + " " + this.competidores.ElementAt(i).MostrarDatos());
            }

            info = retorno.ToString();
            return info;
        }


        public static bool operator +(Competencia c, AutoF1 a)
        {
            bool ok = true;
            bool entro = false;
            Random ran = new Random();

            for (int i = 0; i < c.competidores.Count; i++)
            {
                if (a == c.competidores.ElementAt(i))
                {
                    ok = false;
                    break;
                }
            }

            if (ok && c.competidores.Count < c.cantidadCompetidores)
            {
                c.competidores.Add(a);
                a.SetEnCompetencia(true);
                a.SetVueltasRestantes(c.cantidadVueltas);
                a.SetCantidadCombustible((short) ran.Next(15, 100));

                entro = true;
            }

            return entro;
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            bool ok = false;

            for (int i = 0; i < c.competidores.Count; i++)
            {
                if (a == c.competidores.ElementAt(i))
                {
                    ok = true;
                    break;
                }
            }

            if (ok)
            {
                c.competidores.Remove(a);
            }

            return ok;
        }

    }
}
