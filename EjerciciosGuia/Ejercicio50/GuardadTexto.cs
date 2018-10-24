using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio50
{
    class GuardadTexto<T, V>:IGuardar<T, V>
    {
        public bool Guardar(T obj)
        {
            return true;
        }

        public V Leer()
        {
            string texto;

            texto = "Texto leido";

            return (V) Convert.ChangeType(texto, typeof(V));
        }


    }
}
