using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class Conexion
    {
        private static string dbUser = "DESKTOP-9LV57DI\\SQLEXPRESS";
        private static string db = "etps4_rrhh";
        string cadena = $"Data Source = {dbUser}; Initial Catalog = {db}; Integrated Security = True";

        SqlConnection objConexion = new SqlConnection();

        public Conexion ()
        {
            objConexion.ConnectionString = cadena;
        }

        public void abrir() { 
            try
            {
                objConexion.Open();
                Console.WriteLine("Conexion establecida");
            } catch (Exception e)
            {
                Console.WriteLine("Error con la BD " + e.Message);
            }
        }

        public void cerrar ()
        {
            objConexion.Close();
        }
    }
}
