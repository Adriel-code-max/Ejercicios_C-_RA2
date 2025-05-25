using System;
using System.Data;
using Capa_Datos;

namespace Capa_Negocios
{
    public class CN_Categorias
    {
        private readonly CD_Categorias _datosCategorias = new CD_Categorias();

        public DataTable ObtenerCategorias()
        {
            try
            {
                return _datosCategorias.ObtenerCategorias();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener categorías: " + ex.Message);
            }
        }

        public void InsertarCategoria(string nombre, string descripcion)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre de la categoría no puede estar vacío.");

            try
            {
                _datosCategorias.InsertarCategoria(nombre, descripcion);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar categoría: " + ex.Message);
            }
        }

        public void ActualizarCategoria(int idCategoria, string nombre, string descripcion)
        {
            if (idCategoria <= 0)
                throw new ArgumentException("ID de categoría no válido.");
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre de la categoría no puede estar vacío.");

            try
            {
                _datosCategorias.ActualizarCategoria(idCategoria, nombre, descripcion);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar categoría: " + ex.Message);
            }
        }

        public void EliminarCategoria(int idCategoria)
        {
            if (idCategoria <= 0)
                throw new ArgumentException("ID de categoría no válido.");

            try
            {
                _datosCategorias.EliminarCategoria(idCategoria);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar categoría: " + ex.Message);
            }
        }

        public DataTable BuscarCategoria(string filtro)
        {
            if (string.IsNullOrWhiteSpace(filtro))
                throw new ArgumentException("El filtro de búsqueda no puede estar vacío.");

            try
            {
                return _datosCategorias.BuscarCategoria(filtro);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar categorías: " + ex.Message);
            }
        }
    }
}