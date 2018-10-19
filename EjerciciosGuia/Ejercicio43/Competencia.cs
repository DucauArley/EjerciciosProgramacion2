using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio43
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

            if (c.competidores.Contains(v))
            {
                ok = true;
            }
            
            if (ok == false)
            {
                throw new CompetenciaNoDisponibleExcepcion("El vehiculo no corresponde a la competencia", c.GetType().Name, "Sobrecarga de ==");
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
                        try
                        {
                            if (v is AutoF1)
                            {
                                ok = true;
                                v.EnCompetencia = true;
                                v.VueltasRestantes = c.cantidadVueltas;
                                v.CantidadCombustible = (short)ran.Next(15, 100);
                                c.competidores.Add(v);
                            }
                        }
                        catch (CompetenciaNoDisponibleExcepcion e)
                        {
                            throw new CompetenciaNoDisponibleExcepcion("Competencia Incorrecta", c.GetType().Name, "Operator +", e);
                        }
                        break;
                    case TipoCompetencia.MotoCross:
                        try
                        {
                            if (v is MotoCross)
                            {
                                ok = true;
                                v.EnCompetencia = true;
                                v.VueltasRestantes = c.cantidadVueltas;
                                v.CantidadCombustible = (short)ran.Next(15, 100);
                                c.competidores.Add(v);
                            }
                        }
                        catch (CompetenciaNoDisponibleExcepcion e)
                        {
                            throw new CompetenciaNoDisponibleExcepcion("Competencia Incorrecta", c.GetType().Name, "Operator +", e);
                        }
                        break;
                }
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
