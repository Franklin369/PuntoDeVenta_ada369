using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Ada369Csharp.CONEXION
{
    class CONEXIONMAESTRA
    {
        public static string conexion = Convert.ToString ( CONEXION.Desencryptacion.checkServer());
        public static SqlConnection conectar = new SqlConnection(conexion);
        public static  void abrir()
        {
            if (conectar .State ==ConnectionState.Closed )
            {
                conectar.Open();
            }
        }
        public static  void cerrar()
        {
            if (conectar.State== ConnectionState.Open )
            {
                conectar.Close();
            }
        }
    }
}
