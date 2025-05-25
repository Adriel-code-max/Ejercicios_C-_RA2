using System;
using System.Data;
using Capa_Datos;

namespace Capa_Negocios
{
    public class CN_Productos
    {
        private readonly CD_Productos _datosProductos = new CD_Productos();

        /// <summary>
        /// Obtiene todos los productos activos con detalles de categoría y proveedor.
        /// </summary>
        public DataTable MostrarProductos()
        {
            try
            {
                return _datosProductos.MostrarProductos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener productos en la capa de negocios: " + ex.Message);
            }
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
            if (idCategoria <= 0)
                throw new ArgumentException("La categoría no es válida.");
            if (idProveedor <= 0)
                throw new ArgumentException("El proveedor no es válido.");

            try
            {
                _datosProductos.InsertarProducto(nombre, descripcion, precio, stock, idCategoria, idProveedor);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar producto en la capa de negocios: " + ex.Message);
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
            if (idCategoria <= 0)
                throw new ArgumentException("La categoría no es válida.");
            if (idProveedor <= 0)
                throw new ArgumentException("El proveedor no es válido.");

            try
            {
                _datosProductos.ActualizarProducto(idProducto, nombre, descripcion, precio, stock, idCategoria, idProveedor);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar producto en la capa de negocios: " + ex.Message);
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
                _datosProductos.EliminarProducto(idProducto);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar producto en la capa de negocios: " + ex.Message);
            }
        }

        /// <summary>
        /// Busca productos por nombre o descripción.
        /// </summary>
        public DataTable BuscarProductos(string textoBusqueda)
        {
            if (string.IsNullOrEmpty(textoBusqueda))
                throw new ArgumentException("El texto de búsqueda no puede estar vacío.");

            try
            {
                return _datosProductos.BuscarProducto(textoBusqueda);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar productos en la capa de negocios: " + ex.Message);
            }
        }
    }
}