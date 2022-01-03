using Ada369Csharp.CONEXION;
using Ada369Csharp.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ada369Csharp.Datos
{
    public class Dmovicaja
    {
        string serialPC;
        int idusuario;
        int idcaja;
        string Estadoapertura;
        string nombreAperturo;
        string rolaperturo;
        public void MostrarCierresdeCaja(ref string resultado)
        {
            try
            {
                Bases.Obtener_serialPC(ref serialPC);
                var dt = new DataTable();
                CONEXIONMAESTRA.abrir();
                var da = new SqlDataAdapter("mostrarMovcajaXserial", CONEXIONMAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@serial", serialPC);
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    AperturarCaja();
                    resultado = "Nuevo*****";
                }
                else
                {
                    nombreAperturo = dt.Rows[0][1].ToString();
                    rolaperturo = dt.Rows[0][0].ToString();
                    var dtmv = new DataTable();
                    mostrarMovcajaXusuario(ref dtmv, rolaperturo);
                    resultado = "Aperturado";
                }


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
        public void MostrarCajasAperturada(ref int contador)
        {
            try
            {
                Bases.Obtener_serialPC(ref serialPC);
                var dt = new DataTable();
                CONEXIONMAESTRA.abrir();
                var da = new SqlDataAdapter("mostrarMovcajaXserial", CONEXIONMAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@serial", serialPC);
                da.Fill(dt);
                contador = dt.Rows.Count;
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
        private void MostrarInicioSesion()
        {
            var funcion = new DiniciosSesion();
            var dt = new DataTable();
            funcion.mostrarInicioSesionTable(ref dt);
            idusuario = Convert.ToInt32(dt.Rows[0][2]);
        }
        private void MostrarIdcaja()
        {
            var funcion = new Dcaja();
            funcion.ObtenerIdcaja(ref idcaja);
        }
        private void AperturarCaja()
        {
            try
            {
                MostrarIdcaja();
                MostrarInicioSesion();
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("insertar_DETALLE_cierre_de_caja", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fechaini", DateTime.Now);
                cmd.Parameters.AddWithValue("@fechafin", DateTime.Now);
                //cmd.Parameters.AddWithValue("@fecha", DateTime.Today);

                cmd.Parameters.AddWithValue("@fechacierre", DateTime.Now);
                cmd.Parameters.AddWithValue("@ingresos", "0.00");
                cmd.Parameters.AddWithValue("@egresos", "0.00");
                cmd.Parameters.AddWithValue("@saldo", "0.00");
                cmd.Parameters.AddWithValue("@idusuario", idusuario);
                cmd.Parameters.AddWithValue("@totalcaluclado", "0.00");
                cmd.Parameters.AddWithValue("@totalreal", "0.00");

                cmd.Parameters.AddWithValue("@estado", "CAJA APERTURADA");
                cmd.Parameters.AddWithValue("@diferencia", "0.00");
                cmd.Parameters.AddWithValue("@id_caja", idcaja);

                cmd.ExecuteNonQuery();


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
        public void mostrarMovcajaXusuario(ref DataTable dt, string roluser)
        {
            try
            {

                Bases.Obtener_serialPC(ref serialPC);
                MostrarInicioSesion();
                CONEXIONMAESTRA.abrir();
                var da = new SqlDataAdapter("mostrarMovcajaXusuario", CONEXIONMAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@serial", serialPC);
                da.SelectCommand.Parameters.AddWithValue("@idusuario", idusuario);
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    if (roluser == "Administrador")
                    {
                        MessageBox.Show("Continuaras Turno de *" + nombreAperturo + " Todos los Registros seran con ese Usuario", "Caja Iniciada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
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
