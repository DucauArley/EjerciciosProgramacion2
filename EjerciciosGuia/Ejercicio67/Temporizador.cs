using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio67
{
    class Temporizador
    {
        private Thread hilo;
        private int intervalo;

        public delegate void EncargadoTiempo();
        public event EncargadoTiempo EventoTiempo;

        public Temporizador(int intervalo)
        {
            this.intervalo = intervalo;
        }

        public bool Activar
        {
            get
            {
                bool ok = false; 
                if (hilo != null && hilo.IsAlive == true)
                {
                    ok = true;
                }
                return ok;
            }

            set
            {
                if ((value == true && hilo == null) || (value == true && hilo != null && hilo.IsAlive == false))
                {
                    hilo = new Thread(Corriendo);
                    hilo.Start();
                }
                else
                {
                    if (value == false && hilo != null && hilo.IsAlive == true)
                    {
                        hilo.Abort();
                    }
                }
            }
        }

        public int Intervalo
        {
            get
            {
                return this.intervalo;
            }

            set
            {
                this.intervalo = value;
            }
        }

        private void Corriendo()
        {
            while (true)
            {
                EventoTiempo();
                Thread.Sleep(this.Intervalo);
            }
        }
        
    }
}
