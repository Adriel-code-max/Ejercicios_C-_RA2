namespace CapaPresentacion
{
    public static class UserLoginCache
    {
        public static int IdUsuario { get; set; }
        public static string NombreUsuario { get; set; }
        public static string NombreCompleto { get; set; }
        public static string Rol { get; set; }
        public static int IdRol { get; set; }

        public static void Clear()
        {
            IdUsuario = 0;
            NombreUsuario = string.Empty;
            NombreCompleto = string.Empty;
            Rol = string.Empty;
            IdRol = 0;
        }
    }
}