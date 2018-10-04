using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrestamosPersonales;

namespace EntidadFinanciera
{
    public class Financiera
    {
        private List<Prestamo> listaDePrestamos;
        private string razonSocial;

        private Financiera()
        {
            listaDePrestamos = new List<Prestamo>();
        }

        public Financiera(string razonSocial) : this()
        {
            this.razonSocial = razonSocial;
        }

        public float InteresesEnDolares
        {
            get
            {
                return CalcularInteresesGanados(TipoDePrestamo.Dolares);
            }
        }

        public float InteresesEnPesos
        {
            get
            {
                return CalcularInteresesGanados(TipoDePrestamo.Pesos);
            }
        }

        public float InteresesTotales
        {
            get
            {
                return CalcularInteresesGanados(TipoDePrestamo.Todos);
            }
        }

        public List<Prestamo> ListaDePrestamos
        {
            get
            {
                return this.listaDePrestamos;
            }
        }

        public string RazonSocial
        {
            get
            {
                return this.razonSocial;
            }
        }

        private float CalcularInteresesGanados(TipoDePrestamo tipoPrestamo)
        {
            float retorno = 0;

            foreach (Prestamo p in ListaDePrestamos)
            {
                switch (tipoPrestamo)
                {
                    case TipoDePrestamo.Dolares:
                        if (p is PrestamoDolar)
                        {
                            retorno = retorno + ((PrestamoDolar)p).Interes;
                        }
                        break;
                    case TipoDePrestamo.Pesos:
                        if (p is PrestamoPesos)
                        {
                            retorno = retorno + ((PrestamoPesos)p).Interes;
                        }
                        break;
                    case TipoDePrestamo.Todos:
                        if (p is PrestamoDolar)
                        {
                            retorno = retorno + ((PrestamoDolar)p).Interes;
                        }

                        if (p is PrestamoPesos)
                        {
                            retorno = retorno + ((PrestamoPesos)p).Interes;
                        }
                        break;
                }
            }

            return retorno;
        }

        public void OrdenarPrestamos()
        {
            listaDePrestamos.Sort(Prestamo.OrdenarPorFecha);
        }

        public static string Mostrar(Financiera financiera)
        {
            string retorno;

            retorno = (string)financiera;

            return retorno;
        }


        public static explicit operator string(Financiera financiera)
        {
            StringBuilder str = new StringBuilder();
            string retorno;

            str.AppendLine("Razon social: " + financiera.RazonSocial);
            str.AppendLine("Intereses totales ganados: " + financiera.InteresesTotales);
            str.AppendLine("Intereses por prestamos en pesos: " + financiera.InteresesEnPesos);
            str.AppendFormat("Intereses por prestamos en dolares: {0} \n\n", financiera.InteresesEnDolares);

            financiera.OrdenarPrestamos();

            foreach (Prestamo p in financiera.listaDePrestamos)
            {
                str.AppendLine(p.Mostrar());
            }

            retorno = str.ToString();

            return retorno;
        }

        public static bool operator ==(Financiera financiera, Prestamo Prestamo)
        {
            bool ok = false;

            if (financiera.listaDePrestamos.Contains(Prestamo))
            {
                ok = true;
            }

            return ok;
        }

        public static bool operator !=(Financiera financiera, Prestamo prestamo)
        {
            return !(financiera == prestamo);
        }

        public static Financiera operator +(Financiera financiera, Prestamo prestamo)
        {
            if(financiera != prestamo)
            {
                financiera.listaDePrestamos.Add(prestamo);
            }

            return financiera;
        }



    }
}
