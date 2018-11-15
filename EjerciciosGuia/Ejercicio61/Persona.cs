using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio61
{
    class Persona
    {
        private int id;
        private string nombre;
        private string apellido;

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public Persona(int id, string nombre, string apellido):this(nombre, apellido)
        {
            this.id = id;
        }

        public int ID
        {
            get
            {
                return this.id;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }
        
    }
}
