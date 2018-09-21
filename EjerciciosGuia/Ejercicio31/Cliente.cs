using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio31
{
    class Cliente
    {
        private string nombre;
        private int numero;

        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(int numero, string nombre): this(numero)
        {
            this.nombre = nombre;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }

            set
            {
                this.nombre = value;
            }

        }

        public int Numero
        {
            get
            {
                return this.numero;
            }
        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            bool ok = false;

            if(c1.Numero == c2.Numero)
            {
                ok = true;
            }

            return ok;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }




    }
}
