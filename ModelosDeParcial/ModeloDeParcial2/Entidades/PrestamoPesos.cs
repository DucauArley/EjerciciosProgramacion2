using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoPesos :Prestamo
    {
        private float porcentajeInteres;

        public PrestamoPesos(float monto, DateTime vencimiento, float intereses):base(monto, vencimiento)
        {
            this.porcentajeInteres = intereses;
        }

        public PrestamoPesos(Prestamo prestamo, float porcentajeIntereses):this(prestamo.Monto, prestamo.Vencimiento, porcentajeIntereses)
        {
        }

        public float Interes
        {
            get
            {
                return CalcularIntereses();
            }
        }


        private float CalcularIntereses()
        {
            float retorno;

            retorno = (this.Monto * this.porcentajeInteres) / 100;

            return retorno;
        }

        public override string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            string retorno;

            str.Append(base.Mostrar());
            str.AppendFormat("Intereses: {0}\n", this.Interes);

            retorno = str.ToString();

            return retorno;
        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            double dias = (nuevoVencimiento - this.Vencimiento).TotalDays;

            this.porcentajeInteres = this.porcentajeInteres + (float) (dias * 0.25F);

            this.Vencimiento = nuevoVencimiento;
        }


    }
}
