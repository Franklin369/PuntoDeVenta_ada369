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
    public class Dventas
    {
        int Idcaja;
        int Idusuario;
        string TrabajarconImp;
        double Porcentajeimp;
        int contadorProd;
        private void ObtenerIdcaja()
        {
            var funcion = new Dcaja();
            funcion.ObtenerIdcaja(ref Idcaja);
        }
        private void ObtenerIdusuario()
        {
            var funcion = new DiniciosSesion();
            funcion.mostrarInicioSesion(ref Idusuario);
        }
        public void mostrarVentasXidcaja(ref DataTable dt)
        {
            try
            {
                ObtenerIdcaja();

                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("mostrarVentasXidcaja", CONEXIONMAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Id_caja", Idcaja);
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
        public void MostrarventasPend(ref DataTable dt,string codigo)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("MostrarventasPend", CONEXIONMAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Codigo", codigo);
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
        public void MostrarResumendiarioPendiente(ref DataTable dt, string fecha)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("MostrarResumendiario", CONEXIONMAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@fecha", fecha);
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

        public void MostrarBoletaspendientes(ref DataTable dt)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("MostrarBoletaspendientes", CONEXIONMAESTRA.conectar);
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
        public void mostrarVentasXidventa(ref DataTable dt, Lventas parametros)
        {
            try
            {

                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("mostrarVentasXidventa", CONEXIONMAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Idventa", parametros.idventa);
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
        public void buscarVentas(ref DataTable dt, string buscador)
        {
            try
            {

                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("buscarVentas", CONEXIONMAESTRA.conectar);
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
        public void buscarFacturas(ref DataTable dt, string buscador,string codigoCompro)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("buscarFacturasBoletas", CONEXIONMAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@buscador", buscador);
                da.SelectCommand.Parameters.AddWithValue("@Codigo", codigoCompro);
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


        public bool insertarVenta(ref int idventaGenerada)
        {
            try
            {
                ObtenerIdcaja();
                ObtenerIdusuario();
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("insertar_venta", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_usuario", Idusuario);
                cmd.Parameters.AddWithValue("@Idcaja", Idcaja);
                idventaGenerada = Convert.ToInt32(cmd.ExecuteScalar());
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
        private void ObtenerImpuesto()
        {
            var dt = new DataTable();
            var funcion = new Dempresa();
            funcion.mostrar_empresa(ref dt);
            TrabajarconImp = dt.Rows[0][5].ToString();
            if (TrabajarconImp == "SI")
            {
                Porcentajeimp = Convert.ToDouble(dt.Rows[0][3]);
            }
            else
            {
                Porcentajeimp = 0;
            }
        }
        private void ContarProdDv(int idventa)
        {
            var funcion = new Ddetalleventas();
            var parametros = new LdetalleVenta();
            parametros.idventa = idventa;
            funcion.ContarprodDv(parametros, ref contadorProd);
        }
        public bool confirmarVenta(Lventas parametros)
        {
            try
            {
                ObtenerImpuesto();
                ObtenerIdcaja();
                ObtenerIdusuario();
                ContarProdDv(parametros.idventa);
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("Confirmar_venta", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idventa", parametros.idventa);
                cmd.Parameters.AddWithValue("@idcliente", parametros.idclientev);
                cmd.Parameters.AddWithValue("@fecha_venta", DateTime.Now);
                cmd.Parameters.AddWithValue("@Monto_total", parametros.Monto_total);
                cmd.Parameters.AddWithValue("@Tipo_de_pago", parametros.Tipo_de_pago);
                decimal porcImpuesto = Convert.ToDecimal(Porcentajeimp / 100);
                decimal subtotal = parametros.Monto_total / (1 + porcImpuesto);
                decimal igv = parametros.Monto_total - subtotal;
                cmd.Parameters.AddWithValue("@TotalIgv", igv);
                cmd.Parameters.AddWithValue("@Id_usuario", Idusuario);
                cmd.Parameters.AddWithValue("@Fecha_de_pago", DateTime.Now);
                cmd.Parameters.AddWithValue("@Saldo", parametros.Saldo);
                cmd.Parameters.AddWithValue("@Pago_con", parametros.Pago_con);
                cmd.Parameters.AddWithValue("@Id_caja", Idcaja);
                cmd.Parameters.AddWithValue("@Referencia_tarjeta", parametros.Referencia_tarjeta);
                cmd.Parameters.AddWithValue("@Vuelto", parametros.Vuelto);
                cmd.Parameters.AddWithValue("@Efectivo", parametros.Efectivo);
                cmd.Parameters.AddWithValue("@Credito", parametros.Credito);
                cmd.Parameters.AddWithValue("@Tarjeta", parametros.Tarjeta);
                cmd.Parameters.AddWithValue("@Idcomprobante", parametros.Idcomprobante);
                cmd.Parameters.AddWithValue("@ContadorProductos", contadorProd);
                cmd.Parameters.AddWithValue("@TotSubtotal", subtotal);
                cmd.Parameters.AddWithValue("@Porcentaje_IGV", Porcentajeimp);
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
        public bool eliminarVentasIncomp()
        {
            try
            {
                ObtenerIdcaja();
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("eliminarVentasIncomp", CONEXIONMAESTRA.conectar);
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
        public bool eliminarVenta(Lventas parametros)
        {
            try
            {
                ObtenerIdcaja();
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("eliminar_venta", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idventa", parametros.idventa);
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
        public bool editarEstadoSunatVenta(Lventas parametros)
        {
            try
            {
                ObtenerIdcaja();
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("editarEstadoSunatVenta", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Idventa", parametros.idventa);
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
        public void ContFBAprobadas(ref int contador,string codigoComp)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                var da = new SqlCommand("ContFBAprobadas", CONEXIONMAESTRA.conectar);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@Codigo", codigoComp);
                contador =Convert.ToInt32( da.ExecuteScalar());
            }
            catch (Exception ex)
            {
                contador = 0;
              
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }
        public void ContFBPendientes(ref int contador, string codigoComp)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                var da = new SqlCommand("ContFBPendientes", CONEXIONMAESTRA.conectar);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@Codigo", codigoComp);
                contador = Convert.ToInt32(da.ExecuteScalar());
            }
            catch (Exception ex)
            {
                contador = 0;
            
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }
        public bool editarVentaAnulada(Lventas parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("editarVentaAnulada", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idventa", parametros.idventa);
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
        public void buscarVentasPorFechas(ref DataTable dt, DateTime fi, DateTime ff)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("buscarventasXfechas", CONEXIONMAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@fi", fi);
                da.SelectCommand.Parameters.AddWithValue("@ff", ff);

                da.Fill(dt);
                CONEXIONMAESTRA.cerrar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
        }
       
    }
}
