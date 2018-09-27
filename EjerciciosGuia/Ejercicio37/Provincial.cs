using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio37
{
    class Provincial:Llamada
    {
        protected Franja franjaHoraria;


        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }


        public Provincial(Franja miFranja, Llamada llamada) : this(llamada.NumeroOrigen, miFranja, llamada.Duracion, llamada.NumeroDestino)
        {
        }

        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }


        public new string Mostrar()
        {
            string retorno;
            StringBuilder str = new StringBuilder();

            str.AppendLine("Duracion: " + this.Duracion);
            str.AppendLine("Numero de destino: " + this.NumeroDestino);
            str.AppendLine("Numero de origen: " + this.NumeroOrigen);
            str.AppendLine("Costo de la llamada: " + CostoLlamada);
            str.AppendLine("Franja horaria: " + this.franjaHoraria);

            retorno = str.ToString();

            return retorno;
            
        }


        private float CalcularCosto()
        {
            float retorno = 0;

            if(this.franjaHoraria == Franja.Franja_1)
            {
                retorno = this.Duracion * 0.99F;
            }
            else
            {
                if(this.franjaHoraria == Franja.Franja_2)
                {
                    retorno = this.Duracion * 1.25F;
                }
                else
                {
                    if(this.franjaHoraria == Franja.Franja_3)
                    {
                        retorno = this.Duracion * 0.66F;
                    }
                }
            }


            return retorno;
        }

        
        public enum Franja
        {
            Franja_1 = 0,
            Franja_2 = 1,
            Franja_3 = 2
        }

    }
}
