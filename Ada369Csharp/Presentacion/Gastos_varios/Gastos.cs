using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Ada369Csharp.Datos;
using Ada369Csharp.Logica;
namespace Ada369Csharp.Presentacion.Gastos_varios
{
    public partial class Gastos : UserControl
    {
        public Gastos()
        {
            InitializeComponent();
        }
        int idconcepto;
        int idcaja;
        private void btnguardarConceptos_Click(object sender, EventArgs e)
        {
           bool estado =   Insertar_datos.insertar_Conceptos(txtdescripcionConcepto.Text);
            if (estado ==true)
            {
            buscador_de_conceptos();
            ocultar_panelConceptos();
            }
           

        }
        private void ocultar_panelConceptos()
        {
            panelConceptos.Visible = false;
            panelConceptos.Dock = DockStyle.None;
        }
        private void buscador_de_conceptos()
        {
            DataTable dt = new DataTable();
            Obtener_datos.buscar_conceptos(ref dt, txtBuscarconcepto.Text);
            datalistadoConceptos.DataSource = dt;
            datalistadoConceptos.Columns[1].Visible = false;
            Bases.Multilinea(ref datalistadoConceptos);
        }

        private void btnNuevoconcepto_Click(object sender, EventArgs e)
        {

            mostrar_panelconceptos();
            btnguardarConceptos.Visible = true;
            btnguardarcambiosConceptos.Visible = false;
            txtdescripcionConcepto.Clear();

        }
        private void mostrar_panelconceptos()
        {
            panelConceptos.Visible = true;
            panelConceptos.Dock = DockStyle.Fill;
            panelConceptos.BringToFront();
        }
        private void Gastos_Load(object sender, EventArgs e)
        {
            limpiar_inicio();
            Obtener_datos.Obtener_id_caja_PorSerial(ref idcaja);
        }
        private void limpiar_inicio()
        {
            panelConceptos.Visible = false;
            panelConceptos.Dock = DockStyle.None;
            txtdescripcionConcepto.Clear();
            txtBuscarconcepto.Clear();
            mostrar_datalistadoConceptos();
            
          
            btnComprobante.Checked = true;
            panelcomprobante.Visible = false;
            txtimporte.Clear();
            txtdetalle.Clear();
            txtnrocomprobante.Clear();
        }
        private void mostrar_datalistadoConceptos ()
        {
            datalistadoConceptos.Visible = true;
            datalistadoConceptos.Location = new Point(PanelDetalle.Location.X, PanelDetalle.Location.Y);
            datalistadoConceptos.Size = new System.Drawing.Size(588, 414);
            datalistadoConceptos.BringToFront();
            buscador_de_conceptos();
        }
        private void txtconcepto_TextChanged(object sender, EventArgs e)
        {
            buscador_de_conceptos();
        }

        private void datalistadoConceptos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idconcepto =Convert.ToInt32 ( datalistadoConceptos.SelectedCells[1].Value);
                txtBuscarconcepto.Text = datalistadoConceptos.SelectedCells[2].Value.ToString ();
                datalistadoConceptos.Visible = false;
                if (e.ColumnIndex == datalistadoConceptos.Columns["Editar"].Index )
                {
                    mostrar_panelconceptos();
                    btnguardarcambiosConceptos.Visible = true;
                    btnguardarConceptos.Visible = false;
                    txtdescripcionConcepto.Text = txtBuscarconcepto.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
              
            }
        }

        private void btnComprobante_CheckedChanged(object sender, EventArgs e)
        {
            if (btnComprobante.Checked ==true )
            {
                panelcomprobante.Visible = false;
            }
            else
            {
                panelcomprobante.Visible = true;
            }
        }
        private void rellenar_campos_vacios()
        {
            if (string.IsNullOrEmpty (txtdetalle.Text )) { txtdetalle.Text = "Sin detallar"; }
            if (string.IsNullOrEmpty(txtnrocomprobante .Text)) { txtnrocomprobante.Text = "-"; }
            if (string.IsNullOrEmpty(txttipocomprobante.Text)) { txttipocomprobante.Text = "-"; }
        }
        private void GuardarRegistro_Click(object sender, EventArgs e)
        {
            rellenar_campos_vacios();
            bool estado = Insertar_datos.insertar_Gastos_varios(txtfecha.Value, txtnrocomprobante.Text,
            txttipocomprobante.Text, Convert.ToDouble(txtimporte.Text), txtdetalle.Text,
            idcaja, idconcepto);
            if (estado ==true )
            {
              limpiar_inicio();
              MessageBox.Show("Datos ingresados correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }

        private void txtconcepto_Click(object sender, EventArgs e)
        {
            txtBuscarconcepto.SelectAll();
            mostrar_datalistadoConceptos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ocultar_panelConceptos();
        }

        private void btnguardarcambiosConceptos_Click(object sender, EventArgs e)
        {
            bool Estado =   Editar_datos.editar_Conceptos(idconcepto, txtdescripcionConcepto.Text);
            if (Estado ==true)
            {
            ocultar_panelConceptos();
            buscador_de_conceptos();
            txtBuscarconcepto.Text = txtdescripcionConcepto.Text;
            }
            else
            {
                txtdescripcionConcepto.SelectAll();
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
