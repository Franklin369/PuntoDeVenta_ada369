using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ada369Csharp.Datos;
using Ada369Csharp.Logica;
namespace Ada369Csharp.Presentacion.Ingresos_varios
{
    public partial class IngresosVarios : UserControl
    {
        public IngresosVarios()
        {
            InitializeComponent();
        }
        int idcaja;
        private void rellenar_campos_vacios()
        {
            if (string.IsNullOrEmpty(txtdetalle.Text)) { txtdetalle.Text = "Sin detallar"; }
            if (string.IsNullOrEmpty(txtnrocomprobante.Text)) { txtnrocomprobante.Text = "-"; }
            if (string.IsNullOrEmpty(txttipocomprobante.Text)) { txttipocomprobante.Text = "-"; }
        }
        private void GuardarRegistro_Click(object sender, EventArgs e)
        {
            rellenar_campos_vacios();
            bool estado = Insertar_datos.insertar_Ingresos_varios (txtfecha.Value, txtnrocomprobante.Text,
           txttipocomprobante.Text, Convert.ToDouble(txtimporte.Text), txtdetalle.Text,
           idcaja);
            if (estado == true)
            {
                limpiar_inicio();
                MessageBox.Show("Datos ingresados correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void limpiar_inicio()
        {
                  
            btnComprobante.Checked = true;
            panelcomprobante.Visible = false;
            txtimporte.Clear();
            txtdetalle.Clear();
            txtnrocomprobante.Clear();
        }
        private void IngresosVarios_Load(object sender, EventArgs e)
        {
            limpiar_inicio();
            Obtener_datos.Obtener_id_caja_PorSerial(ref idcaja);
        }

        private void btnComprobante_CheckedChanged(object sender, EventArgs e)
        {
            if (btnComprobante.Checked == true)
            {
                panelcomprobante.Visible = false;
            }
            else
            {
                panelcomprobante.Visible = true;
            }
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtimporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bases.Separador_de_Numeros(txtimporte, e);

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
