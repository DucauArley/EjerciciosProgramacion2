using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace Entidades
{
    class Dao<T>:IArchivo<T>
    {
        private SqlDataReader data;
        private SqlConnection conexion;
        private SqlCommand comando;

        public Dao()
        {
            conexion = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Parcial;Integrated Security=True");
        }

        public bool Guardar(string archivo, T objeto)
        {
            bool ok = true;

            try
            {
                conexion.Open();
                comando = new SqlCommand("INSERT INTO " + archivo +  "(Nombre, Apellido) VALUES ('" + objeto + "')", conexion);//Esto es relativo dependiendo que pida el parcial
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                ok = false;
                throw e;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return ok;
            
        }

        public T Leer(string archivo)
        {
            T retorno = default(T);

            try
            {
                conexion.Open();
                comando = new SqlCommand("SELECT * FROM " + archivo + " WHERE(Nombre, Apellido) = ('Juan, Carlos')", conexion);//Esto es relativo dependiendo que pida el parcial
                data = comando.ExecuteReader();

                if (data.Read())
                {
                    //retorno = data;Tambien es relativo
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return retorno;
        }

    }
}
