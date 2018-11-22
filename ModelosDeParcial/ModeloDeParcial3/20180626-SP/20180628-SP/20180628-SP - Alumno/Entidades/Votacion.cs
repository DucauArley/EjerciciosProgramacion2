using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Votacion
    {
        public enum EVoto { Afirmativo, Negativo, Abstencion, Esperando }

        public delegate void Voto(string senador, Votacion.EVoto voto);
        public event Voto EventoVotoEfectuado;

        private string nombreLey;
        private Dictionary<string, EVoto> senadores;
        private short contadorAfirmativo;
        private short contadorNegativo;
        private short contadorAbstencion;

        public Votacion()
        {
            
        }

        public Votacion(string nombreLey, Dictionary<string, EVoto> senadores)
        {
            this.nombreLey = nombreLey;
            this.senadores = senadores;
        }

        public string NombreLey
        {
            get
            {
                return this.nombreLey;
            }

            set
            {
                this.nombreLey = value;
            }
        }

        public Dictionary<string, EVoto> Senadores
        {
            get
            {
                return this.senadores;
            }

            set
            {
                this.senadores = value;
            }
        }

        public short ContadorAfirmativo
        {
            get
            {
                return this.contadorAfirmativo;
            }

            set
            {
                this.contadorAfirmativo = value;
            }
        }

        public short ContadorNegativo
        {
            get
            {
                return this.contadorNegativo;
            }

            set
            {
                this.contadorNegativo = value;
            }
        }

        public short ContadorAbstencion
        {
            get
            {
                return this.contadorAbstencion;
            }

            set
            {
                this.contadorAbstencion = value;
            }
        }


        public void Simular()
        {
            // Reseteo contadores
            this.ContadorAbstencion = 0;
            this.ContadorAfirmativo = 0;
            this.ContadorNegativo = 0;
            // Itero todos los Senadores
            for (int index = 0; index < this.Senadores.Count; index++)
            {
                // Duermo el hilo
                System.Threading.Thread.Sleep(2134);

                // Leo el senador actual
                KeyValuePair<string, EVoto> k = this.Senadores.ElementAt(index);
                // Generador de número aleatorio
                Random r = new Random(k.Key.ToString().Length + DateTime.Now.Millisecond);
                // Modifico el voto de forma aleatoria
                this.senadores[k.Key] = (EVoto)r.Next(0, 3);

                // Invocar Evento
                this.EventoVotoEfectuado(k.Key, this.senadores[k.Key]);
                // Incrementar contadores
                switch (k.Value)
                {
                    case EVoto.Afirmativo:
                        this.ContadorAfirmativo ++;
                        break;
                    case EVoto.Negativo:
                        this.ContadorNegativo ++;
                        break;
                    case EVoto.Abstencion:
                        this.ContadorAbstencion++;
                        break;
                }
                
            }
        }
    }
}
