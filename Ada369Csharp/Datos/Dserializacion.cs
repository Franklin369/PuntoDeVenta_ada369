using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Ada369Csharp.CONEXION;
using Sunat.Logica;
namespace Ada369Csharp.Datos
{
    public class Dserializacion
    {
        public bool insertarSerializacion()
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("insertar_Serializacion", CONEXIONMAESTRA.conectar);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool editarSerializacion(Lserializacion parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("editar_serializacion", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@serie", parametros.Serie);
                cmd.Parameters.AddWithValue("@Cantidad_de_numeros", parametros.Cantidadnumeros);
                cmd.Parameters.AddWithValue("@numerofin", parametros.numerofin);
                cmd.Parameters.AddWithValue("@Tipo", parametros.tipodoc);
                cmd.Parameters.AddWithValue("@Id_serie", parametros.Id_serializacion);
                cmd.Parameters.AddWithValue("@Envioinmediato", parametros.Envioinmediato);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool editarCompDefecto(Lserializacion parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("editar_serializacion_POR_DEFECTO", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_serie", parametros.Id_serializacion);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public void mostrarSerializacion(ref DataTable dt)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("mostrarSerializacion", CONEXIONMAESTRA.conectar);
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
        public void ListarSerializacion(ref DataTable dt)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("SELECT  *,numerofin+1 as [Iniciara en] ,tipodoc as Comprobante,Por_defecto as [Por defecto],Envioinmediato as [Envio inmediato] FROM Serializacion", CONEXIONMAESTRA.conectar);
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
        public void MostrarNotacredito(ref DataTable dt)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("select * from Serializacion where Codigo='07'", CONEXIONMAESTRA.conectar);
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
        public void MostrarNotadebito(ref DataTable dt)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("select * from Serializacion where Codigo='08'", CONEXIONMAESTRA.conectar);
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
        public void ObtenerComprobanteDefecto(ref DataTable dt)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                var cmd = new SqlDataAdapter("select tipodoc,Id_serializacion,Envioinmediato from Serializacion Where Por_defecto='SI'", CONEXION.CONEXIONMAESTRA.conectar);
                cmd.Fill(dt);
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
