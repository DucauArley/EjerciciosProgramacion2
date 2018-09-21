using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio29
{
    class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre):this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            bool ok = true;
            bool entro = false;

            for (int i = 0; i < e.jugadores.Count; i++)
            {
                if (j == e.jugadores.ElementAt(i))
                {
                    ok = false;
                    break;
                }
            }

            if (ok && e.jugadores.Count < e.cantidadDeJugadores)
            {
                e.jugadores.Add(j);
                entro = true;
            }

            return entro;
        }

        
    }
}
