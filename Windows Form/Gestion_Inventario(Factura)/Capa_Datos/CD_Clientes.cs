using System;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class CD_Clientes
    {
        private readonly CD_Conexion conexion = new CD_Conexion();

        public DataTable ObtenerClientes()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("ObtenerClientes", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(tabla);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al obtener clientes: " + ex.Message);
            }
            return tabla;
        }

        public void InsertarCliente(string nombre, string direccion, string telefono, string correo)
        {
            try
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("InsertarCliente", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Direccion", string.IsNullOrEmpty(direccion) ? (object)DBNull.Value : direccion);
                        cmd.Parameters.AddWithValue("@Telefono", string.IsNullOrEmpty(telefono) ? (object)DBNull.Value : telefono);
                        cmd.Parameters.AddWithValue("@Correo", string.IsNullOrEmpty(correo) ? (object)DBNull.Value : correo);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al insertar cliente: " + ex.Message);
            }
        }

        public void ActualizarCliente(int idCliente, string nombre, string direccion, string telefono, string correo)
        {
            try
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("ActualizarCliente", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Direccion", string.IsNullOrEmpty(direccion) ? (object)DBNull.Value : direccion);
                        cmd.Parameters.AddWithValue("@Telefono", string.IsNullOrEmpty(telefono) ? (object)DBNull.Value : telefono);
                        cmd.Parameters.AddWithValue("@Correo", string.IsNullOrEmpty(correo) ? (object)DBNull.Value : correo);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al actualizar cliente: " + ex.Message);
            }
        }

        public void EliminarCliente(int idCliente)
        {
            try
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("EliminarCliente", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al eliminar cliente: " + ex.Message);
            }
        }

        public DataTable BuscarCliente(string filtro)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("BuscarCliente", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Filtro", filtro);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(tabla);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al buscar clientes: " + ex.Message);
            }
            return tabla;
        }
    }
}