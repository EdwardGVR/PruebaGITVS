using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1.DAL
{
    class ConexionDAL
    {
        private static string dbUser = "DESKTOP-9LV57DI\\SQLEXPRESS";
        private static string db = "etps4_rrhh";
        string cadena = $"Data Source = {dbUser}; Initial Catalog = {db}; Integrated Security = True";
        SqlConnection objConexion = new SqlConnection();

        public bool conexion() {
            try
            {
                objConexion.ConnectionString = cadena;

                SqlCommand comando = new SqlCommand();
                comando.CommandText = "SELLECT * FROM prioridades_requisitos";
                comando.Connection = objConexion;
                objConexion.Open();
                comando.ExecuteNonQuery();
                objConexion.Close();

                return true;

            } catch (Exception e) {
                Console.WriteLine("Error con la base de datos" + e.Message);
                return false;
            }
        }

        public void abrir()
        {
            try
            {
                objConexion.Open();
                Console.WriteLine("Conexion establecida");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error con la BD " + e.Message);
            }
        }

        public void cerrar()
        {
            objConexion.Close();
        }
    }
}
