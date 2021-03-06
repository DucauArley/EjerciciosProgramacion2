﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio40
{
    public class Local:Llamada
    {
        protected float costo;

        public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
        {
            this.costo = costo;
        }


        public Local(Llamada llamada, float costo) : this(llamada.NumeroOrigen, llamada.Duracion, llamada.NumeroDestino, costo)
        {
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

            if(obj is Local)
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


    }
}
