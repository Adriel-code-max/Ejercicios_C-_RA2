using System;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class CD_Categorias
    {
        private readonly CD_Conexion conexion = new CD_Conexion();

        public DataTable ObtenerCategorias()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("ObtenerCategorias", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(tabla);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al obtener categorías: " + ex.Message);
            }
            return tabla;
        }

        public void InsertarCategoria(string nombre, string descripcion)
        {
            try
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("InsertarCategoria", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al insertar categoría: " + ex.Message);
            }
        }

        public void ActualizarCategoria(int idCategoria, string nombre, string descripcion)
        {
            try
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("ActualizarCategoria", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdCategoria", idCategoria);
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al actualizar categoría: " + ex.Message);
            }
        }

        public void EliminarCategoria(int idCategoria)
        {
            try
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("EliminarCategoria", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdCategoria", idCategoria);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al eliminar categoría: " + ex.Message);
            }
        }

        public DataTable BuscarCategoria(string filtro)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("BuscarCategoria", conn))
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
                throw new Exception("Error al buscar categorías: " + ex.Message);
            }
            return tabla;
        }
    }
}