using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ada369Csharp.CONEXION;
using Ada369Csharp.Datos;
using Ada369Csharp.Logica;
using Sunat.Logica;
using Ada369Csharp.Presentacion.REPORTES.Impresion_de_comprobantes;
using Ada369Csharp.Presentacion.SunatForms;
using Telerik.Reporting.Processing;

namespace Ada369Csharp.Presentacion.HistorialVentas
{
    public partial class HistorialVentasForm : UserControl
    {
        public HistorialVentasForm()
        {
            InitializeComponent();
        }
        int idventa;
        string doc;
        string Totalletras;
        decimal total;
        string lbltotal;
        string Impresora;
        private void txtbusca_TextChanged(object sender, EventArgs e)
        {
            buscarVentas();
        }
        public void buscarVentas()
        {
            var dt = new DataTable();
            var funcion = new Dventas();
            funcion.buscarVentas(ref dt, txtbusca.Text);
            datalistadoVentas.DataSource = dt;
            datalistadoVentas.Columns[2].Visible = false;
            datalistadoVentas.Columns[3].Visible = false;
            datalistadoVentas.Columns[4].Visible = false;
            datalistadoVentas.Columns[5].Visible = false;
            datalistadoVentas.Columns[7].Visible = false;

            Bases.Multilinea(ref datalistadoVentas);
        }

        private void HistorialVentasForm_Load(object sender, EventArgs e)
        {
            panelBienvenida.Dock = DockStyle.Fill;
            MostrarImpresora();
        }

        private void datalistadoVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            obtenerdatos();
        }
        private void obtenerdatos()
        {
            if (datalistadoVentas.RowCount > 0)
            {
                idventa = Convert.ToInt32(datalistadoVentas.SelectedCells[2].Value);
                total= Convert.ToDecimal(datalistadoVentas.SelectedCells[6].Value);
                doc = datalistadoVentas.SelectedCells[1].Value.ToString();
                lblestadoSun.Text = datalistadoVentas.SelectedCells[7].Value.ToString();

                lbltotal = total.ToString();
                panelBienvenida.Visible = false;
                panelTicket.Visible = true;
                panelTicket.Dock = DockStyle.Fill;
                MostrarTicket();
            }
        }
        private void MostrarTicket()
        {
            convertirTotalaletras();
            var dt = new DataTable();
            var funcion = new Dticket();
            var parametros = new Lticket();
            parametros.Idventa = idventa;
            parametros.Totalletras = Totalletras;
            funcion.mostrarTicket(ref dt, parametros);
            var rpt = new Ticket_report();
            rpt.table1.DataSource = dt;
            rpt.DataSource = dt;
            reportViewer1.Report = rpt;
            reportViewer1.RefreshReport();
        }
        void convertirTotalaletras()
        {
            try
            {
                int numero = Convert.ToInt32(Math.Floor(Convert.ToDecimal(total)));
                var totalString = total_en_letras.Num2Text(numero);
                string[] a = lbltotal.Split(',');
                string txttotaldecimal;
                txttotaldecimal = a[1];
                Totalletras = totalString + " CON " + txttotaldecimal + "/100 ";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnHoy_Click(object sender, EventArgs e)
        {
            FiltrarFechas();
            fi.Value = DateTime.Now;
            ff.Value = DateTime.Now;
            buscarVentasPorFechas();

        }
        private void FiltrarFechas()
        {
            panelTicket.Visible = false;
            panelBienvenida.Visible = true;
            panelBienvenida.Dock = DockStyle.Fill;
            Pcancelado.Visible = false;
        }
        public void buscarVentasPorFechas()
        {
            DataTable dt = new DataTable();
            var funcion = new Dventas();
            funcion.buscarVentasPorFechas(ref dt, fi.Value, ff.Value);
            datalistadoVentas.DataSource = dt;
            datalistadoVentas.Columns[2].Visible = false;
            datalistadoVentas.Columns[3].Visible = false;
            datalistadoVentas.Columns[4].Visible = false;
            datalistadoVentas.Columns[5].Visible = false;
            datalistadoVentas.Columns[7].Visible = false;
            Bases.Multilinea(ref datalistadoVentas);
        }

        private void fi_ValueChanged(object sender, EventArgs e)
        {
            FiltrarFechas();
            buscarVentasPorFechas();
        }

        private void ff_ValueChanged(object sender, EventArgs e)
        {
            FiltrarFechas();
            buscarVentasPorFechas();
        }

      

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnReimprimir_Click(object sender, EventArgs e)
        {
            imprimir_directo();
        }
        private void MostrarImpresora()
        {
            var funcion = new Dcaja();
            var dt = new DataTable();
            funcion.MostrarImprTicket(ref dt);
            Impresora = dt.Rows[0][0].ToString();
        }
        private void imprimir_directo()
        {
         
            try
            {
                var DOCUMENTO = new PrintDocument();
                DOCUMENTO.PrinterSettings.PrinterName = Impresora;
                if (DOCUMENTO.PrinterSettings.IsValid)
                {
                    PrinterSettings printerSettings = new PrinterSettings();
                    printerSettings.PrinterName = Impresora;
                    ReportProcessor reportProcessor = new ReportProcessor();
                    reportProcessor.PrintReport(reportViewer1.ReportSource, printerSettings);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var ctl = new AgregarNotacredito();
            ctl.txtbuscar.Text = doc;
            Controls.Add(ctl);
            ctl.BringToFront();
            ctl.Size = new Size(Width, Height);
        }
    }
}
