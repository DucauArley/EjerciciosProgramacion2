using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio47
{
    class Torneo<T> where T: Equipo
    {
        private List<T> equipos;
        private string nombre;

        public static bool operator ==(Torneo<T> t, Equipo e)
        {
            bool ok = false;

            if (t.equipos.Contains(e))
            {
                ok = true;
            }

            return ok;
        }

        public static bool operator !=(Torneo<T> t, Equipo e)
        {
            return !(t == e);
        }

        public static Torneo<T> operator +(Torneo<T> t, Equipo e)
        {
            if(t != e)
            {
                t.equipos.Add(e);
            }

            return t;
        }


    }
}
