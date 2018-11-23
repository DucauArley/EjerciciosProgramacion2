using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml; 

namespace Archivos
{
    public class Xml<T>:IArchivo<T>
    {
        public void Guardar(string archivo, T datos)
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));
            XmlTextWriter texto = null;

            try
            {
                texto = new XmlTextWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + archivo + ".xml", null);
                ser.Serialize(texto, datos);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                texto.Close();
            }
        }

        public void Leer(string archivo, out T dato)
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));
            XmlTextReader texto = null;

            try
            {
                texto = new XmlTextReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + archivo + ".xml");
                dato = (T)ser.Deserialize(texto);
            }
            catch (Exception e)
            {
                dato = default(T);
                throw e;
            }
            finally
            {
                texto.Close();
            }

        }


    }
}
