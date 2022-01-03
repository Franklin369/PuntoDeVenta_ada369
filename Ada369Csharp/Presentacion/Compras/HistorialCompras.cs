using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ada369Csharp.Datos;
using Ada369Csharp.Logica;

namespace Ada369Csharp.Presentacion.Compras
{
    public partial class HistorialCompras : UserControl
    {
        public HistorialCompras()
        {
            InitializeComponent();
        }
        int idcompra;

        private void txtbusca_TextChanged(object sender, EventArgs e)
        {
            buscarCompras();
        }
        private void buscarCompras()
        {
            var dt = new DataTable();
            var funcion = new Dcompras();
            funcion.buscarCompras(ref dt, txtbusca.Text);
            datalistadoCompras.DataSource = dt;
            Bases.Multilinea(ref datalistadoCompras);
            datalistadoCompras.Columns[1].Visible = false;
            datalistadoCompras.Columns[5].Visible = false;
            datalistadoCompras.Columns[6].Visible = false;

        }

        private void HistorialCompras_Load(object sender, EventArgs e)
        {
            buscarCompras();
        }

        private void datalistadoCompras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idcompra = Convert.ToInt32(datalistadoCompras.SelectedCells[1].Value);
            lbltotal.Text = datalistadoCompras.SelectedCells[3].Value.ToString();
            mostrarDetalleventa();


        }
        private void mostrarDetalleventa()
        {
            DataTable dt = new DataTable();
            var funcion = new Ddetallecompra();
            var parametros = new Ldetallecompra();
            parametros.IdCompra = idcompra;
            funcion.mostrar_DetalleCompra(ref dt, parametros);
            dgDetallecompra.DataSource = dt;
            Bases.Multilinea(ref dgDetallecompra);
            dgDetallecompra.Columns[1].Visible = false;
            dgDetallecompra.Columns[2].Visible = false;
            dgDetallecompra.Columns[3].Visible = false;
            dgDetallecompra.Columns[8].Visible = false;
            dgDetallecompra.Columns[9].Visible = false;


        }
    }
}
