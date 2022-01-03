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
using System.Globalization;
using System.Data.OleDb;
using System.IO;
using System.Threading;
using Ada369Csharp.Logica;
using Ada369Csharp.Datos;
using Ada369Csharp.Presentacion.REPORTES.REPORTES_DE_KARDEX_listo.Reporte_de_Kardex_diseño;
using Ada369Csharp.Presentacion.REPORTES.REPORTES_DE_KARDEX_listo.REPORTES_DE_INVENTARIOS_todos;
using Ada369Csharp.Presentacion.INVENTARIOS_KARDEX;

namespace Ada369Csharp.Presentacion.Inventarios

{
    public partial class Menuinv : UserControl
    {
        public Menuinv()
        {
            InitializeComponent();
        }


        private void buscar_productos_movimientos()
        {
            try
            {
                var dt = new DataTable();
                var funcion = new Dkardex();
                funcion.BuscarprodInvent(ref dt, txtbuscarMov.Text);
                dgProductosMov.DataSource = dt;
                dgProductosMov.Visible = true;
                Bases.Multilinea(ref dgProductosMov);
                dgProductosMov.Columns[0].Visible = false;
                dgProductosMov.Size = new Size(369, 129);
                dgProductosMov.Location = new Point(txtbuscarMov.Location.X, txtbuscarMov.Location.Y + 25);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MOSTRAR_Inventarios_bajo_minimo()
        {
            try
            {
                var dt = new DataTable();
                var funcion = new Dproductos();
                funcion.ReporteProductoBajoMinimo(ref dt);
                datalistadoInventarioBAJO.DataSource = dt;
                Bases.Multilinea(ref datalistadoInventarioBAJO);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtbuscarMovimiento_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscarMov.Text == "Buscar producto" | txtbuscarMov.Text == "")
            {
                dgProductosMov.Visible = false;

            }
            else
            {
                dgProductosMov.Visible = true;
                buscar_productos_movimientos();
            }



        }


        public static int idProducto;
        private void DATALISTADO_PRODUCTOS_Movimientos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idProducto = Convert.ToInt32(dgProductosMov.SelectedCells[0].Value);
            txtbuscarMov.Text = dgProductosMov.SelectedCells[1].Value.ToString();
            dgProductosMov.Visible = false;
            buscar_MOVIMIENTOS_DE_KARDEX();
        }
        private void buscar_MOVIMIENTOS_DE_KARDEX()
        {
            try
            {
                var dt = new DataTable();
                var funcion = new Dkardex();
                var parametros = new LKardex();
                parametros.Id_producto = idProducto;
                funcion.ReportKardexMov(ref dt, parametros);
                DatalistadoMovimientos.DataSource = dt;
                Bases.Multilinea(ref DatalistadoMovimientos);
                DatalistadoMovimientos.Columns[10].Visible = false;
                DatalistadoMovimientos.Columns[11].Visible = false;
                DatalistadoMovimientos.Columns[12].Visible = false;
                DatalistadoMovimientos.Columns[14].Visible = false;
                DatalistadoMovimientos.Columns[7].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void buscar_MOVIMIENTOS_FILTROS()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();

                da = new SqlDataAdapter("buscar_MOVIMIENTOS_DE_KARDEX_filtros", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@fecha", txtfechaM.Value);
                da.SelectCommand.Parameters.AddWithValue("@tipo", txtTipoMovi.Text);
                da.SelectCommand.Parameters.AddWithValue("@Id_usuario", txtIdusuario.Text);


                da.Fill(dt);
                DatalistadoMovimientos.DataSource = dt;
                con.Close();


                DatalistadoMovimientos.Columns[0].Visible = false;
                DatalistadoMovimientos.Columns[10].Visible = false;
                DatalistadoMovimientos.Columns[11].Visible = false;

                DatalistadoMovimientos.Columns[9].Visible = false;
                DatalistadoMovimientos.Columns[13].Visible = false;
                DatalistadoMovimientos.Columns[14].Visible = false;
                DatalistadoMovimientos.Columns[12].Visible = false;
                Bases.Multilinea(ref DatalistadoMovimientos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void buscar_MOVIMIENTOS_FILTROS_ACUMULADO()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();

                da = new SqlDataAdapter("buscar_MOVIMIENTOS_DE_KARDEX_filtros_acumulado", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@fecha", txtfechaM.Value);
                da.SelectCommand.Parameters.AddWithValue("@tipo", txtTipoMovi.Text);
                da.SelectCommand.Parameters.AddWithValue("@Id_usuario", txtIdusuario.Text);


                da.Fill(dt);
                DatalistadoMovimientosACUMULADO_PRODUCTO.DataSource = dt;
                con.Close();


                DatalistadoMovimientosACUMULADO_PRODUCTO.Columns[4].Visible = false;
                DatalistadoMovimientosACUMULADO_PRODUCTO.Columns[5].Visible = false;
                DatalistadoMovimientosACUMULADO_PRODUCTO.Columns[6].Visible = false;

                Bases.Multilinea(ref DatalistadoMovimientosACUMULADO_PRODUCTO);
                DataGridViewCellStyle styCabeceras = new DataGridViewCellStyle();
                styCabeceras.BackColor = System.Drawing.Color.FromArgb(26, 115, 232);
                styCabeceras.ForeColor = System.Drawing.Color.White;
                styCabeceras.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                DatalistadoMovimientosACUMULADO_PRODUCTO.ColumnHeadersDefaultCellStyle = styCabeceras;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            dgProductosMov.Visible = false;
            txtTipoMovi.Text = "-Todos-";
            buscar_MOVIMIENTOS_FILTROS();
            buscar_MOVIMIENTOS_FILTROS_ACUMULADO();
            panel7.Visible = true;
            MenuStrip2.Visible = false;

        }

        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var frm = new FormMovimientosBuscar();
            frm.ShowDialog();
        }

        private void tver_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
            groupBox1.Visible = false;
            buscar_MOVIMIENTOS_DE_KARDEX();
            txtTipoMovi.Text = "-Todos-";
            txtbuscarMov.Text = "Buscar producto";
            MenuStrip2.Visible = true;
        }

        private void txtfechaM_ValueChanged(object sender, EventArgs e)
        {
            if (groupBox1.Visible == true)
            {
                buscar_MOVIMIENTOS_FILTROS();
                buscar_MOVIMIENTOS_FILTROS_ACUMULADO();
            }


        }

        private void txtTipoMovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (groupBox1.Visible == true)
            {

                buscar_MOVIMIENTOS_FILTROS();
                buscar_MOVIMIENTOS_FILTROS_ACUMULADO();
            }
        }

        private void txtUSUARIOS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (groupBox1.Visible == true)
            {

                Buscar_id_USUARIOS();
                buscar_MOVIMIENTOS_FILTROS();
                buscar_MOVIMIENTOS_FILTROS_ACUMULADO();
            }
        }

        internal void Buscar_id_USUARIOS()
        {

            string resultado;
            string queryMoneda;
            queryMoneda = "Buscar_id_USUARIOS";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;

            SqlCommand comMoneda = new SqlCommand(queryMoneda, con);
            comMoneda.CommandType = CommandType.StoredProcedure;
            comMoneda.Parameters.AddWithValue("@Nombre_y_Apelllidos", txtUSUARIOS.Text);
            try
            {
                con.Open();
                resultado = Convert.ToString(comMoneda.ExecuteScalar()); //asignamos el valor del importe
                txtIdusuario.Text = resultado;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                resultado = "";
            }
        }
        private void buscar_usuario()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();

                da = new SqlDataAdapter("select*from USUARIO2", con);

                da.Fill(dt);
                txtUSUARIOS.DisplayMember = "Nombres_y_Apellidos";
                txtUSUARIOS.ValueMember = "idUsuario";

                txtUSUARIOS.DataSource = dt;
                //txtIdusuario.Text = txtUSUARIOS.ValueMember;

                con.Close();
                Buscar_id_USUARIOS();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }


        }

        private void ReportkardexMov()
        {
            try
            {
                var dt = new DataTable();
                var funcion = new Dkardex();
                var parametros = new LKardex();
                parametros.Id_producto = idProducto;
                funcion.ReportKardexMov(ref dt, parametros);
                var rpt = new ReportKARDEX_Movimientos_ok();
                rpt.DataSource = dt;
                rpt.table1.DataSource = dt;
                reportViewer1.Report = rpt;
                reportViewer1.RefreshReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }
        private void INVENTARIO_MENU_Load(object sender, EventArgs e)
        {
            PanelMOVIMIENTOS.Dock = DockStyle.None;
            PanelREPORTEInventario.Dock = DockStyle.None;
            PaneliNVENTARIObajo.Dock = DockStyle.None;
            PanelMOVIMIENTOS.Visible = false;
            PanelREPORTEInventario.Visible = false;
            PaneliNVENTARIObajo.Visible = false;
            PanelKardex.Visible = true;
            PanelKardex.Dock = DockStyle.Fill;
            Panelv.Visible = false;
            PanelVencimientos.Visible = false;
            PanelVencimientos.Dock = DockStyle.None;

            PanelK.Visible = true;
            PanelI.Visible = false;
            PanelM.Visible = false;
            PanelR.Visible = false;
            Panelv.Visible = false;

            txtbuscarKardexMov.Text = "Buscar producto";

        }

        

        private void TNOTAS_Click(object sender, EventArgs e)
        {
            MOSTRAR_Inventarios_bajo_minimo();
        }

        private void TNOTAS_Click_1(object sender, EventArgs e)
        {
            PanelMOVIMIENTOS.Dock = DockStyle.None;
            PanelREPORTEInventario.Dock = DockStyle.None;

            PanelMOVIMIENTOS.Visible = false;
            PanelREPORTEInventario.Visible = false;
            PaneliNVENTARIObajo.Visible = true;
            PaneliNVENTARIObajo.Dock = DockStyle.Fill;
            PanelKardex.Visible = false;
            PanelKardex.Dock = DockStyle.None;
            PanelK.Visible = false;
            PanelI.Visible = true;
            PanelM.Visible = false;
            PanelR.Visible = false;
            Panelv.Visible = false;
            PanelVencimientos.Visible = false;
            PanelVencimientos.Dock = DockStyle.None;
            Panelv.Visible = false;
            MOSTRAR_Inventarios_bajo_minimo();

        }

       
        internal void sumar_costo_de_inventario_CONTAR_PRODUCTOS()
        {


            string resultado;
            string queryMoneda;
            queryMoneda = "SELECT Moneda  FROM EMPRESA";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
            SqlCommand comMoneda = new SqlCommand(queryMoneda, con);
            try
            {
                con.Open();
                resultado = Convert.ToString(comMoneda.ExecuteScalar()); //asignamos el valor del importe
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                resultado = "";
            }

            string importe;
            string query;
            query = "SELECT      CONVERT(NUMERIC(18,2),sum(Producto1.Precio_de_compra * Stock )) as suma FROM  Producto1 where  Usa_inventarios ='SI'";

            SqlCommand com = new SqlCommand(query, con);
            try
            {
                con.Open();
                importe = Convert.ToString(com.ExecuteScalar()); //asignamos el valor del importe
                con.Close();
                lblcostoInventario.Text = resultado + " " + importe;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);

                lblcostoInventario.Text = resultado + " " + 0;
            }

            string conteoresultado;
            string querycontar;
            querycontar = "select count(Id_Producto1 ) from Producto1 ";
            SqlCommand comcontar = new SqlCommand(querycontar, con);
            try
            {
                con.Open();
                conteoresultado = Convert.ToString(comcontar.ExecuteScalar()); //asignamos el valor del importe
                con.Close();
                lblcantidaddeProductosEnInventario.Text = conteoresultado;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);

                conteoresultado = "";
                lblcantidaddeProductosEnInventario.Text = "0";
            }

        }

        private void RptInventarios()
        {
            try
            {
                var dt = new DataTable();
                var funcion = new Dkardex();
                funcion.mostrarInventarios(ref dt);
                var rpt = new ReportInventarios_Todos();
                rpt.DataSource = dt;
                rpt.table1.DataSource = dt;
                rptInventarios.Report = rpt;
                rptInventarios.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TOTROSPAGOS_Click(object sender, EventArgs e)
        {
            PanelR.Visible = true;
            PanelK.Visible = false;
            PanelI.Visible = false;
            PanelM.Visible = false;
            Panelv.Visible = false;
            PanelMOVIMIENTOS.Visible = false;
            PanelREPORTEInventario.Visible = true;
            PaneliNVENTARIObajo.Visible = false;
            PanelMOVIMIENTOS.Dock = DockStyle.None;
            PanelREPORTEInventario.Dock = DockStyle.Fill;
            PaneliNVENTARIObajo.Dock = DockStyle.None;
            PanelKardex.Visible = false;
            PanelKardex.Dock = DockStyle.None;
            PanelVencimientos.Visible = false;
            PanelVencimientos.Dock = DockStyle.None;
            Panelv.Visible = false;
            RptInventarios();
            sumar_costo_de_inventario_CONTAR_PRODUCTOS();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarVencimientos.Text != "Buscar producto/Codigo")
            {
                buscar_productos_vencidos();
                CheckPorVenceren30Dias.Checked = false;
                CheckProductosVencidos.Checked = false;

            }
        }
        private void buscar_productos_vencidos()
        {
            try
            {
                var dt = new DataTable();
                var funcion = new Dkardex();
                funcion.BuscarprodInvent(ref dt, txtBuscarVencimientos.Text);
                datalistadoVencimientos.DataSource = dt;
                datalistadoVencimientos.Visible = true;
                Bases.Multilinea(ref dgproductos);
                datalistadoVencimientos.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtBuscarVencimientos_Click(object sender, EventArgs e)
        {
            txtBuscarVencimientos.SelectAll();
        }

        private void CheckPorVenceren30Dias_CheckedChanged(object sender, EventArgs e)
        {
            mostrar_productos_vencidos_en_menos_de_30_dias();
            txtBuscarVencimientos.Text = "Buscar producto/Codigo";

        }
        private void mostrar_productos_vencidos_en_menos_de_30_dias()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();

                da = new SqlDataAdapter("mostrar_productos_vencidos_en_menos_de_30_dias", con);


                da.Fill(dt);
                datalistadoVencimientos.DataSource = dt;
                con.Close();


                datalistadoVencimientos.Columns[0].Visible = false;
                datalistadoVencimientos.Columns[1].Visible = false;

                Bases.Multilinea(ref datalistadoVencimientos);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void mostrar_productos_vencidos()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();

                da = new SqlDataAdapter("mostrar_productos_vencidos", con);


                da.Fill(dt);
                datalistadoVencimientos.DataSource = dt;
                con.Close();


                datalistadoVencimientos.Columns[0].Visible = false;
                datalistadoVencimientos.Columns[1].Visible = false;

                Bases.Multilinea(ref datalistadoVencimientos);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckProductosVencidos_CheckedChanged(object sender, EventArgs e)
        {
            mostrar_productos_vencidos();
            txtBuscarVencimientos.Text = "Buscar producto/Codigo";

        }

        private void TKardex_Click(object sender, EventArgs e)
        {
            PanelR.Visible = false;
            PanelK.Visible = true;
            PanelI.Visible = false;
            PanelM.Visible = false;
            Panelv.Visible = false;

            PanelMOVIMIENTOS.Dock = DockStyle.None;
            PanelREPORTEInventario.Dock = DockStyle.None;
            PaneliNVENTARIObajo.Dock = DockStyle.None;
            PanelMOVIMIENTOS.Visible = false;
            PanelREPORTEInventario.Visible = false;
            PaneliNVENTARIObajo.Visible = false;
            PanelKardex.Visible = true;
            PanelKardex.Dock = DockStyle.Fill;
            PanelVencimientos.Visible = false;
            PanelVencimientos.Dock = DockStyle.None;
            Panelv.Visible = false;
            txtbuscarKardexMov.Text = "Buscar producto";
        }

        private void TMOVIMIENTOS_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
            PanelR.Visible = false;
            PanelK.Visible = false;
            PanelI.Visible = false;
            PanelM.Visible = true;
            Panelv.Visible = false;
            PanelMOVIMIENTOS.Visible = true;
            PanelREPORTEInventario.Visible = false;

            PanelMOVIMIENTOS.Dock = DockStyle.Fill;
            PanelREPORTEInventario.Dock = DockStyle.None;
            PaneliNVENTARIObajo.Dock = DockStyle.None;
            PaneliNVENTARIObajo.Visible = false;
            PanelKardex.Visible = false;
            PanelKardex.Dock = DockStyle.None;
            PanelVencimientos.Visible = false;
            PanelVencimientos.Dock = DockStyle.None;
            Panelv.Visible = false;
            buscar_productos_movimientos();
            buscar_usuario();
            Buscar_id_USUARIOS();
            txtbuscarMov.Text = "Buscar producto";
            MenuStrip2.Visible = true;
        }

       

        private void TVencimientos_Click(object sender, EventArgs e)
        {
            PanelR.Visible = false;
            PanelK.Visible = false;
            PanelI.Visible = false;
            PanelM.Visible = false;
            Panelv.Visible = true;
            PanelMOVIMIENTOS.Visible = false;
            PanelREPORTEInventario.Visible = false;
            PaneliNVENTARIObajo.Visible = false;
            PanelMOVIMIENTOS.Dock = DockStyle.None;
            PanelREPORTEInventario.Dock = DockStyle.None;
            PaneliNVENTARIObajo.Dock = DockStyle.None;
            PanelKardex.Visible = false;
            PanelKardex.Dock = DockStyle.None;
            PanelVencimientos.Visible = true;
            PanelVencimientos.Dock = DockStyle.Fill;
            Panelv.Visible = true;
            txtBuscarVencimientos.Text = "Buscar producto/Codigo";
        }

        private void txtbuscarKardex_movimientos_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscarKardexMov.Text == "Buscar producto" | txtbuscarKardexMov.Text == "")
            {
                dgproductos.Visible = false;
            }
            else
            {
                buscar_productos_kardex();
            }

        }
        private void buscar_productos_kardex()
        {
            try
            {
                var dt = new DataTable();
                var funcion = new Dkardex();
                funcion.BuscarprodInvent(ref dt, txtbuscarKardexMov.Text);
                dgproductos.DataSource = dt;
                dgproductos.Visible = true;
                Bases.Multilinea(ref dgproductos);
                dgproductos.Columns[0].Visible = false;
                dgproductos.Size = new Size(369, 129);
                dgproductos.Location = new Point(txtbuscarKardexMov.Location.X, txtbuscarKardexMov.Location.Y + 25);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void DATALISTADO_PRODUCTOS_Kardex_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbuscarKardexMov.Text = dgproductos.SelectedCells[1].Value.ToString();
            idProducto = Convert.ToInt32(dgproductos.SelectedCells[0].Value);
            dgproductos.Visible = false;
            ReportkardexMov();

        }

        public static string Tipo_de_movimiento;
        public static DateTime fecha;
        public static int id_usuario;


        private void ToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Tipo_de_movimiento = txtTipoMovi.Text;
            fecha = txtfechaM.Value;
            id_usuario = Convert.ToInt32(txtIdusuario.Text);

            Presentacion.REPORTES.REPORTES_DE_KARDEX_listo.REPORTES_DE_INVENTARIOS_todos.FormReporteMovimientosFILTROS frm = new Presentacion.REPORTES.REPORTES_DE_KARDEX_listo.REPORTES_DE_INVENTARIOS_todos.FormReporteMovimientosFILTROS();
            frm.ShowDialog();
        }

      
        private void txtbuscarKardexMov_Click(object sender, EventArgs e)
        {
            txtbuscarKardexMov.SelectAll();
        }

        private void txtbuscarMov_Click(object sender, EventArgs e)
        {
            txtbuscarMov.SelectAll();
        }



        private void btnIngreso_Click(object sender, EventArgs e)
        {
            var ctl = new KardexEntrada();
            ctl.Size = new Size(Width, Height);
            this.Controls.Add(ctl);
            ctl.BringToFront();
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            var ctl = new KardexSalidas();
            ctl.Size = new Size(Width, Height);
            this.Controls.Add(ctl);
            ctl.BringToFront();
        }
    }
}
