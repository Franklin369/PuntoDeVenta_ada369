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
   public class Ddetallecompra
    {
        public void mostrar_DetalleCompra(ref DataTable dt, Ldetallecompra parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("mostrar_DetalleCompra", CONEXIONMAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Idcompra", parametros.IdCompra);
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
        public bool eliminar_detalle_compra(Ldetallecompra parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("eliminar_detalle_compra", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@iddetallecompra", parametros.IdDetallecompra);
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
        public bool editar_detalle_compra_Cantidad(Ldetallecompra parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("editar_detalle_compra_Cantidad", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_producto", parametros.IdProducto);
                cmd.Parameters.AddWithValue("@cantidad", parametros.Cantidad);
                cmd.Parameters.AddWithValue("@Idcompra", parametros.IdCompra);
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
        public bool editar_detalle_compra_Precio(Ldetallecompra parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("editar_detalle_compra_Precio", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_producto", parametros.IdProducto);
                cmd.Parameters.AddWithValue("@precio", parametros.Costo);
                cmd.Parameters.AddWithValue("@Idcompra", parametros.IdCompra);
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

    }
}
