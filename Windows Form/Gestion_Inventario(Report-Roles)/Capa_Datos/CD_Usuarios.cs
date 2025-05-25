using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;


namespace Capa_Datos
{
    public class CD_Usuarios
    {
        private readonly CD_Conexion conexion = new CD_Conexion();

        public DataTable Login(string nombreUsuario, string contraseña)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_Login", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                        cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(tabla);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error en base de datos: " + ex.Message);
            }
            return tabla;
        }

        




        public int RegistrarUsuario(string nombreUsuario, string contraseña, string nombreCompleto, int idRol)
        {
            try
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_RegistrarUsuario", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                        cmd.Parameters.AddWithValue("@Contraseña", contraseña);
                        cmd.Parameters.AddWithValue("@NombreCompleto", nombreCompleto);
                        cmd.Parameters.AddWithValue("@IdRol", idRol);

                        SqlParameter outputIdParam = new SqlParameter("@IdUsuarioResultado", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(outputIdParam);

                        cmd.ExecuteNonQuery();

                        return Convert.ToInt32(outputIdParam.Value);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al registrar usuario: " + ex.Message);
            }
        }

        public DataTable ObtenerRoles()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ObtenerRoles", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(tabla);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al obtener roles: " + ex.Message);
            }
            return tabla;
        }

        public bool ExisteUsuario(string nombreUsuario)
        {
            try
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ExisteUsuario", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al verificar usuario: " + ex.Message);
            }
        }

    }
}