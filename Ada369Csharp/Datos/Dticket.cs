using Ada369Csharp.CONEXION;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunat.Logica;
namespace Ada369Csharp.Datos
{
    public class Dticket
    {
        public void mostrarTicket(ref DataTable dt,Lticket parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("ReporteTicket", CONEXIONMAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Idventa", parametros.Idventa);
                da.SelectCommand.Parameters.AddWithValue("@Totalletra", parametros.Totalletras);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }
        public void mostrar(ref DataTable dt)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("select * from Ticket", CONEXIONMAESTRA.conectar);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }
        public bool Editarticket(Lticket parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("editarTicket", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre_de_Moneda", parametros.Nombre_de_Moneda);
                cmd.Parameters.AddWithValue("@Agradecimiento", parametros.Agradecimiento);
                cmd.Parameters.AddWithValue("@pagina_Web_Facebook", parametros.pagina_Web_Facebook);
                cmd.Parameters.AddWithValue("@Anuncio", parametros.Anuncio);
                cmd.Parameters.AddWithValue("@Datos_fiscales_de_autorizacion", parametros.Datos_fiscales_de_autorizacion);
                cmd.Parameters.AddWithValue("@Por_defecto", parametros.Por_defecto);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return true;
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }
    }
}
