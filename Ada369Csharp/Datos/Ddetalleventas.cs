using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ada369Csharp.CONEXION;
using Sunat.Logica;
using System.Data;
using System.Data.SqlClient;

namespace Ada369Csharp.Datos
{
    public class Ddetalleventas
    {
        public void MostrarDetalleVenta(ref DataTable dt, LdetalleVenta parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("mostrarDetalleventa", CONEXIONMAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@idventa", parametros.idventa);
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
        public bool insertarDetalleVenta(LdetalleVenta parametros)
        {
            try
            {

                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("insertarDetalleventa", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idventa", parametros.idventa);
                cmd.Parameters.AddWithValue("@Id_producto", parametros.Id_producto);
                cmd.Parameters.AddWithValue("@cantidad", parametros.cantidad);
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
        public void ContarprodDv(LdetalleVenta parametros, ref int contador)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("ContarprodDv", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idventa", parametros.idventa);
                contador = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                contador = 0;
                MessageBox.Show(ex.Message);

            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }
        public void SumarCantDv(LdetalleVenta parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                var cmd = new SqlCommand("editarDvsumar", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Iddv", parametros.iddetalle_venta);
                cmd.ExecuteNonQuery();
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
        public void EliminarDv(LdetalleVenta parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                var cmd = new SqlCommand("eliminar_detalle_venta", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@iddetalleventa", parametros.iddetalle_venta);
                cmd.ExecuteNonQuery();

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
        public void RestarCantDv(LdetalleVenta parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                var cmd = new SqlCommand("editarDvrestar", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Iddv", parametros.iddetalle_venta);
                cmd.Parameters.AddWithValue("@idventa", parametros.idventa);
                cmd.ExecuteNonQuery();
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
