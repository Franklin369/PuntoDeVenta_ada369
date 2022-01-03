using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Ada369Csharp.CONEXION;
using System.Windows.Forms;
using Sunat.Logica;
using Ada369Csharp.Logica;
namespace Ada369Csharp.Datos
{
    public  class Editar_datos
    {
        int idcaja;
        public static void cambio_de_Caja(int idcaja,int idventa)
        {
            CONEXIONMAESTRA.abrir();
            SqlCommand cmd = new SqlCommand("cambio_de_Caja", CONEXIONMAESTRA.conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idcaja", idcaja);
            cmd.Parameters.AddWithValue("@idventa", idventa);
            cmd.ExecuteNonQuery();
            CONEXIONMAESTRA.cerrar();
        }
        public static void ingresar_nombre_a_venta_en_espera(int idventa, string nombre)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("ingresar_nombre_a_venta_en_espera", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idventa", idventa);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.ExecuteNonQuery();
                CONEXIONMAESTRA.cerrar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
        }
        public static bool   editar_Conceptos(int idconcepto,string descripcion)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("editar_Conceptos", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_concepto", idconcepto);
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
        public static bool editar_dinero_caja_inicial(int idcaja, double  saldo)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("editar_dinero_caja_inicial", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_caja", idcaja );
                cmd.Parameters.AddWithValue("@saldo", saldo);
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
        public bool editar_Proveedores(Lproveedores parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("editar_Proveedores", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdProveedor", parametros.IdProveedor);
                cmd.Parameters.AddWithValue("@Nombre", parametros.Nombre);
                cmd.Parameters.AddWithValue("@Direccion", parametros.Direccion);
                cmd.Parameters.AddWithValue("@IdentificadorFiscal", parametros.IdentificadorFiscal);
                cmd.Parameters.AddWithValue("@Celular", parametros.Celular);
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
        public bool restaurar_Proveedores(Lproveedores parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("restaurar_Proveedores", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdProveedor", parametros.IdProveedor);
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
        public bool restaurar_clientes(Lclientes parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("restaurar_clientes", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Idcliente", parametros.idcliente );
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
        public bool editar_caja_impresoras(Limpresoras parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("editar_caja_impresoras", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idcaja", parametros.idcaja);
                cmd.Parameters.AddWithValue("@Impresora_Ticket", parametros.Impresora_Ticket);
                cmd.Parameters.AddWithValue("@Impresora_A4", parametros.Impresora_A4);     
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
        public bool editarRespaldos(Lempresa parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("editarRespaldos", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
        
                cmd.Parameters.AddWithValue("@Carpeta_para_copias_de_seguridad", parametros.Carpeta_para_copias_de_seguridad);
                cmd.Parameters.AddWithValue("@Ultima_fecha_de_copia_de_seguridad", parametros.Ultima_fecha_de_copia_de_seguridad);
                cmd.Parameters.AddWithValue("@Ultima_fecha_de_copia_date", parametros.Ultima_fecha_de_copia_date);
                cmd.Parameters.AddWithValue("@Frecuencia_de_copias", parametros.Frecuencia_de_copias);              
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

        public bool editarCorreobase(Lcorreo parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("editar_correo_base", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Correo", parametros.Correo);
                cmd.Parameters.AddWithValue("@Password", parametros.Password);
                cmd.Parameters.AddWithValue("@Estado_De_envio", parametros.Estado);
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
        public bool cerrarCaja(Lmcaja  parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("cerrarCaja", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fechafin", parametros.fechafin);
                cmd.Parameters.AddWithValue("@fechacierre", parametros.fechacierre);
                cmd.Parameters.AddWithValue("@ingresos", parametros.ingresos);
                cmd.Parameters.AddWithValue("@egresos", parametros.egresos);
                cmd.Parameters.AddWithValue("@Saldo_queda_en_caja", parametros.Saldo_queda_en_caja);
                cmd.Parameters.AddWithValue("@Id_usuario", parametros.Id_usuario);
                cmd.Parameters.AddWithValue("@Total_calculado", parametros.Total_calculado);
                cmd.Parameters.AddWithValue("@Total_real", parametros.Total_real);
                cmd.Parameters.AddWithValue("@Estado", parametros.Estado);
                cmd.Parameters.AddWithValue("@Diferencia", parametros.Diferencia);
                cmd.Parameters.AddWithValue("@Id_caja", parametros.Id_caja);
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
        public bool editarMarcan(Lmarcan parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("EDITAR_marcan_a", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@e", parametros.E);
                cmd.Parameters.AddWithValue("@fa", parametros.FA);
                cmd.Parameters.AddWithValue("@f", parametros.F);
                cmd.Parameters.AddWithValue("@s", parametros.S);
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
        //Clientes
        public bool editar_clientes(Lclientes  parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("editar_clientes", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Idcliente", parametros.idcliente );
                cmd.Parameters.AddWithValue("@Nombre", parametros.Nombre);
                cmd.Parameters.AddWithValue("@Direccion", parametros.Direccion);
                cmd.Parameters.AddWithValue("@NmerDoc", parametros.Nrodoc);
                cmd.Parameters.AddWithValue("@Celular", parametros.Celular);
                cmd.Parameters.AddWithValue("@Tipodoc", parametros.Tipodoc);

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
        public bool disminuirSaldocliente(Lclientes parametros,double monto)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("disminuirSaldocliente", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idcliente", parametros.idcliente);
                cmd.Parameters.AddWithValue("@monto", monto);       
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
        public bool aumentarSaldocliente(Lclientes parametros, double monto)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("aumentar_saldo_a_cliente", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idcliente", parametros.idcliente);
                cmd.Parameters.AddWithValue("@Saldo", monto);
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

        //Caja
        public bool EditarBascula( Lcaja parametros)
        {
            try
            {            
                Obtener_datos.Obtener_id_caja_PorSerial(ref idcaja);
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("EditarBascula", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idcaja", parametros.Id_Caja);
                cmd.Parameters.AddWithValue("@Puerto", parametros.PuertoBalanza);
                cmd.Parameters.AddWithValue("@Estado", parametros.EstadoBalanza);             
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
        public bool EditarTemaCaja(Lcaja parametros)
        {
            try
            {
                Obtener_datos.Obtener_id_caja_PorSerial(ref idcaja);
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("EditarTemaCaja", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idcaja", idcaja);
                cmd.Parameters.AddWithValue("@tema", parametros.Tema);
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

        //Detalleventa
        public bool aplicar_precio_mayoreo(LdetalleVenta parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("aplicar_precio_mayoreo", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idproducto", parametros.Id_producto);
                cmd.Parameters.AddWithValue("@iddetalleventa", parametros.iddetalle_venta );
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
        public bool editarPrecioVenta(LdetalleVenta parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("editarPrecioVenta", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@iddetalleventa", parametros.iddetalle_venta);
                cmd.Parameters.AddWithValue("@precio", parametros.preciounitario);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace );
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }
        public bool DetalleventaDevolucion(LdetalleVenta parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("DetalleventaDevolucion", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@iddetalle", parametros.iddetalle_venta);
                cmd.Parameters.AddWithValue("@cantidad", parametros.cantidad);
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
        public bool AumentarStockDetalle(LdetalleVenta parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("aumentar_stock_en_detalle_de_venta", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Producto1", parametros.Id_producto);
                cmd.Parameters.AddWithValue("@cantidad", parametros.cantidad);
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
        //Productos
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

                MessageBox.Show(ex.StackTrace);
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }
       

        public bool EditarPreciosProductos(Lproductos parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("EditarPreciosProductos", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idproducto", parametros.Id_Producto1);
                cmd.Parameters.AddWithValue("@precioventa", parametros.Precio_de_venta);
                cmd.Parameters.AddWithValue("@costo", parametros.Precio_de_compra);    
                cmd.Parameters.AddWithValue("@preciomayoreo", parametros.Precio_mayoreo);
                cmd.Parameters.AddWithValue("@cantidadAgregada", parametros.Stock);              
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

        //Ventas
        public bool EditarVenta(Lventas parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("editarVenta", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idventa", parametros.idventa);
                cmd.Parameters.AddWithValue("@monto", parametros.Monto_total );
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
    }
}
