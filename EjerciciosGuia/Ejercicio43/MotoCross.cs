using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio43
{
    class MotoCross:VehiculoDeCarrera
    {
        private short cilindradas;

        public MotoCross(short numero, string escuderia) : base(numero, escuderia)
        {

        }

        public MotoCross(short numero, string escuderia, short cilindrada) : this(numero, escuderia)
        {
            this.cilindradas = cilindrada;
        }

        public short Cilindrada
        {
            get
            {
                return this.cilindradas;
            }

            set
            {
                this.cilindradas = value;
            }
        }

        public static bool operator ==(MotoCross m1, MotoCross m2)
        {
            bool ok = false;

            if (m1.Numero == m2.Numero && m1.Escuderia == m2.Escuderia)
            {
                ok = true;
            }

            return ok;
        }

        public static bool operator !=(MotoCross m1, MotoCross m2)
        {
            return !(m1 == m2);
        }

        public override string MostrarDatos()
        {
            StringBuilder str = new StringBuilder();
            string retorno;

            str.Append(base.MostrarDatos());
            str.AppendLine("Caballos de Fuerza: " + this.Cilindrada);

            retorno = str.ToString();

            return retorno;
        }
    }
}
