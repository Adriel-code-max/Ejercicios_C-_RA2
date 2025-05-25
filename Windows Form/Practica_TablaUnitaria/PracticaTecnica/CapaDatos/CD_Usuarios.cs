using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Usuarios
    {
        private string connectionString = "Server=DESKTOP-FG1VE29;Database=Gestion_Iventario;Integrated Security=True;";

        public DataTable Login(string nombreUsuario, string contraseña)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                SqlCommand comando = new SqlCommand("sp_Login", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@Usuario", nombreUsuario);
                comando.Parameters.AddWithValue("@Contraseña", contraseña);

                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();

                conexion.Open();
                adapter.Fill(tabla);

                return tabla;
            }
        }






        public int RegistrarUsuario(string nombreUsuario, string contraseña, string nombreCompleto, int idRol)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                SqlCommand comando = new SqlCommand("sp_RegistrarUsuario", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                comando.Parameters.AddWithValue("@Contraseña", contraseña);
                comando.Parameters.AddWithValue("@NombreCompleto", nombreCompleto);
                comando.Parameters.AddWithValue("@IdRol", idRol);

                conexion.Open();
                return Convert.ToInt32(comando.ExecuteScalar());
            }
        }

        public bool ExisteUsuario(string nombreUsuario)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                SqlCommand comando = new SqlCommand(
                    "SELECT COUNT(*) FROM Usuarios WHERE NombreUsuario = @NombreUsuario",
                    conexion);

                comando.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);

                conexion.Open();
                int count = Convert.ToInt32(comando.ExecuteScalar());
                return count > 0;
            }
        }

        public DataTable ObtenerRoles()
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                SqlCommand comando = new SqlCommand("sp_ObtenerRoles", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();

                conexion.Open();
                adapter.Fill(tabla);

                return tabla;
            }
        }
    }
}