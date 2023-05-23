using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Login
{
    class ConexionBD
    {
        string cadena = "Data Source= LAPTOP-B3J0O71O\\SQLEXPRESS;Initial Catalog=VS4_Historias_Medicas;Integrated Security=True";
        public SqlConnection conectarbd = new SqlConnection();

        public ConexionBD()
        {
            conectarbd.ConnectionString = cadena;
        }

        public void abrir()
        {
            try
            {
                conectarbd.Open();
                Console.WriteLine("conexion abierta");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
            }
        }
        public void cerrar()
        {
            conectarbd.Close();
        }
        // Método para validar el usuario, la contraseña y el rol
        public SqlDataReader Login(string usuario, string contraseña, string rol)
        {
            // Crear un comando SQL con los parámetros correspondientes
            SqlCommand cmd = new SqlCommand("Select * from Personal where Nombre_Usuario = @Nombre_Usuario and Contrasena_Usuario = @Contrasena_Usuario and Rol_Usuario=@Rol_Usuario", conectarbd);
            cmd.Parameters.AddWithValue("@Nombre_Usuario", usuario);
            cmd.Parameters.AddWithValue("@Contrasena_Usuario", contraseña);
            cmd.Parameters.AddWithValue("@Rol_Usuario", rol);

            // Ejecutar el comando y obtener un SqlDataReader
            SqlDataReader dr = cmd.ExecuteReader();

            // Devolver el SqlDataReader
            return dr;
        }

    }
}





