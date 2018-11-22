using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class SerializarXml<T>:IArchivo<T>
    {
        public bool Guardar(string archivo, T objeto)
        {
            bool ok = true;
            XmlSerializer ser = new XmlSerializer(typeof(T));
            XmlTextWriter texto = null;

            try
            {
                texto = new XmlTextWriter(archivo, null);
                ser.Serialize(texto, objeto);
            }
            catch (Exception)
            {
                ok = false;
                throw new ErrorArchivoException("No se pudo guardar el archivo");
            }
            finally
            {
                texto.Close();
            }

            return ok;
        }

        public T Leer(string archivo)
        {
            T retorno;
            XmlSerializer ser = new XmlSerializer(typeof(T));
            XmlTextReader lector = null;

            try
            {
                lector = new XmlTextReader(archivo);
                retorno = (T) ser.Deserialize(lector);
            }
            catch (Exception)
            {
                throw new ErrorArchivoException("No se pudo guardar el archivo");
            }
            finally
            {
                lector.Close();
            }

            return retorno;
        }


    }
}
