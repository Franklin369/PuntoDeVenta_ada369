using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Ada369Csharp.CONEXION;
using System.Windows.Forms;
using Ada369Csharp.Logica;
namespace Ada369Csharp.Datos
{
  public  class Insertar_datos
    {
        int idcaja;
        int idusuario;
        public static bool insertar_Conceptos(string descripcion)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("insertar_Conceptos", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                cmd.ExecuteNonQuery();
                CONEXIONMAESTRA.cerrar();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static bool insertar_Gastos_varios(DateTime fecha,string Nro_documento,
          string  Tipo_comprobante, double Importe,string Descripcion,int Id_caja,int Id_concepto)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("insertar_Gastos_varios", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Fecha", fecha);
                cmd.Parameters.AddWithValue("@Nro_documento", Nro_documento);
                cmd.Parameters.AddWithValue("@Tipo_comprobante", Tipo_comprobante);
                cmd.Parameters.AddWithValue("@Importe", Importe);
                cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
                cmd.Parameters.AddWithValue("@Id_caja", Id_caja);
                cmd.Parameters.AddWithValue("@Id_concepto", Id_concepto);
                cmd.ExecuteNonQuery();
                CONEXIONMAESTRA.cerrar();
                return true;        
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                return false;
            }
        }
        public static bool insertar_Ingresos_varios(DateTime fecha, string Nro_documento,
         string Tipo_comprobante, double Importe, string Descripcion, int Id_caja)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("insertar_Ingresos_varios", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Fecha", fecha);
                cmd.Parameters.AddWithValue("@Nro_comprobante", Nro_documento);
                cmd.Parameters.AddWithValue("@Tipo_comprobante", Tipo_comprobante);
                cmd.Parameters.AddWithValue("@Importe", Importe);
                cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
                cmd.Parameters.AddWithValue("@Id_caja", Id_caja);
             
                cmd.ExecuteNonQuery();
                CONEXIONMAESTRA.cerrar();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public  bool insertar_CreditoPorPagar(LcreditosPorPagar parametros)
        {
            try
            {
                Obtener_datos.Obtener_id_caja_PorSerial(ref idcaja);
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("insertar_CreditoPorPagar", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Descripcion", parametros.Descripcion);
                cmd.Parameters.AddWithValue("@Fecha_registro", parametros.Fecha_registro);
                cmd.Parameters.AddWithValue("@Fecha_vencimiento", parametros.Fecha_vencimiento);
                cmd.Parameters.AddWithValue("@Total", parametros.Total);
                cmd.Parameters.AddWithValue("@Saldo", parametros.Saldo);
                cmd.Parameters.AddWithValue("@Estado", "DEBE");
                cmd.Parameters.AddWithValue("@Id_caja", idcaja);
                cmd.Parameters.AddWithValue("@Id_Proveedor", parametros.Id_proveedor );
                cmd.ExecuteNonQuery() ;
                return true;                       
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }

        }
        public bool insertar_Proveedores(Lproveedores parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("insertar_Proveedores", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", parametros.Nombre);
                cmd.Parameters.AddWithValue("@Direccion", parametros.Direccion);
                cmd.Parameters.AddWithValue("@IdentificadorFiscal", parametros.IdentificadorFiscal);
                cmd.Parameters.AddWithValue("@Celular", parametros.Celular);
                cmd.Parameters.AddWithValue("@Estado","ACTIVO");
                cmd.Parameters.AddWithValue("@Saldo", 0);
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
      
        public bool insertar_CreditoPorCobrar(LcreditoPorCobrar  parametros)
        {
            try
            {
                Obtener_datos.Obtener_id_caja_PorSerial(ref idcaja);
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("insertar_CreditoPorCobrar", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Descripcion", parametros.Descripcion);
                cmd.Parameters.AddWithValue("@Fecha_registro", parametros.Fecha_registro);
                cmd.Parameters.AddWithValue("@Fecha_vencimiento", parametros.Fecha_vencimiento);
                cmd.Parameters.AddWithValue("@Total", parametros.Total);
                cmd.Parameters.AddWithValue("@Saldo", parametros.Saldo);
                cmd.Parameters.AddWithValue("@Estado", "DEBE");
                cmd.Parameters.AddWithValue("@Id_caja", idcaja);
                cmd.Parameters.AddWithValue("@Id_cliente", parametros.Id_cliente);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }

        }
        public bool Insertar_ControlCobros(Lcontrolcobros parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("Insertar_ControlCobros", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Monto", parametros.Monto);
                cmd.Parameters.AddWithValue("@Fecha", parametros.Fecha);
                cmd.Parameters.AddWithValue("@Detalle", parametros.Detalle);
                cmd.Parameters.AddWithValue("@IdCliente", parametros.IdCliente);
                cmd.Parameters.AddWithValue("@IdUsuario", parametros.IdUsuario);
                cmd.Parameters.AddWithValue("@IdCaja", parametros.IdCaja);
                cmd.Parameters.AddWithValue("@Comprobante", parametros.Comprobante);
                cmd.Parameters.AddWithValue("@efectivo", parametros.efectivo);
                cmd.Parameters.AddWithValue("@tarjeta", parametros.tarjeta);
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

        //Kardex
        private void ObtenerIniciosesion()
        {
            var funcion = new DiniciosSesion();
            var dt = new DataTable();
            funcion.mostrarInicioSesionTable(ref dt);
            idusuario =Convert.ToInt32( dt.Rows[0][2]);
        }
        public bool insertar_KARDEX_Entrada(LKardex parametros)
        {
            try
            {
                ObtenerIniciosesion();
                Obtener_datos.Obtener_id_caja_PorSerial(ref idcaja);
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("insertar_KARDEX_Entrada", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Fecha",parametros.Fecha);
                cmd.Parameters.AddWithValue("@Motivo", parametros.Motivo );
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
                return true;
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }
        public bool insertar_KARDEX_SALIDA(LKardex parametros)
        {
            try
            {
                ObtenerIniciosesion();
                Obtener_datos.Obtener_id_caja_PorSerial(ref idcaja);
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("insertar_KARDEX_SALIDA", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Fecha", parametros.Fecha);
                cmd.Parameters.AddWithValue("@Motivo", parametros.Motivo);
                cmd.Parameters.AddWithValue("@Cantidad", parametros.Cantidad);
                cmd.Parameters.AddWithValue("@Id_producto", parametros.Id_producto);
                cmd.Parameters.AddWithValue("@Id_usuario", idusuario);
                cmd.Parameters.AddWithValue("@Tipo", "SALIDA");
                cmd.Parameters.AddWithValue("@Estado", "DESPACHO CONFIRMADO");
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

    }
}
