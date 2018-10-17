using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio36
{
    class AutoF1: VehiculoDeCarrera
    {
        private short caballosDeFuerza;

        public AutoF1(short numero, string escuderia) : base(numero, escuderia)
        {
            
        }

        public AutoF1(short numero, string escuderia, short caballosDeFuerza): this(numero, escuderia)
        {
            this.caballosDeFuerza = caballosDeFuerza;
        }

        public short CaballosDeFuerza
        {
            get
            {
                return this.caballosDeFuerza;
            }

            set
            {
                this.caballosDeFuerza = value;
            }
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            bool ok = false;

            if (a1.Numero == a2.Numero && a1.Escuderia == a2.Escuderia)
            {
                ok = true;
            }

            return ok;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }

        public override string MostrarDatos()
        {
            StringBuilder str = new StringBuilder();
            string retorno;

            str.Append(base.MostrarDatos());
            str.AppendLine("Caballos de Fuerza: " + this.CaballosDeFuerza);

            retorno = str.ToString();

            return retorno;
        }
    }
}
