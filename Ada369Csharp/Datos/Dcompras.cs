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
   public class Dcompras
    {
        int Idcaja;
        public bool Insertar_Compras(Ldetallecompra parametros)
        {
            try
            {
                var funcion = new Dcaja();
                funcion.ObtenerIdcaja(ref Idcaja);
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("Insertar_Compras", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fechacompra", DateTime.Now);
                cmd.Parameters.AddWithValue("@Cantidad", parametros.Cantidad);
                cmd.Parameters.AddWithValue("@Costo", parametros.Costo);
                cmd.Parameters.AddWithValue("@Moneda", parametros.Moneda);
                cmd.Parameters.AddWithValue("@IdProducto", parametros.IdProducto);
                cmd.Parameters.AddWithValue("@Descripcion", parametros.Descripcion);
                cmd.Parameters.AddWithValue("@Estado", parametros.Estado);
                cmd.Parameters.AddWithValue("@Idcaja", Idcaja);
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
        public void MostrarUltimoIdcompra(ref int idcompra)
        {

            try
            {
                var funcion = new Dcaja();
                funcion.ObtenerIdcaja(ref Idcaja);
                CONEXIONMAESTRA.abrir();
                SqlCommand com = new SqlCommand("MostrarUltimoIdcompra", CONEXIONMAESTRA.conectar);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Idcaja", Idcaja);
                idcompra = Convert.ToInt32(com.ExecuteScalar());
            }
            catch (Exception ex)
            {
                idcompra = 0;
                MessageBox.Show(ex.StackTrace);

            }
            finally
            {
                CONEXIONMAESTRA.cerrar();

            }
        }
        public bool eliminarComprasvacias()
        {
            try
            {
                var funcion = new Dcaja();
                funcion.ObtenerIdcaja(ref Idcaja);
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("eliminarComprasvacias", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Idcaja", Idcaja);

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
        public bool confirmarCompra(Lcompras parametros)
        {
            try
            {
                var funcion = new Dcaja();
                funcion.ObtenerIdcaja(ref Idcaja);
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("confirmarCompra", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Idcompra", parametros.Idcompra);
                cmd.Parameters.AddWithValue("@Total", parametros.Total);
                cmd.Parameters.AddWithValue("@Idcaja", Idcaja);
                cmd.Parameters.AddWithValue("@Idproveedor", parametros.IdProveedor);
                cmd.Parameters.AddWithValue("@fechacompra", DateTime.Now);
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
        public void buscarCompras(ref DataTable dt, string buscador)
        {

            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("buscarCompras", CONEXIONMAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@buscar", buscador);
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
