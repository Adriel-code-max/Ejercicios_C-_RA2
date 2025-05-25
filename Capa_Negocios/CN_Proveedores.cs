using System.Data;
using Capa_Datos;

namespace Capa_Negocios
{
    public class CN_Proveedores
    {
        private readonly CD_Proveedores data = new CD_Proveedores();

        public DataTable ObtenerProveedores()
        {
            return data.ObtenerProveedores();
        }


        public DataTable BuscarProveedor(string filtro)
        {
            return data.BuscarProveedor(filtro);
        }

        public void InsertarProveedor(string nombre, string telefono, string correo, string direccion)
        {
            data.InsertarProveedor(nombre, telefono, correo, direccion);
        }

        public void ActualizarProveedor(int idProveedor, string nombre, string telefono, string correo, string direccion)
        {
            data.ActualizarProveedor(idProveedor, nombre, telefono, correo, direccion);
        }

        public void EliminarProveedor(int idProveedor)
        {
            data.EliminarProveedor(idProveedor);
        }
    }
}
    
