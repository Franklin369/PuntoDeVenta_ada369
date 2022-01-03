using Ada369Csharp.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ada369Csharp.Logica;
namespace Ada369Csharp.Presentacion.CAJA
{
    public partial class CierreTurno : UserControl
    {
        public CierreTurno()
        {
            InitializeComponent();
        }
        string correobase;
        string contraseña;
        string estado;
        double dinerocalculado;
        double resultado;
        string correoReceptor;
        int idusuario;
        int idcaja;
        string usuario;
        private void CierreTurno_Load(object sender, EventArgs e)
        {
            lblDeberiaHaber.Text = Cierrecaja.efectivoEnCaja.ToString();
            dinerocalculado = Convert.ToDouble(lblDeberiaHaber.Text);
            mostrarUsuarioSesion();
        }
        private void mostrarUsuarioSesion()
        {
            var dt = new DataTable();
            //Obtener_datos.mostrarUsuariosSesion(ref dt);
            var funcion = new DiniciosSesion();
            funcion.mostrarInicioSesionTable(ref dt);
            //foreach (DataRow row in dt.Rows )
            //{
            usuario = dt.Rows[0][4].ToString();
            //}
        }

        private void txthay_TextChanged(object sender, EventArgs e)
        {
            calcular();

        }
        private void validacionesCalculo()
        {
            if (resultado == 0)
            {
                lblanuncio.Text = "Genial, Todo esta perfecto";
                lblanuncio.ForeColor = Color.FromArgb(0, 166, 63);
                lbldiferencia.ForeColor = Color.FromArgb(0, 166, 63);
                lblanuncio.Visible = true;

            }
            if (resultado < dinerocalculado & resultado != 0)
            {
                lblanuncio.Text = "La diferencia sera Registrada en su Turno y se enviara a Gerencia";
                lblanuncio.ForeColor = Color.FromArgb(231, 63, 67);
                lbldiferencia.ForeColor = Color.FromArgb(231, 63, 67);
                lblanuncio.Visible = true;

            }
            if (resultado > dinerocalculado)
            {
                lblanuncio.Text = "La diferencia sera Registrada en su Turno y se enviara a Gerencia";
                lblanuncio.ForeColor = Color.FromArgb(231, 63, 67);
                lbldiferencia.ForeColor = Color.FromArgb(231, 63, 67);
                lblanuncio.Visible = true;
            }
        }
        private void calcular()
        {
            try
            {


                double hay;
                hay = Convert.ToDouble(txthay.Text);
                if (string.IsNullOrEmpty(txthay.Text))
                {
                    hay = 0;
                }
                resultado = hay - dinerocalculado;
                lbldiferencia.Text = resultado.ToString();
                validacionesCalculo();
            }
            catch (Exception)
            {


            }

        }

        private void checkCorreo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkCorreo_Click(object sender, EventArgs e)
        {
            if (estado != "Sincronizado")
            {
                //Presentacion.CorreoBase.Correoconfi frm = new Presentacion.CorreoBase.Correoconfi();
                //frm.FormClosing += Frm_FormClosing;
                //frm.ShowDialog();
            }
        }
        private void BtnCerrar_turno_Click(object sender, EventArgs e)
        {
            cerrarCaja();

        }

        private void cerrarCaja()
        {
            if (string.IsNullOrEmpty(txthay.Text)) { txthay.Text = "0"; }
            ObtenerIniciosesion();
            Obtener_datos.Obtener_id_caja_PorSerial(ref idcaja);

            Lmcaja parametros = new Lmcaja();
            Editar_datos funcion = new Editar_datos();
            parametros.fechafin = DateTime.Now;
            parametros.fechacierre = DateTime.Now;
            parametros.ingresos = Cierrecaja.Ingresos;
            parametros.egresos = Cierrecaja.Egresos;
            parametros.Saldo_queda_en_caja = 0;
            parametros.Id_usuario = idusuario;
            parametros.Total_calculado = dinerocalculado;
            parametros.Total_real = Convert.ToDouble(txthay.Text);
            parametros.Estado = "CAJA CERRADA";
            parametros.Diferencia = resultado;
            parametros.Id_caja = idcaja;
            if (funcion.cerrarCaja(parametros) == true)
            {
                generarCopiaBd();
            }
        }
        private void ObtenerIniciosesion()
        {
            var funcion = new DiniciosSesion();
            var dt = new DataTable();
            funcion.mostrarInicioSesionTable(ref dt);
            idusuario = Convert.ToInt32(dt.Rows[0][2]);
        }

        private void generarCopiaBd()
        {
            Dispose();
            CopiasBd.GeneradorAutomatico frm = new CopiasBd.GeneradorAutomatico();
            frm.ShowDialog();
        }


        private void txthay_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bases.Separador_de_Numeros(txthay, e);
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
