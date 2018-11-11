using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio64
{
    class Caja
    {
        private List<string> filaClientes;

        public Caja()
        {
            this.filaClientes = new List<string>();
        }

        public List<string> FilaClientes
        {
            get
            {
                return this.filaClientes;
            }
        }

        public void AtenderClientes()
        {
            foreach (string cliente in filaClientes)
            {
                Random r = new Random(cliente.Length);
                int numero = r.Next(2000, 5000);
                Console.WriteLine(String.Format("{0}: {1} " + numero, Thread.CurrentThread.Name, cliente));
                Thread.Sleep(numero);

            }
        }

    }
}
