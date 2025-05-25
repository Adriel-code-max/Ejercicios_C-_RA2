using CapaDatos;
using System;
using System.Data;

namespace CapaNegocio
{
    public class CN_Usuarios
    {
        private CD_Usuarios cd_usuarios = new CD_Usuarios();

        public DataTable Login(string nombreUsuario, string contraseña)
        {
            try
            {
                if (string.IsNullOrEmpty(nombreUsuario))
                    throw new ArgumentException("El nombre de usuario no puede estar vacío");

                if (string.IsNullOrEmpty(contraseña))
                    throw new ArgumentException("La contraseña no puede estar vacía");

                DataTable resultado = cd_usuarios.Login(nombreUsuario, contraseña);

                if (resultado.Rows.Count == 0)
                    throw new Exception("Usuario o contraseña incorrectos");

                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en capa de negocio: " + ex.Message);
            }
        }

        public int RegistrarUsuario(string nombreUsuario, string contraseña, string nombreCompleto, int idRol)
        {
            try
            {
                // Validaciones
                if (string.IsNullOrEmpty(nombreUsuario))
                    throw new ArgumentException("El nombre de usuario no puede estar vacío");

                if (string.IsNullOrEmpty(contraseña))
                    throw new ArgumentException("La contraseña no puede estar vacía");

                if (contraseña.Length < 4)
                    throw new ArgumentException("La contraseña debe tener al menos 4 caracteres");

                if (string.IsNullOrEmpty(nombreCompleto))
                    throw new ArgumentException("El nombre completo no puede estar vacío");

                if (idRol <= 0)
                    throw new ArgumentException("Debe seleccionar un rol válido");

                // Verificar si el usuario ya existe
                if (cd_usuarios.ExisteUsuario(nombreUsuario))
                    throw new ArgumentException("El nombre de usuario ya está en uso");

                // Registrar el usuario
                return cd_usuarios.RegistrarUsuario(nombreUsuario, contraseña, nombreCompleto, idRol);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en capa de negocio: " + ex.Message);
            }
        }

        public DataTable ObtenerRoles()
        {
            try
            {
                return cd_usuarios.ObtenerRoles();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los roles: " + ex.Message);
            }
        }
    }
}