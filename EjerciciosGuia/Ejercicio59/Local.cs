using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Ejercicio59
{
    class Local:Llamada, IGuardar<string>
    {
        protected float costo;
        private string rutaArchivo;

        public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
        {
            this.costo = costo;
        }


        public Local(Llamada llamada, float costo) : this(llamada.NumeroOrigen, llamada.Duracion, llamada.NumeroDestino, costo)
        {
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

        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        protected override string Mostrar()
        {
            string retorno;
            StringBuilder str = new StringBuilder();

            str.Append(base.Mostrar());
            str.AppendLine("Costo de la llamada: " + this.costo);

            retorno = str.ToString();

            return retorno;
        }

        private float CalcularCosto()
        {
            float costoLLamada;

            costoLLamada = this.Duracion * this.costo;

            return costoLLamada;
        }

        public override bool Equals(object obj)
        {
            bool ok = false;

            if (obj is Local)
            {
                ok = true;
            }

            return ok;
        }

        public override string ToString()
        {
            string retorno;

            retorno = this.Mostrar();

            return retorno;
        }

        public bool Guardar()
        {
            XmlSerializer ser = new XmlSerializer(typeof(Llamada));
            XmlTextWriter str = null;
            bool ok = true;

            try
            {
                str = new XmlTextWriter("Local.xml", null);
                ser.Serialize(str, this);
            }
            catch(Exception e)
            {
                ok = false;
                throw e;
            }
            finally
            {
                str.Close();
            }

            return ok;
        }

        public string Leer()
        {
            XmlSerializer ser = new XmlSerializer(typeof(Llamada));
            XmlTextReader str = null;
            Llamada llamada = null;
            string retorno = "";

            try
            {
                str = new XmlTextReader("Local.xml");
                llamada =(Llamada) ser.Deserialize(str);

                if(llamada is Local)
                {
                    retorno = llamada.ToString();
                }
                else
                {
                    throw new InvalidCastException();
                }
            }
            catch(InvalidCastException e)
            {
                throw e;
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                str.Close();
            }

            return retorno;
        }
    }
}
