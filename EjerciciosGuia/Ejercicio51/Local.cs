using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio51
{
    class Local:Llamada, IGuardar<string>
    {
        protected float costo;
        private string rutaArchivo;

        public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
        {
            this.costo = costo;
        }


        public Local(Llamada llamada, float costo) : this(llamada.NumeroOrigen, llamada.Duracion, llamada.NumeroDestino, costo)
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
                return CalcularCosto();
            }
        }

        protected override string Mostrar()
        {
            string retorno;
            StringBuilder str = new StringBuilder();

            str.Append(base.Mostrar());
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

        public override bool Equals(object obj)
        {
            bool ok = false;

            if (obj is Local)
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
    }
}
