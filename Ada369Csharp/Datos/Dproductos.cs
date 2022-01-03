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
    public class Dproductos
    {
        int idcaja;
        int idusuario;
        public void ObtenerdatosProductos(ref DataTable dt, Lproductos parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("ObtenerdatosProductos", CONEXIONMAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Idproducto", parametros.Id_Producto1);
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
        public void buscarProductos(ref DataTable dt, string buscador)
        {

            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("buscarProductos", CONEXIONMAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@buscador", buscador);
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
        public void mostrargrupos(ref DataTable dt, string buscador)
        {

            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("mostrar_grupos", CONEXIONMAESTRA.conectar);
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

        public bool aumentarStock(Lproductos parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("aumentarStock", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idproducto", parametros.Id_Producto1);
                cmd.Parameters.AddWithValue("@cantidad", parametros.Stock);
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
        private void ObtenerIdcaja()
        {
            var funcion = new Dcaja();
            funcion.ObtenerIdcaja(ref idcaja);
        }
        private void ObtenerIdusuario()
        {
            var funcion = new DiniciosSesion();
            funcion.mostrarInicioSesion(ref idusuario);
        }
        public bool InsertarProducto(Lproductos parametros)
        {
            try
            {
                ObtenerIdusuario();
                ObtenerIdcaja();
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("insertar_Producto", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Descripcion", parametros.Descripcion);
                cmd.Parameters.AddWithValue("@Id_grupo", parametros.Id_grupo);
                cmd.Parameters.AddWithValue("@Usa_inventarios", parametros.Usa_inventarios);
                cmd.Parameters.AddWithValue("@Stock", parametros.Stock);
                cmd.Parameters.AddWithValue("@Precio_de_compra", parametros.Precio_de_compra);
                cmd.Parameters.AddWithValue("@Fecha_de_vencimiento", parametros.Fecha_de_vencimiento);
                cmd.Parameters.AddWithValue("@Precio_de_venta", parametros.Precio_de_venta);
                cmd.Parameters.AddWithValue("@Codigo", parametros.Codigo);
                cmd.Parameters.AddWithValue("@Se_vende_a", parametros.Se_vende_a);
                cmd.Parameters.AddWithValue("@Stock_minimo", parametros.Stock_minimo);
                cmd.Parameters.AddWithValue("@Precio_mayoreo", parametros.Precio_mayoreo);
                cmd.Parameters.AddWithValue("@A_partir_de", parametros.A_partir_de);
                cmd.Parameters.AddWithValue("@CodigoSunat", parametros.CodigoSunat);
                cmd.Parameters.AddWithValue("@CodUm", parametros.CodUm);
                //Kardex
                cmd.Parameters.AddWithValue("@Fecha", DateTime.Now);
                cmd.Parameters.AddWithValue("@Motivo", "Registro inicial de Producto");
                cmd.Parameters.AddWithValue("@Cantidad", parametros.Cantidad);
                cmd.Parameters.AddWithValue("@Id_usuario", idusuario);
                cmd.Parameters.AddWithValue("@Tipo", "ENTRADA");
                cmd.Parameters.AddWithValue("@Estado", "CONFIRMADO");
                cmd.Parameters.AddWithValue("@Id_caja", idcaja);
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
        public bool EliminarProducto(Lproductos parametros)
        {
            try
            {
                ObtenerIdusuario();
                ObtenerIdcaja();
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("eliminar_Producto1", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", parametros.Id_Producto1);
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
        public void mostrarProdXid(ref DataTable dt, Lproductos parametros)
        {

            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("mostrarProdXid", CONEXIONMAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Idproducto", parametros.Id_Producto1);
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
        public bool Editarproductos(Lproductos parametros)
        {
            try
            {
                ObtenerIdusuario();
                ObtenerIdcaja();
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("editar_Producto1", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Producto1", parametros.Id_Producto1);
                cmd.Parameters.AddWithValue("@Descripcion", parametros.Descripcion);
                cmd.Parameters.AddWithValue("@Id_grupo", parametros.Id_grupo);
                cmd.Parameters.AddWithValue("@Usa_inventarios", parametros.Usa_inventarios);
                cmd.Parameters.AddWithValue("@Stock", parametros.Stock);
                cmd.Parameters.AddWithValue("@Precio_de_compra", parametros.Precio_de_compra);
                cmd.Parameters.AddWithValue("@Fecha_de_vencimiento", parametros.Fecha_de_vencimiento);
                cmd.Parameters.AddWithValue("@Precio_de_venta", parametros.Precio_de_venta);
                cmd.Parameters.AddWithValue("@Codigo", parametros.Codigo);
                cmd.Parameters.AddWithValue("@Se_vende_a", parametros.Se_vende_a);
                cmd.Parameters.AddWithValue("@Stock_minimo", parametros.Stock_minimo);
                cmd.Parameters.AddWithValue("@Precio_mayoreo", parametros.Precio_mayoreo);
                cmd.Parameters.AddWithValue("@A_partir_de", parametros.A_partir_de);
                cmd.Parameters.AddWithValue("@CodigoSunat", parametros.CodigoSunat);
                cmd.Parameters.AddWithValue("@CodUm", parametros.CodUm);
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
        public void ReporteInventarios(ref DataTable dt)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("RptInventariostodos", CONEXIONMAESTRA.conectar);
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
        public  void ReporteInvBajoMin(ref DataTable dt)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("ReporteInvBajoMin", CONEXIONMAESTRA.conectar);
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
        public void ReporteProductoBajoMinimo(ref DataTable dt)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("ReporteProductoBajoMinimo", CONEXIONMAESTRA.conectar);
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
        public bool disminuirStock(Lproductos parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("disminuir_stock", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idproducto", parametros.Id_Producto1);
                cmd.Parameters.AddWithValue("@cantidad", parametros.Cantidad);
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {

                //MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }
    }
}
