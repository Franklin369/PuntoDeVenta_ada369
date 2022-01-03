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
   public class Dkardex
    {
        int idusuario;
        int idcaja;
        public void MostrarInicioSesion()
        {
            var funcion = new DiniciosSesion();
            funcion.mostrarInicioSesion(ref idusuario);
        }
        public void MostrarIdcajaserial()
        {
            var funcion = new Dcaja();
            funcion.ObtenerIdcaja(ref idcaja);
        }
        public bool insertar_KARDEX_Entrada(LKardex parametros)
        {
            try
            {
                MostrarInicioSesion();
                MostrarIdcajaserial();
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("insertar_KARDEX_Entrada", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Fecha", parametros.Fecha);
                cmd.Parameters.AddWithValue("@Motivo", parametros.Motivo);
                cmd.Parameters.AddWithValue("@Cantidad", parametros.Cantidad);
                cmd.Parameters.AddWithValue("@Id_producto", parametros.Id_producto);
                cmd.Parameters.AddWithValue("@Id_usuario", idusuario);
                cmd.Parameters.AddWithValue("@Tipo", "ENTRADA");
                cmd.Parameters.AddWithValue("@Estado", "DESPACHO CONFIRMADO");
                cmd.Parameters.AddWithValue("@Id_caja", idcaja);
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
        public void BuscarprodInvent(ref DataTable dt,string buscador)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                var da = new SqlDataAdapter("BuscarprodInvent", CONEXIONMAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@buscador",buscador);
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
        public void ReportKardexMov(ref DataTable dt, LKardex parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                var da = new SqlDataAdapter("ReportKardexMov", CONEXIONMAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@idProducto", parametros.Id_producto);
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
        public void mostrarInventarios(ref DataTable dt)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                var da = new SqlDataAdapter("RptInventariostodos", CONEXIONMAESTRA.conectar);
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

    }
}
