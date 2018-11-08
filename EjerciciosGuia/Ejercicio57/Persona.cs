using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Ejercicio57
{
    public class Persona
    {
        private string nombre;
        private string apellido;

        public Persona()
        {

        }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public static bool Guardar(Persona p)
        {
            XmlSerializer ser = new XmlSerializer(typeof(Persona));
            XmlTextWriter texto = null;
            bool ok = true;

            try
            {
                texto = new XmlTextWriter("Persona.xml", null);
                ser.Serialize(texto, p);
            }
            catch (Exception)
            {
                ok = false;
            }
            finally
            {
                texto.Close();
            }
            
            return ok;

        }

        public static Persona Leer(string ruta)
        {
            XmlSerializer ser = new XmlSerializer(typeof(Persona));
            XmlTextReader texto = null;
            Persona retorno;

            try
            {
                texto = new XmlTextReader(ruta);
                retorno = (Persona)ser.Deserialize(texto);
            }
            catch (Exception)
            {
                retorno = null;
            }
            finally
            {
                texto.Close();
            }

            return retorno;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            string retorno;

            str.AppendLine("Nombre: " + this.nombre);
            str.AppendLine("Apellido: " + this.apellido);

            retorno = str.ToString();
            
            return retorno;
        }




    }
}
