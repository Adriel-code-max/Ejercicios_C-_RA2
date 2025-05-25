using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using System.Data.SqlClient;

namespace Capa_Negocios
{
    public class CN_Conexion
    {
        static void Main()
        {
            CD_Conexion conexion = new CD_Conexion();
            SqlConnection con = conexion.AbrirConexion();

            if (con.State == System.Data.ConnectionState.Open)
            {
                Console.WriteLine("¡Conexión exitosa!");
            }

            conexion.CerrarConexion(con);


            try
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
            catch (Exception ex)
            {

                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {

                conexion.CerrarConexion(con);
            }

        }



    }
}
