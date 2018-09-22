using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio31
{
    class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        private Negocio()
        {
            clientes = new Queue<Cliente>();
            caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }

        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }
         
        public static bool operator ==(Negocio n, Cliente c)
        {
            bool ok = false;

            for (int i = 0; i < n.clientes.Count; i++)
            {
                if (n.clientes.Contains(c))
                {
                    ok = true;
                }
            }


            return ok;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }


        public static bool operator +(Negocio n, Cliente c)
        {
            bool ok = false;

            if(n != c)
            {
                n.clientes.Enqueue(c);
                ok = true;
            }

            return ok;
        }

        public static bool operator ~(Negocio n)
        {
            bool ok = false;

            if (n.caja.Atender(n.Cliente))
            {
                ok = true;
            }
            
            return ok;
        }


        public Cliente Cliente
        {
            get
            {
                return this.clientes.First();
            }

            set
            {
                if (!this.clientes.Contains(value))
                {
                    this.clientes.Enqueue(value);
                }
            }


        }


    }
}
