using System;
using System.Data.SqlClient;
using Capa_Datos;

namespace Capa_Negocios
{
    public class CN_Conexion
    {
        // Esta clase podría eliminarse ya que la conexión se maneja en la capa de datos
        // Pero la dejamos como ejemplo de prueba de conexión

        public static void ProbarConexion()
        {
            CD_Conexion conexion = new CD_Conexion();
            using (SqlConnection con = conexion.AbrirConexion())
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    Console.WriteLine("¡Conexión exitosa!");
                }
                else
                {
                    Console.WriteLine("La conexión no se pudo establecer.");
                }
            }
        }
    }
}