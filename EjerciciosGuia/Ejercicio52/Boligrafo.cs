using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio52
{
    class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.colorTinta = color;
            this.tinta = unidades;
        }

        public ConsoleColor Color
        {
            get
            {
                return this.colorTinta;
            }
            set
            {
                this.colorTinta = value;
            }
        }

        public float UnidadesDeEscritura
        {
            get
            {
                return this.tinta;
            }

            set
            {
                this.tinta = value;
            }
        }

        public EscrituraWrapper Escribir(string texto)
        {
            EscrituraWrapper e = new EscrituraWrapper(texto, this.Color);

            UnidadesDeEscritura = UnidadesDeEscritura - (0.3F * texto.Length);

            return e;
        }

        public bool Recargar(int unidades)
        {
            bool ok = false;
            int unidadesTotales;

            unidadesTotales = (int) UnidadesDeEscritura + unidades;

            if(unidadesTotales < 100)
            {
                UnidadesDeEscritura = unidadesTotales;
                ok = true;
            }

            return ok;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            string retorno;

            str.AppendLine("Boligrafo:");
            str.AppendLine("Color de escritura: " + this.Color);
            str.AppendLine("Nivel de tinta: " + this.UnidadesDeEscritura);

            retorno = str.ToString();
            
            return retorno;
        }

    }
}
