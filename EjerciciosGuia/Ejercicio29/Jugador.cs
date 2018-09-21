using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio29
{
    class Jugador
    {
        private long dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        private Jugador()
        {
            this.dni = 0;
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int partidosJugados):this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = partidosJugados;
        }

        public float GetPromedioGoles()
        {
            this.promedioGoles = (float) totalGoles / partidosJugados;

            return this.promedioGoles;
        }

        public string MostrarDatos()
        {
            StringBuilder retorno = new StringBuilder();
            string info;

            retorno.AppendLine("Dni: " + this.dni);
            retorno.AppendLine("Nombre: " + this.nombre);
            retorno.AppendLine("Partidos jugados: " + this.partidosJugados);
            retorno.AppendLine("Goles totales: " + this.totalGoles);
            retorno.AppendLine("Promedio de goles: " + GetPromedioGoles());

            info = retorno.ToString();

            return info;
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            bool ok = false;

            if(j1.dni == j2.dni)
            {
                ok = true;
            }

            return ok;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
       
    }
}
