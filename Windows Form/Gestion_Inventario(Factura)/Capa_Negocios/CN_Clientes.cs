using System;
using System.Data;
using Capa_Datos;

namespace Capa_Negocios
{
    public class CN_Clientes
    {
        private readonly CD_Clientes datosClientes = new CD_Clientes();

        public DataTable ObtenerClientes()
        {
            return datosClientes.ObtenerClientes();
        }

        public void InsertarCliente(string nombre, string direccion, string telefono, string correo)
        {
            if (string.IsNullOrEmpty(nombre))
                throw new ArgumentException("El nombre del cliente no puede estar vacío.");

            datosClientes.InsertarCliente(nombre, direccion, telefono, correo);
        }

        public void ActualizarCliente(int idCliente, string nombre, string direccion, string telefono, string correo)
        {
            if (idCliente <= 0)
                throw new ArgumentException("ID de cliente no válido.");
            if (string.IsNullOrEmpty(nombre))
                throw new ArgumentException("El nombre del cliente no puede estar vacío.");

            datosClientes.ActualizarCliente(idCliente, nombre, direccion, telefono, correo);
        }

        public void EliminarCliente(int idCliente)
        {
            if (idCliente <= 0)
                throw new ArgumentException("ID de cliente no válido.");

            datosClientes.EliminarCliente(idCliente);
        }

        public DataTable BuscarCliente(string filtro)
        {
            if (string.IsNullOrEmpty(filtro))
                return ObtenerClientes();

            return datosClientes.BuscarCliente(filtro);
        }
    }
}