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
using Sunat.Logica;

namespace Ada369Csharp.Presentacion.Cobros
{
    public partial class CobrosForm : Form
    {
        public CobrosForm()
        {
            InitializeComponent();
        }
        public static  int idcliente;
        public static    double saldo;
        private void Label21_Click(object sender, EventArgs e)
        {

        }

        private void txtclientesolicitante_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }
        private void buscar()
        {
            DataTable dt = new DataTable();
            Obtener_datos.buscar_clientes(ref dt, txtclientesolicitante.Text);
            datalistadoClientes.DataSource = dt;
            datalistadoClientes.Columns[0].Visible = false;

            datalistadoClientes.Columns[1].Visible = false;
            datalistadoClientes.Columns[3].Visible = false;
            datalistadoClientes.Columns[4].Visible = false;
            datalistadoClientes.Columns[5].Visible = false;
            datalistadoClientes.Columns[6].Visible = false;
            datalistadoClientes.Columns[7].Visible = false;
            datalistadoClientes.Columns[2].Width = datalistadoClientes.Width;
            datalistadoClientes.BringToFront();
            datalistadoClientes.Visible = true;
            datalistadoClientes.Location = new Point(panelRegistros.Location.X, panelRegistros.Location.Y);
            datalistadoClientes.Size= new Size (538, 220);
            panelRegistros.Visible = false;
        }

        private void datalistadoClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            idcliente =(int)datalistadoClientes.SelectedCells[1].Value;
            txtclientesolicitante.Text = datalistadoClientes.SelectedCells[2].Value.ToString();
            obtenerSaldo();
            datalistadoClientes.Visible = false;
            panelRegistros.Visible = true;
            mostrarEstadosCuentaCliente();

        }
        private void obtenerSaldo()
        {
            txttotal_saldo.Text= datalistadoClientes.SelectedCells[7].Value.ToString();
            saldo = Convert.ToDouble ( datalistadoClientes.SelectedCells[7].Value);
        }
            
         
       
        private void mostrarEstadosCuentaCliente()
        {
            DataTable dt = new DataTable();
            Obtener_datos.mostrarEstadosCuentaCliente(ref dt, idcliente);
            datalistadoHistorial.DataSource = dt;
            Bases estilo = new Bases();
            estilo.MultilineaCobros (ref datalistadoHistorial); 
            panelH.Visible = true;
            panelM.Visible = false;
            panelHistorial.Visible = true;
            panelHistorial.Dock = DockStyle.Fill;
            panelMovimientos.Visible = false;
            panelMovimientos.Dock = DockStyle.None;
        }
        private void CobrosForm_Load(object sender, EventArgs e)
        {
            centrarPanel();
        }
        private void centrarPanel()
        {
            PanelContenedor.Location = new Point((Width - PanelContenedor.Width) / 2, (Height - PanelContenedor.Height) / 2);
        }
        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            mostrarControlCobros();
        }
        private void mostrarControlCobros()
        {
            DataTable dt = new DataTable();
            Obtener_datos.mostrar_ControlCobros(ref dt);
            datalistadoMovimientos.DataSource = dt;
            Bases estilo = new Bases();
            estilo.MultilineaCobros(ref datalistadoMovimientos);
            datalistadoMovimientos.Columns[1].Visible = false;
            datalistadoMovimientos.Columns[5].Visible = false;
            datalistadoMovimientos.Columns[6].Visible = false;
            datalistadoMovimientos.Columns[7].Visible = false;

            panelH.Visible = false;
            panelM.Visible = true;
            panelHistorial.Visible = false;
            panelMovimientos.Visible = true;
            panelMovimientos.Dock = DockStyle.Fill;
            panelHistorial.Dock = DockStyle.None;
        }

        private void btnhistorial_Click(object sender, EventArgs e)
        {
            mostrarEstadosCuentaCliente();
        }

        private void btnabonar_Click(object sender, EventArgs e)
        {
            if (saldo >0 )
            {
            MediosCobros frm = new MediosCobros();
            frm.FormClosing += Frm_FormClosing;
            frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("El saldo del cliente actual es 0");
            }
           
        }

        private void Frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            buscar();
            obtenerSaldo();
            mostrarControlCobros();
        }

        private void txtclientesolicitante_Click(object sender, EventArgs e)
        {
            txtclientesolicitante.SelectAll();
        }

        private void datalistadoMovimientos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == datalistadoMovimientos.Columns ["Eli"].Index )
            {
                DialogResult result= MessageBox.Show("¿Realmente desea eliminar esta Abono?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
               if (result == DialogResult.OK )
                {
                    aumentarSaldo();
                }
            }
        }
        private void aumentarSaldo()
        {
            double monto;
            monto = Convert.ToDouble(datalistadoMovimientos.SelectedCells[2].Value);
            Lclientes parametros = new Lclientes();
            Editar_datos funcion = new Editar_datos();
            parametros.idcliente = idcliente;
          if (  funcion.aumentarSaldocliente(parametros, monto)==true)
            {
                eliminarControlCobros();
            }
            
        }
        private void eliminarControlCobros()
        {
            Lcontrolcobros parametros = new Lcontrolcobros();
            Eliminar_datos funcion = new Eliminar_datos();
            parametros.IdcontrolCobro = Convert.ToInt32(datalistadoMovimientos.SelectedCells[1].Value);
           if ( funcion.eliminarControlCobro (parametros )==true )
            {
                buscar();
            }
        }
    }
}
