using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace Ejercicio61
{
    class PersonaDAO
    {
        private static SqlDataReader data;
        private static SqlConnection conexion;
        private static SqlCommand comando;

        public PersonaDAO()
        {
            conexion = new SqlConnection(@"Data Source= .\SQLEXPRESS;Initial Catalog= Ejercicio61;Integrated Security=True");
        }

        public static bool Guardar(Persona persona)
        {
            bool ok = true;

            try
            {
                conexion.Open();
                comando = new SqlCommand("INSERT INTO dbo.Persona (Nombre, Apellido) VALUES ('" + persona.Nombre + "','" + persona.Apellido + "')", conexion);
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                ok = false;
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

        public static List<Persona> Leer()
        {
            List<Persona> listaPersonas = new List<Persona>();

            try
            {
                conexion.Open();
                comando = new SqlCommand("SELECT * FROM Persona ID, Nombre, Apellido", conexion);
                data = comando.ExecuteReader();

                while (data.Read())
                {
                    Persona p = new Persona(int.Parse(data["ID"].ToString()), data["Nombre"].ToString(), data["Apellido"].ToString());
                    listaPersonas.Add(p);
                }

                data.Close();
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return listaPersonas;
        }

        public static Persona LeerPorId(int id)
        {
            Persona p = null;

            try
            {
                conexion.Open();
                comando = new SqlCommand("SELECT * FROM Persona WHERE ID = '" + id + "'", conexion);
                data = comando.ExecuteReader();

                if (data.Read())
                {
                    p = new Persona(int.Parse(data["ID"].ToString()), data["Nombre"].ToString(), data["Apellido"].ToString());
                }

                data.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return p;
        }

        public static bool Modificar(int id, string nombre, string apellido)
        {
            bool ok = true;

            try
            {
                conexion.Open();
                comando = new SqlCommand("UPDATE Persona SET Nombre = '" + nombre + "', Apellido = '" + apellido + "' WHERE ID = '" + id + "'", conexion);
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                ok = false;
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

        public static bool Borrar(int id)
        {
            bool ok = true;

            try
            {
                conexion.Open();
                comando = new SqlCommand("DELETE FROM Persona WHERE ID = '" + id + "'", conexion);
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                ok = false;
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



    }
}
