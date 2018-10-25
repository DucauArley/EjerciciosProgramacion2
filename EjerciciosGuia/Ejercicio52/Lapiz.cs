using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio52
{
    class Lapiz:IAcciones
    {
        private float tamañoMina;

        public Lapiz(float mina)
        {
            this.tamañoMina = mina;
        }

        public ConsoleColor Color
        {
            get
            {
                return ConsoleColor.Gray;
            }

            set
            {
                throw new NotImplementedException();
            }

        }

        public float UnidadesDeEscritura
        {
            get
            {
                return this.tamañoMina;
            }

            set
            {
                this.tamañoMina = value;
            }
        }

        public EscrituraWrapper Escribir(string texto)
        {
            EscrituraWrapper e = new EscrituraWrapper(texto, this.Color);

            UnidadesDeEscritura = UnidadesDeEscritura - (0.1F * texto.Length);

            return e;
        }

        public bool Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            string retorno;

            str.AppendLine("Lapiz: ");
            str.AppendLine("Color de escritura: " + this.Color);
            str.AppendLine("Nivel de mina: " + this.UnidadesDeEscritura);

            retorno = str.ToString();

            return retorno;
        }

    }
}
