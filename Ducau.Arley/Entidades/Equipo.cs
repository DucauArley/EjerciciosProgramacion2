using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private const int cantidadMaximaJugadores = 6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;


        /// <summary>
        /// Constructor privado que inicializa la lista de jugadores
        /// </summary>
        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }


        /// <summary>
        /// constructor del equipo, llama al constructor privado
        /// </summary>
        /// <param name="nombre"></param>Nombre del equipo
        public Equipo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        /// <summary>
        /// Propiedad de solo escritura de el director tecnico
        /// </summary>
        public DirectorTecnico DirectorTecnico
        {
            set
            {
                if (value.ValidarAptitud())
                {
                    this.directorTecnico = value;
                }

            }
        }

        /// <summary>
        /// Propiedad de solo lectura de el nombre
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        /// <summary>
        /// Muestra los datos del equipo
        /// </summary>
        /// <returns></returns>Devuelve una cadena con los datos del equipo
        public static explicit operator string(Equipo e)
        {
            StringBuilder str = new StringBuilder();
            string retorno;

            str.AppendLine("Nombre: " + e.Nombre);
            if (e.directorTecnico is null)
            {
                str.AppendLine("Sin DT asignado");
            }
            else//Posible error
            {
                str.AppendLine("Director" + e.directorTecnico.Mostrar());
            }
            foreach (Jugador j in e.jugadores)
            {
                str.AppendLine(j.Mostrar());
            }

            retorno = str.ToString();

            return retorno;
        }



        /// <summary>
        /// compara si un jugador esta en el equipo
        /// </summary>
        /// <param name="e"></param>El equipo pasado por parametro
        /// <param name="j"></param>El jugador pasado por parametro
        /// <returns></returns>true si esta, false si no
        public static bool operator ==(Equipo e, Jugador j)
        {
            bool ok = false;

            if (e.jugadores.Contains(j))
            {
                ok = true;
            }


            return ok;
        }

        /// <summary>
        /// compara si un jugador no esta en el equipo
        /// </summary>
        /// <param name="e"></param>El equipo pasado por parametro
        /// <param name="j"></param>El jugador pasado por parametro
        /// <returns></returns>true si no esta, false si esta
        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }


        /// <summary>
        /// Agrega un jugador al equipo siempre y cuando este no este
        /// </summary>
        /// <param name="e"></param>El equipo pasado por parametro
        /// <param name="j"></param>El jugador pasado por parametro
        /// <returns></returns>El equipo con el jugador dentro
        public static Equipo operator +(Equipo e, Jugador j)
        {
            if (e != j && e.jugadores.Count < 6)
            {
                if (j.ValidarAptitud())
                {
                    e.jugadores.Add(j);
                }             
            }
            
            return e;
        } 


        /// <summary>
        /// Valida si el equipo es apto para jugar
        /// </summary>
        /// <param name="e"></param>El equipo pasado por parametro
        /// <returns></returns>true si es apto, false si no lo es
        public static bool ValidarEquipo(Equipo e)
        {
            bool ok = false;
            int contadorArqueros = 0;
            int contadorDelanteros = 0;
            int contadorDefensores = 0;
            int contadorCentrales = 0;


            if(!(e.directorTecnico is null) && e.jugadores.Count == 6)
            {
                foreach(Jugador j in e.jugadores)
                {
                    if(j.Posicion == Posicion.Arquero)
                    {
                        contadorArqueros++;
                    }
                    else
                    {
                        if(j.Posicion == Posicion.Central)
                        {
                            contadorCentrales++;
                        }
                        else
                        {
                            if(j.Posicion == Posicion.Defensor)
                            {
                                contadorDefensores++;
                            }
                            else
                            {
                                if(j.Posicion == Posicion.Delantero)
                                {
                                    contadorDelanteros++;
                                }
                            }
                        }
                    }

                    if(contadorArqueros == 1 && contadorCentrales >= 1 && contadorDefensores >= 1 && contadorDelanteros >= 1)
                    {
                        ok = true;
                    }
                }
            }

            return ok;
        }



    }
}
