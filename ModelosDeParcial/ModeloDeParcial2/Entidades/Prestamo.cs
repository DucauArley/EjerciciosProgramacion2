using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public enum PeriodicidadDePagos
    {
        Mensual,
        Bimestral,
        Trimestral
    }

    public enum TipoDePrestamo
    {
        Pesos,
        Dolares,
        Todos
    }


    public abstract class Prestamo
    {
        protected float monto;
        protected DateTime vencimiento;

        public Prestamo(float monto, DateTime vencimiento)
        {
            this.monto = monto;
            Vencimiento = vencimiento;
        }

        public float Monto
        {
            get
            {
                return this.monto;
            }
        }

        public DateTime Vencimiento
        {
            get
            {
                return this.vencimiento;
            }

            set
            {
                if(DateTime.Now < value)
                {
                    this.vencimiento = value;
                }
                else
                {
                    this.vencimiento = DateTime.Now;
                }
            }
            
        }


        public virtual string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            string retorno;

            str.AppendLine("Monto: " + Monto);
            str.AppendLine("Vencimiento: " + Vencimiento);

            retorno = str.ToString();

            return retorno;
        }


        public static int OrdenarPorFecha(Prestamo p1, Prestamo p2)
        {
            int retorno;

            if(p1.Vencimiento == p2.Vencimiento)
            {
                retorno = 0;
            }
            else
            {
                if(p1.Vencimiento > p2.Vencimiento)
                {
                    retorno = 1;
                }
                else
                {
                    retorno = -1;
                }
            }

            return retorno;
        }

        public abstract void ExtenderPlazo(DateTime nuevoVencimiento);
        
    }
}
