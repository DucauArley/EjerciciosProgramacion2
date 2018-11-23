using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Archivos
{
    public class Sql:IArchivo<Queue<Patente>>
    {
        private SqlCommand sqlCommand;
        private SqlConnection sqlConnection;

        public Sql()
        {
            sqlConnection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=patentes-sp-2018;Integrated Security=True");
        }

        public void Guardar(string tabla, Queue<Patente> datos)
        {
            try
            {
                foreach (Patente p in datos)
                {
                    sqlConnection.Open();
                    sqlCommand = new SqlCommand("INSERT INTO " + tabla + " (patente, tipo) VALUES ('" +p.CodigoPatente +"','" + p.TipoCodigo +  "')", sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }          
        }

        public void Leer(string tabla, out Queue<Patente> datos)
        {
            SqlDataReader data;
            Queue<Patente> queue = null;

            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("SELECT * FROM "+ tabla +" patente, tipo", sqlConnection);
                data = sqlCommand.ExecuteReader();

                while (data.Read())
                {
                    Patente p = new Patente(data["patente"].ToString(), (Patente.Tipo) data["tipo"]);
                    queue.Enqueue(p);
                }

                datos = queue;
                data.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }

    }
}
