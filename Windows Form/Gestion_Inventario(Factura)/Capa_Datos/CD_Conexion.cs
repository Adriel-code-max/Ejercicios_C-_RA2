using System;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class CD_Conexion
    {
        private readonly string cadenaConexion = "Server=DESKTOP-FG1VE29;Database=SistemaFacturacion;Integrated Security=True;";

        public SqlConnection AbrirConexion()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
            return conexion;
        }

        public void CerrarConexion(SqlConnection conexion)
        {
            if (conexion?.State == System.Data.ConnectionState.Open)
                conexion.Close();
        }
    }
}