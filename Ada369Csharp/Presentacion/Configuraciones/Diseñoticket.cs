using Ada369Csharp.Datos;
using Sunat.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ada369Csharp.Presentacion.Configuraciones
{
    public partial class Diseñoticket : UserControl
    {
        public Diseñoticket()
        {
            InitializeComponent();
        }
        string txttipo;
        private void Diseñoticket_Load(object sender, EventArgs e)
        {
            mostrarticket();
        }
        private void mostrarticket()
        {
            var dt = new DataTable();
            var funcion = new Dticket();
            funcion.mostrar(ref dt);
            txtMoneda_String.Text = dt.Rows[0][2].ToString();
            txtAgradecimiento.Text = dt.Rows[0][3].ToString();
            txtpagina_o_facebook.Text = dt.Rows[0][4].ToString();
            txtanuncio.Text = dt.Rows[0][5].ToString();
            txtAutorizacion_fiscal.Text = dt.Rows[0][6].ToString();
            txttipo = dt.Rows[0][7].ToString();
            if (txttipo == "Ticket No Fiscal")
            {
                btnTicket.BackColor = Color.FromArgb(255, 204, 1);
                btnFacturaBoleta.BackColor = Color.White;
                txtAutorizacion_fiscal.Visible = false;
            }
            else
            {
                btnFacturaBoleta.BackColor = Color.FromArgb(255, 204, 1);
                btnTicket.BackColor = Color.White;
                txtAutorizacion_fiscal.Visible = true;
            }
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            txttipo = "Ticket No Fiscal";
            btnTicket.BackColor = Color.FromArgb(255, 204, 1);
            btnFacturaBoleta.BackColor = Color.White;
            txtAutorizacion_fiscal.Visible = false;

        }

        private void btnFacturaBoleta_Click(object sender, EventArgs e)
        {
            txttipo = "Factura-Boleta";
            btnTicket.BackColor = Color.White;
            btnFacturaBoleta.BackColor = Color.FromArgb(255, 204, 1);
            txtAutorizacion_fiscal.Visible = true;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            var funcion = new Dticket();
            var parametros = new Lticket();
            parametros.Nombre_de_Moneda = txtMoneda_String.Text;
            parametros.Agradecimiento = txtAgradecimiento.Text;
            parametros.Anuncio = txtanuncio.Text;
            parametros.pagina_Web_Facebook = txtpagina_o_facebook.Text;
         
            if (txttipo == "Ticket No Fiscal")
            {
                parametros.Datos_fiscales_de_autorizacion = "-";
            }
            else
            {
                parametros.Datos_fiscales_de_autorizacion = txtAutorizacion_fiscal.Text;
            }
            parametros.Por_defecto = txttipo;
            funcion.Editarticket(parametros);
            MessageBox.Show("Datos actualizados correctamente", "Actualizando datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dispose();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
