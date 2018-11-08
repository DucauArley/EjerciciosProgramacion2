using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

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
            FileStream archivo = null;
            BinaryFormatter ser = new BinaryFormatter();
            bool ok = true;

            try
            {
                archivo = new FileStream("Persona.bin", FileMode.Create);
                ser.Serialize(archivo, p);
            }
            catch (Exception e)
            {
                ok = false;
                throw e;
            }
            finally
            {
                if (!object.ReferenceEquals(archivo, null))
                {
                    archivo.Close();
                }
            }

            return ok;
        }

        public static Persona Leer(string ruta)
        {
            Persona retorno;
            BinaryFormatter ser = new BinaryFormatter();
            FileStream archivo = null;

            try
            {
                archivo = new FileStream("Persona.bin", FileMode.Open);
                retorno = (Persona)ser.Deserialize(archivo);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (!object.ReferenceEquals(archivo, null))
                {
                    archivo.Close();
                }
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
