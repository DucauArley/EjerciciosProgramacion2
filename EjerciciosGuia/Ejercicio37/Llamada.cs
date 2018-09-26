using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio37
{
    class Llamada
    {
        protected float duracion;
        protected string numeroDestino;
        protected string numeroOrigen;

        public Llamada(float duracion, string destino, string origen)
        {
            this.duracion = duracion;
            this.numeroDestino = destino;
            this.numeroOrigen = origen;
        }

        public float Duracion
        {
            get
            {
                return this.duracion;
            }

        }

        public string NumeroDestino
        {
            get
            {
                return this.numeroDestino;
            }

        }


        public string NumeroOrigen
        {
            get
            {
                return this.numeroOrigen;
            }

        }


        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno = 0;

            if(llamada1.duracion > llamada2.duracion)
            {
                retorno = 1;//##############################
            }


            return retorno;
        }

        public string Mostrar()
        {
            string retorno = "";
            StringBuilder str = new StringBuilder();

            str.AppendLine("Duracion: " + this.Duracion);
            str.AppendLine("Numero de destino: " + this.NumeroDestino);
            str.AppendLine("Numero de origen: " + this.NumeroOrigen);

            retorno = str.ToString();

            return retorno;
        }

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }


    }
}
