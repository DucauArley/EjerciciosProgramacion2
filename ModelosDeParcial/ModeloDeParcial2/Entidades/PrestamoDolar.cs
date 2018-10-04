using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoDolar:Prestamo
    {
        private PeriodicidadDePagos periodicidad;

        public PrestamoDolar(float monto, DateTime vencimiento, PeriodicidadDePagos periodicidad):base(monto, vencimiento)
        {
            this.periodicidad = periodicidad;
        }

        public PrestamoDolar(Prestamo prestamo, PeriodicidadDePagos periodicidad):this(prestamo.Monto, prestamo.Vencimiento, periodicidad)
        {
        }


        public float Interes
        {
            get
            {
                return CalcularInteres();
            }
        }

        public PeriodicidadDePagos Periodicidad
        {
            get
            {
                return this.periodicidad;
            }
        }

        private float CalcularInteres()
        {
            float retorno = 0;

            switch (this.periodicidad)
            {
                case PeriodicidadDePagos.Mensual:
                    retorno = (this.Monto * 25) / 100; 
                    break;
                case PeriodicidadDePagos.Bimestral:
                    retorno = (this.Monto * 35) / 100;
                    break;
                case PeriodicidadDePagos.Trimestral:
                    retorno = (this.Monto * 40) / 100;
                    break;
            }

            return retorno;
        }

        public override string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            string retorno;

            str.Append(base.Mostrar());
            str.AppendFormat("Periodicidad: {0}\n", this.Periodicidad);

            retorno = str.ToString();

            return retorno;
        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            double dias = (nuevoVencimiento - this.Vencimiento).TotalDays;

            this.monto = this.monto + (float)(dias * 2.50F);

            this.Vencimiento = nuevoVencimiento;
            
        }

        


    }
}
