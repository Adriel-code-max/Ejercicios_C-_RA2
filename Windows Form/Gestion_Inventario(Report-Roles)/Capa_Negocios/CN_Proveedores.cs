using System;
using System.Data;
using Capa_Datos;

namespace Capa_Negocios
{
    public class CN_Proveedores
    {
        private readonly CD_Proveedores _datosProveedores = new CD_Proveedores();

        public DataTable ObtenerProveedores()
        {
            try
            {
                return _datosProveedores.ObtenerProveedores();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener proveedores: " + ex.Message);
            }
        }

        public void InsertarProveedor(string nombre, string telefono, string correo, string direccion)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre del proveedor no puede estar vacío.");

            try
            {
                _datosProveedores.InsertarProveedor(nombre, telefono, correo, direccion);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar proveedor: " + ex.Message);
            }
        }

        public void ActualizarProveedor(int idProveedor, string nombre, string telefono, string correo, string direccion)
        {
            if (idProveedor <= 0)
                throw new ArgumentException("ID de proveedor no válido.");
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre del proveedor no puede estar vacío.");

            try
            {
                _datosProveedores.ActualizarProveedor(idProveedor, nombre, telefono, correo, direccion);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar proveedor: " + ex.Message);
            }
        }

        public void EliminarProveedor(int idProveedor)
        {
            if (idProveedor <= 0)
                throw new ArgumentException("ID de proveedor no válido.");

            try
            {
                _datosProveedores.EliminarProveedor(idProveedor);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar proveedor: " + ex.Message);
            }
        }

        public DataTable BuscarProveedor(string filtro)
        {
            if (string.IsNullOrWhiteSpace(filtro))
                throw new ArgumentException("El filtro de búsqueda no puede estar vacío.");

            try
            {
                return _datosProveedores.BuscarProveedor(filtro);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar proveedores: " + ex.Message);
            }
        }
    }
}
