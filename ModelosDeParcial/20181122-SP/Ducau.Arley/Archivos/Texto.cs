using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Entidades;

namespace Archivos
{
    public class Texto:IArchivo<Queue<Patente>>
    {
        public void Guardar(string archivo, Queue<Patente> datos)
        {
            StreamWriter texto = null;
            try
            {
                texto = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + archivo + ".txt", false);

                foreach (Patente p in datos)
                {
                    texto.Write(p.CodigoPatente + "\n");
                }
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

        public void Leer(string archivo, out Queue<Patente> datos)
        {
            StreamReader texto = null;
            Queue<Patente> cola = null;

            try
            {
                texto = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + archivo + ".txt");

                while (!texto.EndOfStream)
                {
                    Patente p = PatenteStringExtension.ValidarPatente(texto.ReadLine());
                    cola.Enqueue(p);
                }

                datos = cola;
            }
            catch (Exception e)
            {
                datos = null;
                throw e;
            }
            finally
            {
                texto.Close();
            }
        }

    }
}
