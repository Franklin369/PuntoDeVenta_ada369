using Ada369Csharp.CONEXION;
using Sunat.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ada369Csharp.Datos
{
    public class Dclientes
    {
        public bool insertar_clientes(Lclientes parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("insertar_clientes", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", parametros.Nombre);
                cmd.Parameters.AddWithValue("@Direccion", parametros.Direccion);
                cmd.Parameters.AddWithValue("@NmerDoc", parametros.Nrodoc);
                cmd.Parameters.AddWithValue("@Celular", parametros.Celular);
                cmd.Parameters.AddWithValue("@Estado", "ACTIVO");
                cmd.Parameters.AddWithValue("@Saldo", 0);
                cmd.Parameters.AddWithValue("@Tipodoc", parametros.Tipodoc);
                cmd.ExecuteNonQuery();
                return true;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }
        public void mostrarClienteStandar(ref int idcliente)
        {
            try
            {
                SqlCommand com = new SqlCommand("select idclientev from clientes where Nombre = '-'", CONEXIONMAESTRA.conectar);
               CONEXIONMAESTRA.abrir();
                idcliente = Convert.ToInt32(com.ExecuteScalar());
            }
            catch (Exception ex)
            {
                idcliente = 0;
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }
    }
}
