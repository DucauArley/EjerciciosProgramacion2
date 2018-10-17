using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio36
{
    class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private TipoCompetencia tipo;

        private Competencia()
        {
            competidores = new List<VehiculoDeCarrera>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo) : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
            this.tipo = tipo;
        }

        public short CantidadCompetidores
        {
            get
            {
                return this.cantidadCompetidores;
            }

            set
            {
                this.cantidadCompetidores = value;
            }
        }

        public short CantidadVueltas
        {
            get
            {
                return this.cantidadVueltas;
            }

            set
            {
                this.cantidadVueltas = value;
            }
        }
        
        public VehiculoDeCarrera this[int i]
        {
            get
            {
                return this.competidores[i];
            }
        }

        public TipoCompetencia Tipo
        {
            get
            {
                return this.tipo;
            }

            set
            {
                this.tipo = value;
            }
        }

        public string MostrarDatos()
        {
            StringBuilder str = new StringBuilder();
            string retorno;

            str.AppendLine("Cantidad de competidores: " + this.cantidadCompetidores);
            str.AppendLine("Cantidad de vueltas: " + this.cantidadVueltas);

            foreach (VehiculoDeCarrera v in this.competidores)
            {
                str.Append(v.MostrarDatos());
            }

            retorno = str.ToString();

            return retorno;
        }

        public static bool operator ==(Competencia c, VehiculoDeCarrera v)
        {
            bool ok = false;

            for (int i = 0; i < c.competidores.Count; i++)
            {
                if (v == c.competidores.ElementAt(i))
                {
                    ok = true;
                    break;
                }
            }

            return ok;
        }

        public static bool operator !=(Competencia c, VehiculoDeCarrera v)
        {
            return !(c == v);
        }

        public static bool operator +(Competencia c, VehiculoDeCarrera v)
        {
            bool ok = false;
            Random ran = new Random();

            

            if (c != v && c.competidores.Count < c.cantidadCompetidores)
            {

                switch (c.tipo)
                {
                    case TipoCompetencia.F1:
                        if(v is AutoF1)
                        {
                            c.competidores.Add(v);
                            v.EnCompetencia = true;
                            v.VueltasRestantes = c.cantidadVueltas;
                            v.CantidadCombustible = (short)ran.Next(15, 100);
                        }
                        break;
                    case TipoCompetencia.MotoCross:
                        if(v is MotoCross)
                        {
                            c.competidores.Add(v);
                            v.EnCompetencia = true;
                            v.VueltasRestantes = c.cantidadVueltas;
                            v.CantidadCombustible = (short)ran.Next(15, 100);
                        }
                        break;
                }
                
                ok = true;
            }

            return ok;
        }

        public static bool operator -(Competencia c, VehiculoDeCarrera v)
        {
            bool ok = false;

            if (c == v)
            {
                c.competidores.Remove(v);
                ok = true;
            }

            return ok;
        }

        public enum TipoCompetencia
        {
            F1,
            MotoCross
        }

    }
}
