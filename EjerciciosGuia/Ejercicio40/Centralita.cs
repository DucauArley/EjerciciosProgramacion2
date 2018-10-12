using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio40
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        public float GananciaPorLocal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciaPorProvincia
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }

        public float GananciaPorTotal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }

        }


        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float retorno = 0;
            float sumaNumero = 0;

            foreach (Llamada llamada in this.listaDeLlamadas)
            {
                switch (tipo)
                {
                    case Llamada.TipoLlamada.Local:
                        if (llamada is Local)
                        {
                            sumaNumero = ((Local)llamada).CostoLlamada;
                            retorno = sumaNumero + retorno;
                        }
                        break;
                    case Llamada.TipoLlamada.Provincial:
                        if (llamada is Provincial)
                        {
                            sumaNumero = ((Provincial)llamada).CostoLlamada;
                            retorno = sumaNumero + retorno;
                        }
                        break;
                    case Llamada.TipoLlamada.Todas:
                        if (llamada is Provincial)
                        {
                            sumaNumero = ((Provincial)llamada).CostoLlamada;
                            retorno = sumaNumero + retorno;
                        }
                        else
                        {
                            if (llamada is Local)
                            {
                                sumaNumero = ((Local)llamada).CostoLlamada;
                                retorno = sumaNumero + retorno;
                            }
                        }
                        break;
                }
            }

            return retorno;
        }


        public override string ToString()
        {
            string retorno;
            StringBuilder str = new StringBuilder();

            str.AppendLine("Razon social: " + this.razonSocial);
            str.AppendLine("Ganancia total: " + GananciaPorTotal);
            str.AppendLine("Ganancias por llamadas locales: " + GananciaPorLocal);
            str.AppendLine("Ganancias por llamadas provinciales: " + GananciaPorProvincia);

            for (int i = 0; i < this.listaDeLlamadas.Count; i++)
            {
                str.AppendLine("" + this.listaDeLlamadas[i].ToString());

            }

            retorno = str.ToString();

            return retorno;
        }

        public void OrdenarLlamadas()
        {
            Llamada aux;
            for (int i = 0; i < this.listaDeLlamadas.Count - 1; i++)
            {
                for (int j = i + 1; j < this.listaDeLlamadas.Count; j++)
                {
                    if (Llamada.OrdenarPorDuracion(listaDeLlamadas[i], listaDeLlamadas[j]) == 1)
                    {
                        aux = listaDeLlamadas[i];
                        listaDeLlamadas[i] = listaDeLlamadas[j];
                        listaDeLlamadas[j] = aux;
                    }
                }
            }

        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.listaDeLlamadas.Add(nuevaLlamada);
        }

        public static bool operator ==(Centralita c, Llamada l)
        {
            bool ok = false;

            if (c.listaDeLlamadas.Contains(l))
            {
                ok = true;
            }

           return ok;
        }

        public static bool operator !=(Centralita c, Llamada l)
        {
            return !(c == l);
        }

        public static Centralita operator +(Centralita c, Llamada l)
        {
            if(c != l)
            {
                c.AgregarLlamada(l);
            }
            
            return c;
        }
        
    }
}
