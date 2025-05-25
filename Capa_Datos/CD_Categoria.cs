using System;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class CD_Categorias
    {
        private readonly CD_Conexion conexion = new CD_Conexion();

        /// <summary>
        /// Obtiene todas las categorías activas.
        /// </summary>
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

        /// <summary>
        /// Inserta una nueva categoría.
        /// </summary>
        public void InsertarCategoria(string nombre, string descripcion)
        {
            if (string.IsNullOrEmpty(nombre))
                throw new ArgumentException("El nombre de la categoría no puede estar vacío.");

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

        /// <summary>
        /// Actualiza una categoría existente.
        /// </summary>
        public void ActualizarCategoria(int idCategoria, string nombre, string descripcion)
        {
            if (string.IsNullOrEmpty(nombre))
                throw new ArgumentException("El nombre de la categoría no puede estar vacío.");

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

        /// <summary>
        /// Elimina una categoría (eliminación lógica).
        /// </summary>
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

        /// <summary>
        /// Busca categorías por nombre.
        /// </summary>
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