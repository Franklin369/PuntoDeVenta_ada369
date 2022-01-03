using Ada369Csharp.CONEXION;
using Ada369Csharp.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ada369Csharp.Datos
{
   public class Dcaja
    {
        string serialPC;
        public void mostrarCajaSerial(ref int idcaja)
        {
            try
            {
                Bases.Obtener_serialPC(ref serialPC);
                CONEXIONMAESTRA.abrir();
                SqlCommand da = new SqlCommand("mostrarCajaSerial", CONEXIONMAESTRA.conectar);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@Serial", serialPC);
                idcaja = Convert.ToInt32(da.ExecuteScalar());
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
        public void mostrarCajaSerialTable(ref DataTable dt)
        {
            try
            {
                Bases.Obtener_serialPC(ref serialPC);
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("mostrarCajaSerial", CONEXIONMAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Serial", serialPC);
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

        public void ObtenerIdcaja(ref int idcaja)
        {
            try
            {
                Bases.Obtener_serialPC(ref serialPC);
                CONEXIONMAESTRA.abrir();
                SqlCommand com = new SqlCommand("mostrar_cajas_por_Serial_de_DiscoDuro", CONEXIONMAESTRA.conectar);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Serial", serialPC);
                idcaja =Convert.ToInt32( com.ExecuteScalar());



            }
            catch (Exception ex)
            {
                idcaja = 0;
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();

            }
        }
        public void Mostrarcajaremota(ref DataTable dt)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("Mostrar_caja_remota", CONEXIONMAESTRA.conectar);
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
        public void Mostrarcajaprincipal(ref DataTable dt)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("Mostrar_caja_principal", CONEXIONMAESTRA.conectar);
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
        public void MostrarImprTicket(ref DataTable dt)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("select Impresora_Ticket from Caja", CONEXIONMAESTRA.conectar);
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
    }
}
