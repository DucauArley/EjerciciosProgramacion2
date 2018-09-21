using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio31
{
    class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;

        private PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto) : this()
        {
            this.puesto = puesto;
        }

        public static int NumeroActual
        {
            get
            {
                numeroActual = numeroActual + 1;

                return numeroActual;
            }
        } 

        public bool Atender(Cliente cli)
        {
            bool ok = false;

            Thread.Sleep(8000);
            
            return ok;
        }

        public enum Puesto
        {
            Caja1,
            Caja2
        }

    }
}
