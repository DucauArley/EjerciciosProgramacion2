using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio54
{
    public static class ArchivoTexto
    {
        public static void Guardar(string path, string texto)
        {
            StreamWriter archivo = new StreamWriter(path, true);
            archivo.Write(texto);
            archivo.Close();
        }

        public static string Leer(string path)
        {
            try
            {
                StreamReader archivo = new StreamReader(path);
                string retorno;

                retorno = archivo.ReadToEnd();

                archivo.Close();

                return retorno;
            }
            catch(FileNotFoundException e)
            {
                throw e;
            }
        }






    }
}
