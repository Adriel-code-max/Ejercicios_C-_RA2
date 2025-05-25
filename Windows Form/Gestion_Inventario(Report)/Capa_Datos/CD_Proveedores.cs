using System;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class CD_Proveedores
    {
        private readonly CD_Conexion conexion = new CD_Conexion();

        /// <summary>
        /// Obtiene todos los proveedores activos.
        /// </summary>
        public DataTable ObtenerProveedores()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("ObtenerProveedores", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(tabla);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al obtener proveedores: " + ex.Message);
            }
            return tabla;
        }

        /// <summary>
        /// Inserta un nuevo proveedor.
        /// </summary>
        public void InsertarProveedor(string nombre, string telefono, string correo, string direccion)
        {
            if (string.IsNullOrEmpty(nombre))
                throw new ArgumentException("El nombre del proveedor no puede estar vacío.");

            try
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("InsertarProveedor", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Telefono", telefono);
                        cmd.Parameters.AddWithValue("@Correo", correo);
                        cmd.Parameters.AddWithValue("@Direccion", direccion);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al insertar proveedor: " + ex.Message);
            }
        }

        /// <summary>
        /// Actualiza un proveedor existente.
        /// </summary>
        public void ActualizarProveedor(int idProveedor, string nombre, string telefono, string correo, string direccion)
        {
            if (string.IsNullOrEmpty(nombre))
                throw new ArgumentException("El nombre del proveedor no puede estar vacío.");

            try
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("ActualizarProveedor", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdProveedor", idProveedor);
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Telefono", telefono);
                        cmd.Parameters.AddWithValue("@Correo", correo);
                        cmd.Parameters.AddWithValue("@Direccion", direccion);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al actualizar proveedor: " + ex.Message);
            }
        }

        /// <summary>
        /// Elimina un proveedor (eliminación lógica).
        /// </summary>
        public void EliminarProveedor(int idProveedor)
        {
            try
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("EliminarProveedor", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdProveedor", idProveedor);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al eliminar proveedor: " + ex.Message);
            }
        }

        /// <summary>
        /// Busca proveedores por nombre.
        /// </summary>
        public DataTable BuscarProveedor(string filtro)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("BuscarProveedor", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Texto", filtro);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(tabla);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al buscar proveedores: " + ex.Message);
            }
            return tabla;
        }
    }
}