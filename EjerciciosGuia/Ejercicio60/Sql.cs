using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ejercicio60
{
    class Sql
    {
        private SqlDataReader data;
        private SqlConnection conexion;
        private SqlCommand comando;
        
        public Sql()
        {
            try
            {
                this.conexion = new SqlCommand("Data Source=LAB3PC14\SQLEXPRESS;Initial Catalog=AdventureWorks2012;Integrated Security=True");
                conexion.Open();
                MessageBox.Show("Se conecto al sql");
            }
            catch(Exception e)
            {
                MessageBox.Show("No se pudo conectar al sql" + e.ToString());
            }
        }

        public string agregar(string nombre)
        {
            string retorno = "Se agrego correctamente";

            try
            {
                this.comando = new SqlCommand("INSERT INTO Production.Location (Name) VALUES ('" + nombre + "')", conexion);
                this.comando.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                retorno = "No se pudo conectar " + e.ToString();
            }
            
            return retorno;
        }

        public string Eliminar(string nombre)
        {
            string retorno = "Se pudo eliminar correctamente";
            try
            {
                comando = new SqlCommand("DELETE FROM Production.Location WHERE Name = '" + nombre + "'", conexion);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                retorno = "No se pudo conectar: " + ex.ToString();
            }

            return retorno;          
        }

        public string Modificar(string nombre, string nuevoNombre)
        {
            string retorno = "Se modifico correctamente";
            try
            {
                comando = new SqlCommand("UPDATE Production.Location SET Name = '" + nuevoNombre + "' WHERE Name = '" + nombre + "'", conexion);
                comando.ExecuteNonQuery(); 
            }
            catch (Exception e)
            {
                retorno = "No se pudo conectar: " + e.ToString();
            }

            return retorno;
        }

        public int RegisteredPerson(string nombre)
        {
            int contador = 0;

            try
            {
                comando = new SqlCommand("SELECT * FROM Production.Location WHERE Name = '" + nombre + "'", conexion);
                data = comando.ExecuteReader();
                while (data.Read())
                {
                    contador++;
                }
                data.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo hacer la consulta: " + ex.ToString());
            }

            return contador;
        }


    }
}
