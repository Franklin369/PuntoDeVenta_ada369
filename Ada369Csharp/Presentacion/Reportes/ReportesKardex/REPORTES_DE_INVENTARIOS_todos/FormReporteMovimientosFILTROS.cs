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
using Ada369Csharp.Presentacion.Inventarios;

namespace Ada369Csharp.Presentacion.REPORTES.REPORTES_DE_KARDEX_listo.REPORTES_DE_INVENTARIOS_todos
{
    public partial class FormReporteMovimientosFILTROS : Form
    {
        public FormReporteMovimientosFILTROS()
        {
            InitializeComponent();
        }
        Reporte_Movimientos_con_filtros rptFREPORT2 = new Reporte_Movimientos_con_filtros();
        private void mostrar()
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
                da.SelectCommand.Parameters.AddWithValue("@fecha", Menuinv.fecha );
                da.SelectCommand.Parameters.AddWithValue("@tipo", Menuinv.Tipo_de_movimiento );
                da.SelectCommand.Parameters.AddWithValue("@Id_usuario", Menuinv.id_usuario );

                da.Fill(dt);
                con.Close();
                rptFREPORT2 = new Reporte_Movimientos_con_filtros();
                rptFREPORT2.DataSource = dt;
                rptFREPORT2.Table1.DataSource = dt;
                reportViewer1.Report = rptFREPORT2;

                reportViewer1.RefreshReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }
        private void FormReporteMovimientosFILTROS_Load(object sender, EventArgs e)
        {
            mostrar();
        }
    }
}
