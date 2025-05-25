using System;
using System.Data;
using Capa_Datos;

namespace Capa_Negocios
{
    public class CN_Productos
    {
        private readonly CD_Productos _datosProductos = new CD_Productos();

        public DataTable MostrarProductos()
        {
            try
            {
                return _datosProductos.MostrarProductos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener productos: " + ex.Message);
            }
        }

        public DataTable ObtenerProductosConDetalles()
        {
            try
            {
                return _datosProductos.ObtenerProductosConDetalles();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener productos con detalles: " + ex.Message);
            }
        }

        public void InsertarProducto(string nombre, string descripcion, decimal precio, int stock, int idCategoria, int idProveedor)
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre del producto no puede estar vacío.");
            if (precio <= 0)
                throw new ArgumentException("El precio debe ser mayor que cero.");
            if (stock < 0)
                throw new ArgumentException("El stock no puede ser negativo.");
            if (idCategoria <= 0)
                throw new ArgumentException("Debe seleccionar una categoría válida.");
            if (idProveedor <= 0)
                throw new ArgumentException("Debe seleccionar un proveedor válido.");

            try
            {
                _datosProductos.InsertarProducto(nombre, descripcion, precio, stock, idCategoria, idProveedor);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar producto: " + ex.Message);
            }
        }

        public void ActualizarProducto(int idProducto, string nombre, string descripcion, decimal precio, int stock, int idCategoria, int idProveedor)
        {
            // Validaciones
            if (idProducto <= 0)
                throw new ArgumentException("ID de producto no válido.");
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre del producto no puede estar vacío.");
            if (precio <= 0)
                throw new ArgumentException("El precio debe ser mayor que cero.");
            if (stock < 0)
                throw new ArgumentException("El stock no puede ser negativo.");
            if (idCategoria <= 0)
                throw new ArgumentException("Debe seleccionar una categoría válida.");
            if (idProveedor <= 0)
                throw new ArgumentException("Debe seleccionar un proveedor válido.");

            try
            {
                _datosProductos.ActualizarProducto(idProducto, nombre, descripcion, precio, stock, idCategoria, idProveedor);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar producto: " + ex.Message);
            }
        }

        public void EliminarProducto(int idProducto)
        {
            if (idProducto <= 0)
                throw new ArgumentException("ID de producto no válido.");

            try
            {
                _datosProductos.EliminarProducto(idProducto);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar producto: " + ex.Message);
            }
        }

        public DataTable BuscarProductos(string textoBusqueda)
        {
            if (string.IsNullOrWhiteSpace(textoBusqueda))
                throw new ArgumentException("El texto de búsqueda no puede estar vacío.");

            try
            {
                return _datosProductos.BuscarProducto(textoBusqueda);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar productos: " + ex.Message);
            }
        }
    }
}