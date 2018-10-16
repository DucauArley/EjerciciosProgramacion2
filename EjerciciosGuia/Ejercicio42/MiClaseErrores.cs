using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    class MiClaseErrores
    {
        public MiClaseErrores()
        {
            try
            {
                MetodoExcepcion();
            }
            catch (DivideByZeroException e)
            {
                throw e;
            }
        }


        public MiClaseErrores(int a)
        {
            try
            {
                new MiClaseErrores();
            }
            catch (DivideByZeroException e)
            {
                throw new UnaExcepcion("2do Constructor de Instancia Exception", e);
            }
        }



        public static void MetodoExcepcion()
        {
            try
            {
                int aux = 0;
                int resultado = 10 / aux;
            }
            catch (DivideByZeroException e)
            {
                throw e;
            }
            
        }
    }
}
