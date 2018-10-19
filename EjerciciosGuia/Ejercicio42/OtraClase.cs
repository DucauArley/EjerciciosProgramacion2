using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    public class OtraClase
    {
        public void MiMetodoInstancia()
        {
            try
            {
                new MiClaseErrores(0);
            }
            catch (UnaExcepcion e)
            {
                MiExcepcion ex = new MiExcepcion("MiOtraClase Exception", e);
                throw ex;
            }
        }
        
    }
}
