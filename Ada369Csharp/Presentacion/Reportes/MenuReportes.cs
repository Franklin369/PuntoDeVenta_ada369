using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ada369Csharp.Datos;
using Ada369Csharp.Presentacion.REPORTES.REPORTES_DE_KARDEX_listo.REPORTES_DE_INVENTARIOS_todos;

namespace Ada369Csharp.Presentacion.REPORTES
{
    public partial class MenuReportes : UserControl
    {
        public MenuReportes()
        {
            InitializeComponent();
        }
        int idusuario;
        private void MenuReportes_Load(object sender, EventArgs e)
        {
            PanelBienvenida.Visible = true;
            PanelBienvenida.Dock = DockStyle.Fill;
            TXTFI.Value = DateTime.Now;
            TXTFF.Value= DateTime.Now;
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            panelVentas.Visible = true;
            panelVentas.Dock = DockStyle.Fill;
            PanelBienvenida.Visible = false;
            PanelProductos.Visible = false;
            PanelPorCobrarPagar.Visible = false;
            //--------------Paneles
            panel6.Enabled = false;
            PanelEmpleado.Visible = false;
            //Botones
            btnVentas.BackColor = Color.White;
            btnVentas.ForeColor = Color.OrangeRed;
            btnCobrar.BackColor = Color.FromArgb(242, 243, 244);
            btnCobrar.ForeColor = Color.FromArgb(64, 64, 64);
            BtnPagar.ForeColor = Color.FromArgb(64, 64, 64);
            BtnPagar.BackColor = Color.FromArgb(242, 243, 244);
            BtnProductos.ForeColor = Color.FromArgb(64, 64, 64);
            BtnProductos.BackColor = Color.FromArgb(242, 243, 244);
            //Controles internos
            chekFiltros.Checked = false;
            PanelFiltros.Visible = false;
        }

        private void btnResumenVentas_Click(object sender, EventArgs e)
        {
            panel6.Enabled = true;
            btnResumenVentas.ForeColor = Color.OrangeRed;
            btnEmpleado.ForeColor = Color.DimGray;
            PResumenVentas.Visible = true;
            PVentasPorempleado.Visible = false;    
            btnHoy.ForeColor = Color.OrangeRed;
            PanelEmpleado.Visible = false;
            chekFiltros.Checked = false;
            PanelFiltros.Visible = false;
            TFILTROS.ForeColor = Color.DimGray;
            ReporteResumenVentasHoy();
        }
        private void ReporteResumenVentasHoy()
        {
            DataTable dt = new DataTable();
            Obtener_datos.ReporteResumenVentasHoy(ref dt);
            ReporteVentas.ResumenVentas rpt = new ReporteVentas.ResumenVentas();
            rpt.table1.DataSource = dt;
            rpt.DataSource = dt;
            reportViewer1.Report = rpt;
            reportViewer1.RefreshReport();
        }

        private void btnHoy_Click(object sender, EventArgs e)
        {
            if (PResumenVentas.Visible == true)
            {
                ReporteResumenVentasHoy();
            }
            if (PVentasPorempleado.Visible == true)
            {
                ReporteResumenVentasHoyEmpleado();

            }
            btnHoy.ForeColor = Color.OrangeRed;
            chekFiltros.Checked = false;
            PanelFiltros.Visible = false;          
            TFILTROS.ForeColor = Color.DimGray;
        }

        private void chekFiltros_CheckedChanged(object sender, EventArgs e)
        {
            if (chekFiltros.Checked==true)
            {
                if (PResumenVentas.Visible==true)
                {
                    ReporteResumenVentasFechas();
                }
                if (PVentasPorempleado.Visible==true)
                {
                    ReporteResumenVentasEmpleadoFechas();
                }
                btnHoy.ForeColor = Color.DimGray;
                PanelFiltros.Visible = true;
                TFILTROS.ForeColor = Color.OrangeRed;
            }
            else
            {
                if (PResumenVentas.Visible == true)
                {
                    ReporteResumenVentasHoy();
                }
                if (PVentasPorempleado.Visible == true)
                {
                    ReporteResumenVentasHoyEmpleado();
                }
                btnHoy.ForeColor = Color.OrangeRed;
                PanelFiltros.Visible = false;
                TFILTROS.ForeColor = Color.DimGray;

            }
        }
        private void ReporteResumenVentasFechas()
        {
            DataTable dt = new DataTable();
            Obtener_datos.ReporteResumenVentasFechas(ref dt, TXTFI.Value, TXTFF.Value);
            ReporteVentas.ResumenVentas rpt = new ReporteVentas.ResumenVentas();
            rpt.table1.DataSource = dt;
            rpt.DataSource = dt;
            reportViewer1.Report = rpt;
            reportViewer1.RefreshReport();
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            panel6.Enabled = true;
            btnResumenVentas.ForeColor = Color.DimGray;
            btnEmpleado.ForeColor = Color.OrangeRed;
            PResumenVentas.Visible = false;
            PVentasPorempleado.Visible = true;
            btnHoy.ForeColor = Color.OrangeRed;
       
            chekFiltros.Checked = false;
            PanelFiltros.Visible = false;
            TFILTROS.ForeColor = Color.DimGray;
            PanelEmpleado.Visible = true;
            mostrarUsuarios();
            ReporteResumenVentasHoyEmpleado();
        }
        private void ReporteResumenVentasHoyEmpleado()
        {
            DataTable dt = new DataTable();
            Obtener_datos.ReporteResumenVentasHoyEmpleado(ref dt, idusuario);
            ReporteVentas.ResumenVentas rpt = new ReporteVentas.ResumenVentas();
            rpt.table1.DataSource = dt;
            rpt.DataSource = dt;
            reportViewer1.Report = rpt;
            reportViewer1.RefreshReport();
        }
        private void ReporteResumenVentasEmpleadoFechas()
        {
            DataTable dt = new DataTable();
            Obtener_datos.ReporteResumenVentasEmpleadoFechas(ref dt, idusuario,TXTFI.Value , TXTFF.Value );
            ReporteVentas.ResumenVentas rpt = new ReporteVentas.ResumenVentas();
            rpt.table1.DataSource = dt;
            rpt.DataSource = dt;
            reportViewer1.Report = rpt;
            reportViewer1.RefreshReport();
        }
        private void mostrarUsuarios()
        {
            DataTable dt = new DataTable();
            Obtener_datos.mostrarUsuarios(ref dt);
            txtEmpleado.DisplayMember = "Nombres_y_Apellidos";
            txtEmpleado.ValueMember = "idUsuario";
            txtEmpleado.DataSource = dt;

        }

        private void txtEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            idusuario =Convert.ToInt32 ( txtEmpleado.SelectedValue);
            if (chekFiltros.Checked==true )
            {
                ReporteResumenVentasEmpleadoFechas();
            }
            else

            {
                ReporteResumenVentasHoyEmpleado();
            }

        }

        private void TXTFI_ValueChanged(object sender, EventArgs e)
        {
            validarFiltros();
        }

        private void TXTFF_ValueChanged(object sender, EventArgs e)
        {
            validarFiltros();
        }
        private void validarFiltros()
        {
        if (chekFiltros.Checked == true)
            {
                if (PResumenVentas.Visible == true)
                {
                    ReporteResumenVentasFechas();
                }
                if (PVentasPorempleado.Visible == true)
                {
                    ReporteResumenVentasEmpleadoFechas();
                }
            }
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            panelVentas.Visible = false;
            PanelBienvenida.Visible = false;
            PanelProductos.Visible = false;
            PanelPorCobrarPagar.Visible = true;
            PanelPorCobrarPagar.Dock = DockStyle.Fill;
            //Botones
            btnVentas.BackColor = Color.FromArgb(242, 243, 244);
            btnVentas.ForeColor = Color.FromArgb(64, 64, 64);
            btnCobrar.BackColor = Color.White;
            btnCobrar.ForeColor = Color.OrangeRed;
            BtnPagar.ForeColor = Color.FromArgb(64, 64, 64);
            BtnPagar.BackColor = Color.FromArgb(242, 243, 244);
            BtnProductos.ForeColor = Color.FromArgb(64, 64, 64);
            BtnProductos.BackColor = Color.FromArgb(242, 243, 244);
            ReporteCuestasPorCobrar();
        }
        private void ReporteCuestasPorCobrar()
        {
            DataTable dt = new DataTable();
            Obtener_datos.ReporteCuestasPorCobrar(ref dt);
            ReportePorCobrar.ReporteCobrar rpt = new ReportePorCobrar.ReporteCobrar();
            rpt.Table1.DataSource = dt;
            rpt.DataSource = dt;
            reportViewer2.Report = rpt;
            reportViewer2.RefreshReport();
        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            panelVentas.Visible = false;
            PanelBienvenida.Visible = false;
            PanelProductos.Visible = false;
            PanelPorCobrarPagar.Visible = true;
            PanelPorCobrarPagar.Dock = DockStyle.Fill;
            //Botones
            btnVentas.BackColor = Color.FromArgb(242, 243, 244);
            btnVentas.ForeColor = Color.FromArgb(64, 64, 64);
            btnCobrar.BackColor = Color.FromArgb(242, 243, 244);
            btnCobrar.ForeColor = Color.FromArgb(64, 64, 64);
            BtnPagar.ForeColor = Color.OrangeRed;
            BtnPagar.BackColor = Color.White;
            BtnProductos.ForeColor = Color.FromArgb(64, 64, 64);
            BtnProductos.BackColor = Color.FromArgb(242, 243, 244);
            ReporteCuestasPorPagar();
        }
        private void ReporteCuestasPorPagar()
        {
            DataTable dt = new DataTable();
            Obtener_datos.ReporteCuestasPorPagar(ref dt);
            ReportePorPagar.ReportePagar rpt = new ReportePorPagar.ReportePagar();
            rpt.Table1.DataSource = dt;
            rpt.DataSource = dt;
            reportViewer2.Report = rpt;
            reportViewer2.RefreshReport();
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            panelVentas.Visible = false;
            PanelBienvenida.Visible = false;
            PanelProductos.Visible = true;
            PanelProductos.Dock = DockStyle.Fill;
            PanelPorCobrarPagar.Visible = false;
            //Botones
            btnVentas.BackColor = Color.FromArgb(242, 243, 244);
            btnVentas.ForeColor = Color.FromArgb(64, 64, 64);
            btnCobrar.BackColor = Color.FromArgb(242, 243, 244);
            btnCobrar.ForeColor = Color.FromArgb(64, 64, 64);
            BtnPagar.ForeColor = Color.FromArgb(64, 64, 64);
            BtnPagar.BackColor = Color.FromArgb(242, 243, 244);
            BtnProductos.ForeColor = Color.OrangeRed;
            BtnProductos.BackColor = Color.White;
            //Paneles
            PInventarios.Visible = false;
            Pvencidos.Visible = false;
            PStockBajo.Visible = false;
            ReportViewer3.Visible = false;
        }

        private void btnInventarios_Click(object sender, EventArgs e)
        {
            PInventarios.Visible = true;
            PStockBajo.Visible = false;
            Pvencidos.Visible = false;
            ReportViewer3.Visible = true;
            imprimir_inventarios_todos();
        }
        private void imprimir_inventarios_todos()
        {
            var dt = new DataTable();
            var funcion = new Dproductos();
            funcion.ReporteInventarios(ref dt);
            var rpt = new ReportInventarios_Todos();
            rpt.table1.DataSource = dt;
            rpt.DataSource = dt;
            ReportViewer3.Report = rpt;
            ReportViewer3.RefreshReport();
        }

        private void btnPvencidos_Click(object sender, EventArgs e)
        {
            PInventarios.Visible = false;
            PStockBajo.Visible = false;
            Pvencidos.Visible = true;
            ReportViewer3.Visible = true;
            mostrar_productos_vencidos();
        }
        private void mostrar_productos_vencidos()
        {
            DataTable dt = new DataTable ();
            Obtener_datos.mostrar_productos_vencidos(ref dt);
            var rpt = new ReportePVencidos();
            rpt.table1.DataSource = dt;
            rpt.DataSource = dt;
            ReportViewer3.Report = rpt;
            ReportViewer3.RefreshReport();
        }

        private void btnStockBajo_Click(object sender, EventArgs e)
        {
            PInventarios.Visible = false;
            PStockBajo.Visible = true;
            Pvencidos.Visible = false;
            ReportViewer3.Visible = true;
            mostrarProdctosMinimo();
        }
        private void mostrarProdctosMinimo()
        {
            var  dt = new DataTable();
            var funcion = new Dproductos();
            funcion.ReporteInvBajoMin(ref dt);
            var rpt = new ReportePbajomin();
            rpt.table1.DataSource = dt;
            rpt.DataSource = dt;
            ReportViewer3.Report = rpt;
            ReportViewer3.RefreshReport();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }

}
