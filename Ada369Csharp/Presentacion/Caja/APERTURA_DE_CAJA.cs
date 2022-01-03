using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Net.Mail;
using System.Net;
using System.Management;
using System.Xml;
using Ada369Csharp.Logica;
using Ada369Csharp.Datos;
using Ada369Csharp.Presentacion.Ventas;

namespace Ada369Csharp.Presentacion.CAJA
{
    public partial class APERTURA_DE_CAJA : UserControl
    {
        public APERTURA_DE_CAJA()
        {
            InitializeComponent();
        }
        int txtidcaja;
       

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty (txtmonto.Text ))
            {
                txtmonto.Text = "0";
            }
            bool  estado = Editar_datos.editar_dinero_caja_inicial(txtidcaja, Convert.ToDouble(txtmonto.Text));
            if (estado ==true )
            {
                pasar_a_ventas();
            }       
        }

  
        private void APERTURA_DE_CAJA_Load(object sender, EventArgs e)
        {
          
            Obtener_datos.Obtener_id_caja_PorSerial(ref txtidcaja);
            centrar_panel();
        }
        private void centrar_panel()
        {
            //PanelCaja.Location = new Point((Width - PanelCaja.Width) / 2, (Height - PanelCaja.Height) / 2);
        }

        private void btnomitir_Click(object sender, EventArgs e)
        {
            pasar_a_ventas();
        }
        private void pasar_a_ventas()
        {
            Dispose();
        }

        private void txtmonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bases.Separador_de_Numeros(txtmonto, e);

        }

    }
}
