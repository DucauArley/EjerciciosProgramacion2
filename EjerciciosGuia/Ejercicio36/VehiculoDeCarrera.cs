using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio36
{
    class VehiculoDeCarrera
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.enCompetencia = false;
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;
        }

        public short CantidadCombustible
        {
            get
            {
                return this.cantidadCombustible;
            }

            set
            {
                this.cantidadCombustible = value;
            }
        }

        public bool EnCompetencia
        {
            get
            {
                return this.enCompetencia;
            }

            set
            {
                this.enCompetencia = value;
            }
        }

        public string Escuderia
        {
            get
            {
                return this.escuderia;
            }

            set
            {
                this.escuderia = value;
            }
        }

        public short Numero
        {
            get
            {
                return this.numero;
            }

            set
            {
                this.numero = value;
            }
        }

        public short VueltasRestantes
        {
            get
            {
                return this.vueltasRestantes;
            }

            set
            {
                this.vueltasRestantes = value;
            }
        }

        public virtual string MostrarDatos()
        {
            StringBuilder str = new StringBuilder();
            string retorno;
            
            str.AppendLine("Escuderia: " + Escuderia);
            str.AppendLine("Numero: " + Numero);
            if (this.EnCompetencia == true)
            {
                str.AppendLine("Esta en competencia");
                str.AppendLine("Vueltas restantes: " + this.VueltasRestantes);
                str.AppendLine("Cantidad de combustible: " + this.CantidadCombustible);
            }

            retorno = str.ToString();

            return retorno;
        }

    }
}
