using Ada369Csharp.CONEXION;
using Ada369Csharp.Datos;
using Ada369Csharp.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Management;
using System.Text;
using System.Windows.Forms;

namespace Ada369Csharp.Presentacion.Configuraciones
{
    public partial class Impresorasconfig : UserControl
    {
        public Impresorasconfig()
        {
            InitializeComponent();
        }
        private ManagementObjectSearcher MisDiscos = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
        private ManagementObject DiscInfo = new ManagementObject();
        int idcaja;
        private void Admin_impresoras_Load(object sender, EventArgs e)
        {
            cbxA4.Items.Clear();
            cbxTiket.Items.Clear();
            Panel2.Location = new Point(Convert.ToInt32((Width - Panel2.Width) / 2.0), Convert.ToInt32((Height - Panel2.Height) / 2.0));
            cargarDatos();
            for (var I = 0; I < PrinterSettings.InstalledPrinters.Count; I++)
            {
                cbxTiket.Items.Add(PrinterSettings.InstalledPrinters[I]);
                //cbxTiket.Items.Add("Ninguna")
                cbxA4.Items.Add(PrinterSettings.InstalledPrinters[I]);

            }

            cbxA4.Items.Add("Ninguna");
            cbxTiket.Items.Add("Ninguna");
        }
        private void cargarDatos()
        {
           
            DataTable dt = new DataTable();
            Obtener_datos.mostrar_cajas(ref dt);

            try
            {
                foreach(DataRow row in dt.Rows )
                {
                    idcaja = Convert.ToInt32(row["Id_caja"]);
                    cbxA4.Text = row["Impresora_A4"].ToString ();
                    cbxTiket.Text =row["Impresora_Ticket"].ToString();
                }
              
            }
            catch (Exception ex)
            {

            }
        }
        private void guardarBTN_Click(object sender, EventArgs e)
        {
            editar();
        }
        private void editar()
        {
            Limpresoras  parametros = new Limpresoras();
            Editar_datos funcion = new Editar_datos();
            parametros.idcaja = idcaja ;
            parametros.Impresora_Ticket = cbxTiket.Text;
            parametros.Impresora_A4 = cbxA4.Text;
          
            if (funcion.editar_caja_impresoras(parametros) == true)
            {
                MessageBox.Show("Datos Guardados Correctamente", "Registros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
