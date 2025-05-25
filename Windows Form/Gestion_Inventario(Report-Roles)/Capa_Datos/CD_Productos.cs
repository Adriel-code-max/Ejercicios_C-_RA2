using System;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class CD_Productos
    {
        private readonly CD_Conexion conexion = new CD_Conexion();

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

        public void InsertarProducto(string nombre, string descripcion, decimal precio, int stock, int idCategoria, int idProveedor)
        {
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

        public void ActualizarProducto(int idProducto, string nombre, string descripcion, decimal precio, int stock, int idCategoria, int idProveedor)
        {
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

        public void EliminarProducto(int idProducto)
        {
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

        public DataTable BuscarProducto(string filtro)
        {
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

        public DataTable ObtenerProductosConDetalles()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("ObtenerProductosConDetalles", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(tabla);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al obtener productos con detalles: " + ex.Message);
            }
            return tabla;
        }
    }
}