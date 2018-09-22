using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio33
{
    class Libro
    {

        private List<string> paginas;

        public Libro()
        {
            paginas = new List<string>();
        }


        public string this[int i]
        {
            get
            {
                string retorno = "";

                if(i < paginas.Count)
                {
                    retorno = paginas.ElementAt(i);
                }
                
                return retorno;
            }

            set
            {
                if(i > paginas.Count)
                {
                    paginas.Add(value);
                }
                else
                {
                    paginas.Insert(i, value);
                }
                
            }

        }

        
    }
}
