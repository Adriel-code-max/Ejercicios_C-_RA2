using System;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class CD_Productos
    {
        private readonly CD_Conexion conexion = new CD_Conexion();

        /// <summary>
        /// Obtiene todos los productos activos con detalles de categoría y proveedor.
        /// </summary>
        public DataTable MostrarProductos()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("MostrarProductos", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(tabla);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al obtener productos: " + ex.Message);
            }
            return tabla;
        }

        /// <summary>
        /// Inserta un nuevo producto.
        /// </summary>
        public void InsertarProducto(string nombre, string descripcion, decimal precio, int stock, int idCategoria, int idProveedor)
        {
            if (string.IsNullOrEmpty(nombre))
                throw new ArgumentException("El nombre del producto no puede estar vacío.");
            if (precio <= 0)
                throw new ArgumentException("El precio debe ser mayor que cero.");
            if (stock < 0)
                throw new ArgumentException("El stock no puede ser negativo.");

            try
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("InsertarProducto", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                        cmd.Parameters.AddWithValue("@Precio", precio);
                        cmd.Parameters.AddWithValue("@Stock", stock);
                        cmd.Parameters.AddWithValue("@IdCategoria", idCategoria);
                        cmd.Parameters.AddWithValue("@IdProveedor", idProveedor);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al insertar producto: " + ex.Message);
            }
        }

        /// <summary>
        /// Actualiza un producto existente.
        /// </summary>
        public void ActualizarProducto(int idProducto, string nombre, string descripcion, decimal precio, int stock, int idCategoria, int idProveedor)
        {
            if (idProducto <= 0)
                throw new ArgumentException("El ID del producto no es válido.");
            if (string.IsNullOrEmpty(nombre))
                throw new ArgumentException("El nombre del producto no puede estar vacío.");
            if (precio <= 0)
                throw new ArgumentException("El precio debe ser mayor que cero.");
            if (stock < 0)
                throw new ArgumentException("El stock no puede ser negativo.");

            try
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("ActualizarProducto", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdProducto", idProducto);
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                        cmd.Parameters.AddWithValue("@Precio", precio);
                        cmd.Parameters.AddWithValue("@Stock", stock);
                        cmd.Parameters.AddWithValue("@IdCategoria", idCategoria);
                        cmd.Parameters.AddWithValue("@IdProveedor", idProveedor);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al actualizar producto: " + ex.Message);
            }
        }

        /// <summary>
        /// Elimina un producto (eliminación lógica).
        /// </summary>
        public void EliminarProducto(int idProducto)
        {
            if (idProducto <= 0)
                throw new ArgumentException("El ID del producto no es válido.");

            try
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("EliminarProducto", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdProducto", idProducto);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al eliminar producto: " + ex.Message);
            }
        }

        /// <summary>
        /// Busca productos por nombre o descripción.
        /// </summary>
        public DataTable BuscarProducto(string filtro)
        {
            if (string.IsNullOrEmpty(filtro))
                throw new ArgumentException("El filtro de búsqueda no puede estar vacío.");

            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("BuscarProducto", conn))
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
                throw new Exception("Error al buscar productos: " + ex.Message);
            }
            return tabla;
        }
    }
}