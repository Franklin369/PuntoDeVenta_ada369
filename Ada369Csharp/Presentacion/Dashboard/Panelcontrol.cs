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
using System.Management;
using Ada369Csharp.Logica;
using Ada369Csharp.Datos;
using System.IO;
using System.Collections;
using System.Globalization;
using Ada369Csharp.Presentacion.Menu;

namespace Ada369Csharp.Presentacion.Dashboard
{
    public partial class Panelcontrol : UserControl
    {
        public Panelcontrol()
        {
            InitializeComponent();
        }
        int año;
        double totalVentas;
        string moneda;
        int CantProductos;
        double PorPagar;
        int CantClientes;
        double gananciasFecha;
        DataTable dtventas = new DataTable();
        int ProductoMinimo;
        double PorCobrar;
        double GananciasGenerales;
        private void Panelcontrol_Load(object sender, EventArgs e)
        {
          

            mostrarMoneda();
            ReportePorCobrar();
            ReportePorPagar();
           
            ReporteProductoBajoMinimo();
            ReporteCantClientes();
            ReporteCantProductos();
            mostrarVentasGrafica();
            chekFiltros.Checked = false;
            mostrarPmasVendidos();
            ReporteGastosAnioCombo();
            ObtenerMesAñoActual();
        }
        private void ObtenerMesAñoActual()

        {
            int año = DateTime.Today.Year;
            DateTime fechaactual = DateTime.Now;
            string mes = fechaactual.ToString("MMMM") + " " + año.ToString();
            lblfechaHoy.Text = mes;
        }
        private void ReporteGastosMesCombo()
        {

            DataTable dt = new DataTable();
            año = Convert.ToInt32 ( txtaño_gasto.Text);
            Obtener_datos.ReporteGastosMesCombo(ref dt, año);
            txtmes_gasto.DisplayMember = "mes";
            txtmes_gasto.ValueMember = "mes";
            txtmes_gasto.DataSource = dt;
        }
        private void ReporteGastosAnioCombo()
        {
            DataTable dt = new DataTable();
            Obtener_datos.ReporteGastosAnioCombo(ref dt);
            txtaño_gasto.DisplayMember = "anio";
            txtaño_gasto.ValueMember = "anio";
            txtaño_gasto.DataSource = dt;
        }
        private void mostrarPmasVendidos()
        {
            ArrayList cantidad = new ArrayList();
            ArrayList producto = new ArrayList();
            var dtProductos = new DataTable();
            Obtener_datos.mostrarPmasVendidos(ref dtProductos);
            foreach (DataRow filas in dtProductos.Rows )
            {
                cantidad.Add(filas["Cantidad"]);
                producto.Add(filas["Descripcion"]);
            }
            chartProductos.Series[0].Points.DataBindXY(producto, cantidad);
        }
        private void ReporteGananciasFecha()
        {
            Obtener_datos.ReporteGananciasFecha(ref gananciasFecha, TXTFI.Value, TXTFF.Value);
            lblgananciasok.Text = moneda + " " + gananciasFecha.ToString();
        }
        private void ReporteTotalVentasFechas()
        {
            Obtener_datos.ReporteTotalVentasFechas(ref totalVentas, TXTFI.Value, TXTFF.Value);
            txtventas.Text = moneda + " " + totalVentas.ToString();
        }
        private void ReporteTotalVentas()
        {
            Obtener_datos.ReporteTotalVentas(ref totalVentas);
            txtventas.Text = moneda + " " + totalVentas.ToString();
        }
        private void mostrarVentasGrafica()
        {
            ArrayList fecha = new ArrayList();
            ArrayList monto = new ArrayList();
            dtventas = new DataTable();
            Obtener_datos.mostrarVentasGrafica(ref dtventas);
            foreach (DataRow filas in dtventas.Rows)
            {
                fecha.Add(filas["fecha"]);
                monto.Add(filas["Total"]);
            }
            chartVentas.Series[0].Points.DataBindXY(fecha, monto);
            ReporteTotalVentas();
            ReporteGanancias();
        }
        private void mostrarVentasGraficaFechas()
        {
            ArrayList fecha = new ArrayList();
            ArrayList monto = new ArrayList();
            dtventas = new DataTable();
            Obtener_datos.mostrarVentasGraficaFechas(ref dtventas, TXTFI.Value ,TXTFF.Value );
            foreach (DataRow filas in dtventas.Rows)
            {
                fecha.Add(filas["fecha"]);
                monto.Add(filas["Total"]);
            }
            chartVentas.Series[0].Points.DataBindXY(fecha, monto);
            ReporteTotalVentasFechas();
            ReporteGananciasFecha();
        }
        private void mostrarMoneda()
        {
            Obtener_datos.MostrarMoneda(ref moneda);
        }
        private void ReporteCantProductos()
        {
            Obtener_datos.ReporteCantProductos(ref CantProductos);
            lblProductos.Text = CantProductos.ToString ();
        }
        private void ReporteCantClientes()
        {
            Obtener_datos.ReporteCantClientes(ref CantClientes);
            lblNclientes.Text = CantClientes.ToString();
        }
        private void ReporteProductoBajoMinimo()
        {
            Obtener_datos.ReporteProductoBajoMinimo(ref ProductoMinimo);
            lblStockBajo.Text = ProductoMinimo.ToString();
        }
        private void ReporteGanancias()
        {
            Obtener_datos.ReporteGanancias(ref GananciasGenerales);
            lblGanancias.Text = moneda + " " + GananciasGenerales.ToString ();
            lblgananciasok.Text = lblGanancias.Text;
        }
        private void ReportePorCobrar()
        {       
            Obtener_datos.ReportePorCobrar(ref PorCobrar);
            lblPorcobrar.Text = moneda +" " +  PorCobrar.ToString();
        }
        private void ReportePorPagar()
        {
            Obtener_datos.ReportePorPagar (ref PorPagar);
            lblPorPagar.Text = moneda + " " + PorPagar.ToString();
        }
     
        private void chekFiltros_CheckedChanged(object sender, EventArgs e)
        {
            if (chekFiltros.Checked ==true)
            {
                PanelHoy.Visible = false;
                PanelFiltros.Visible = true;
                mostrarVentasGraficaFechas();
            }
            else
            {
                PanelHoy.Visible = true;
                PanelFiltros.Visible = false;
                mostrarVentasGrafica();
            }
        }

        private void TXTFI_ValueChanged(object sender, EventArgs e)
        {
            mostrarVentasGraficaFechas();
        }

        private void TXTFF_ValueChanged(object sender, EventArgs e)
        {
            mostrarVentasGraficaFechas();
        }

        private void lblhastaHoy_Click(object sender, EventArgs e)
        {
            mostrarVentasGrafica();
          
        }

        private void txtaño_gasto_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReporteGastosAnio();
            ReporteGastosMesCombo();
        }
        private void ReporteGastosAnio()
        {
            DataTable dt = new DataTable();
            año =Convert.ToInt32 (txtaño_gasto.Text);
            Obtener_datos.ReporteGastosAnio(ref dt, año);
            ArrayList monto = new ArrayList();
            ArrayList descripcion = new ArrayList();
            foreach (DataRow filas in dt.Rows )
            {
                monto.Add(filas["Monto"]);
                descripcion.Add(filas["Descripcion"]);
            }
            chartGastosAño.Series[0].Points.DataBindXY(descripcion, monto);
        }
        private void ReporteGastosAnioMesGrafica()
        {
            DataTable dt = new DataTable();
            año = Convert.ToInt32(txtaño_gasto.Text);
            Obtener_datos.ReporteGastosAnioMesGrafica(ref dt, año, txtmes_gasto.Text);
            ArrayList monto = new ArrayList();
            ArrayList descripcion = new ArrayList();
            foreach (DataRow filas in dt.Rows)
            {
                monto.Add(filas["Monto"]);
                descripcion.Add(filas["Descripcion"]);
            }
            chartGastosMes.Series[0].Points.DataBindXY(descripcion, monto);
        }

        private void txtmes_gasto_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReporteGastosAnioMesGrafica();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }  
    
}
