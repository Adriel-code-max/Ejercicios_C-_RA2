using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using Capa_Datos;

namespace Capa_Negocios
{
    public class CN_Usuarios
    {
        private readonly CD_Usuarios _datosUsuarios = new CD_Usuarios();

        public DataTable Login(string nombreUsuario, string contraseña)
        {
            if (string.IsNullOrWhiteSpace(nombreUsuario))
                throw new ArgumentException("El nombre de usuario no puede estar vacío.");

            if (string.IsNullOrWhiteSpace(contraseña))
                throw new ArgumentException("La contraseña no puede estar vacía.");

            return _datosUsuarios.Login(nombreUsuario, contraseña);
        }

        public int RegistrarUsuario(string nombreUsuario, string contraseña, string nombreCompleto, int idRol)
        {
            if (string.IsNullOrWhiteSpace(nombreUsuario))
                throw new ArgumentException("El nombre de usuario no puede estar vacío.");
            if (string.IsNullOrWhiteSpace(contraseña))
                throw new ArgumentException("La contraseña no puede estar vacía.");
            if (contraseña.Length < 6)
                throw new ArgumentException("La contraseña debe tener al menos 6 caracteres.");
            if (string.IsNullOrWhiteSpace(nombreCompleto))
                throw new ArgumentException("El nombre completo no puede estar vacío.");
            if (idRol <= 0)
                throw new ArgumentException("Debe seleccionar un rol válido.");

            if (!Regex.IsMatch(nombreUsuario, @"^[a-zA-Z0-9_]+$"))
                throw new ArgumentException("El nombre de usuario solo puede contener letras, números y guiones bajos.");

            try
            {
                if (_datosUsuarios.ExisteUsuario(nombreUsuario))
                    throw new ArgumentException("El nombre de usuario ya está registrado.");

                return _datosUsuarios.RegistrarUsuario(nombreUsuario, contraseña, nombreCompleto, idRol);
            }
            catch (SqlException sqlEx)
            {
                throw new Exception("Error de base de datos: " + ObtenerMensajeErrorSQL(sqlEx.Number));
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar usuario: " + ex.Message);
            }
        }

        public DataTable ObtenerRoles()
        {
            try
            {
                return _datosUsuarios.ObtenerRoles();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener roles: " + ex.Message);
            }
        }

        private string ObtenerMensajeErrorSQL(int errorNumber)
        {
            switch (errorNumber)
            {
                case 2627: // Violación de clave única
                case 2601: // Violación de índice único
                    return "El nombre de usuario ya existe.";
                case 547:  // Error de restricción FK
                    return "El rol seleccionado no existe.";
                case 208:  // Objeto no existe
                    return "Error en la estructura de la base de datos.";
                default:
                    return $"Error de base de datos (Código: {errorNumber}).";
            }
        }
    }
}
