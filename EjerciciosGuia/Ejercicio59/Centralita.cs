﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio59
{
    class Centralita:IGuardar<string>
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;
        private string rutaArchivo;

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        public string RutaDeArchivo
        {
            get
            {
                return this.rutaArchivo;
            }

            set
            {
                this.rutaArchivo = value;
            }
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

        public bool Guardar()
        {
            bool ok = true;

            try
            {
                StreamWriter str = new StreamWriter(this.RutaDeArchivo);
                str.Write(this.ToString());
                str.Close();
            }
            catch (Exception e)
            {
                ok = false;
            }

            return ok;
        }

        public string Leer()
        {
            string retorno = "";

            StreamReader str = new StreamReader(this.RutaDeArchivo);
            retorno = str.ReadToEnd();
            str.Close();

            return retorno;
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
            if (c != l)
            {
                c.AgregarLlamada(l);

                if (c.Guardar() == false)
                {
                    throw new FallaLogException("No se pudo guardar.", "Centralita", "Operator +");
                }

            }
            else
            {
                throw new CentralitaExcepcion("La llamada ya se encuentra en la centralita", c.GetType().Name, "Operador +");
            }

            return c;
        }
    }
}
