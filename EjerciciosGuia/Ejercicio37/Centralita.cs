using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio37
{
    class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa):this()
        {
            this.razonSocial = nombreEmpresa;
        }


        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float retorno = 0;
            float sumaNumero = 0;

            for (int i = 0; i < listaDeLlamadas.Count; i++)
            {
                switch (tipo)
                {
                    case Llamada.TipoLlamada.Local:
                        sumaNumero = ((Local)listaDeLlamadas[i]).CostoLlamada;
                        retorno = sumaNumero + retorno;
                        break;
                    case Llamada.TipoLlamada.Provincial:
                        sumaNumero = ((Provincial)listaDeLlamadas[i]).CostoLlamada;
                        retorno = sumaNumero + retorno;
                        break;
                    case Llamada.TipoLlamada.Todas:
                        if(listaDeLlamadas[i] is Provincial)
                        {
                            sumaNumero = ((Provincial)listaDeLlamadas[i]).CostoLlamada;
                            retorno = sumaNumero + retorno;
                        }
                        else
                        {
                            if(listaDeLlamadas[i] is Local)
                            {
                                sumaNumero = ((Local)listaDeLlamadas[i]).CostoLlamada;
                                retorno = sumaNumero + retorno;
                            }
                        }
                        break;
                }
                 
            }

            return retorno;
        }





    }
}
