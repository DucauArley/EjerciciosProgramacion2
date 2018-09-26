using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio37
{
    class Local:Llamada
    {
        protected float costo;

        public Local(string origen, float duracion, string destino, float costo):base(duracion, destino, origen)
        {
            this.costo = costo;
        }


        public Local(Llamada llamada, float costo):this(llamada.NumeroOrigen, llamada.Duracion, llamada.NumeroDestino, costo)
        {           
        }

        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        public new string Mostrar()
        {
            string retorno;
            StringBuilder str = new StringBuilder();

            str.AppendLine("Duracion: " + this.Duracion);
            str.AppendLine("Numero de destino: " + this.NumeroDestino);
            str.AppendLine("Numero de origen: " + this.NumeroOrigen);
            str.AppendLine("Costo de la llamada: " + this.costo);

            retorno = str.ToString();

            return retorno;
        }

        private float CalcularCosto()
        {
            float costoLLamada;

            costoLLamada = this.Duracion * this.costo;

            return costoLLamada;
        }


    }
}
