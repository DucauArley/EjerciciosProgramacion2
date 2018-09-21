using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30
{
    class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;
        
        public AutoF1(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.enCompetencia = false;
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            bool ok = false;

            if(a1.numero == a2.numero && a1.escuderia == a2.escuderia)
            {
                ok = true;
            }

            return ok;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }

        public string MostrarDatos()
        {
            StringBuilder retorno = new StringBuilder();
            string info;

            retorno.AppendLine("Numero: " + this.numero);
            retorno.AppendLine("Escuderia: " + this.escuderia);
            if(GetEnCompetencia() == true)
            {
                retorno.AppendLine("Esta en competencia");
                retorno.AppendLine("Vueltas restantes: " + GetVueltasRestantes());
                retorno.AppendLine("Cantidad de combustible: " + GetCantidadCombustible());
            }
            
            info = retorno.ToString();

            return info;
        }



        public short GetCantidadCombustible()
        {
            short retorno = this.cantidadCombustible;

            return retorno;
        }

        public short GetVueltasRestantes()
        {
            short retorno = this.vueltasRestantes;

            return retorno;
        }

        public bool GetEnCompetencia()
        {
            bool retorno = this.enCompetencia;

            return retorno;
        }

        public void SetCantidadCombustible(short combustible)
        {
            this.cantidadCombustible = combustible;
        }

        public void SetVueltasRestantes(short vueltas)
        {
            this.vueltasRestantes = vueltas;
        }

        public void SetEnCompetencia(bool esta)
        {
            this.enCompetencia = esta;
        }
        
    }
}
