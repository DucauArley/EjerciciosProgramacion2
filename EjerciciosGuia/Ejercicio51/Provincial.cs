using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio51
{
    class Provincial:Llamada, IGuardar<string>
    {
        protected Franja franjaHoraria;
        private string rutaArchivo;


        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }


        public Provincial(Franja miFranja, Llamada llamada) : this(llamada.NumeroOrigen, miFranja, llamada.Duracion, llamada.NumeroDestino)
        {
        }

        public string RutaDeArchivo
        {
            get
            {
                return this.rutaArchivo;
            }

            set
            {
                this.rutaArchivo = value;
            }
        }

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }


        protected override string Mostrar()
        {
            string retorno;
            StringBuilder str = new StringBuilder();

            str.Append(base.Mostrar());
            str.AppendLine("Costo de la llamada: " + CostoLlamada);
            str.AppendLine("Franja horaria: " + this.franjaHoraria);

            retorno = str.ToString();

            return retorno;

        }


        private float CalcularCosto()
        {
            float retorno = 0;

            if (this.franjaHoraria == Franja.Franja_1)
            {
                retorno = this.Duracion * 0.99F;
            }
            else
            {
                if (this.franjaHoraria == Franja.Franja_2)
                {
                    retorno = this.Duracion * 1.25F;
                }
                else
                {
                    if (this.franjaHoraria == Franja.Franja_3)
                    {
                        retorno = this.Duracion * 0.66F;
                    }
                }
            }


            return retorno;
        }

        public override bool Equals(object obj)
        {
            bool ok = false;

            if (obj is Provincial)
            {
                ok = true;
            }

            return ok;
        }

        public override string ToString()
        {
            string retorno;

            retorno = this.Mostrar();

            return retorno;
        }

        public bool Guardar()
        {
            throw new NotImplementedException();
        }

        public string Leer()
        {
            throw new NotImplementedException();
        }


        public enum Franja
        {
            Franja_1 = 0,
            Franja_2 = 1,
            Franja_3 = 2
        }
    }
}
