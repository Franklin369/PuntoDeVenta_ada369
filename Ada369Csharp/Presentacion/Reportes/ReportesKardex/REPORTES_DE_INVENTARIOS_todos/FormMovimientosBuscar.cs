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
using Ada369Csharp.Datos;
using Ada369Csharp.Logica;

namespace Ada369Csharp.Presentacion.REPORTES.REPORTES_DE_KARDEX_listo.REPORTES_DE_INVENTARIOS_todos
{
    public partial class FormMovimientosBuscar : Form
    {
        public FormMovimientosBuscar()
        {
            InitializeComponent();
        }

        private void FormMovimientosBuscar_Load(object sender, EventArgs e)
        {
            mostrar();
        }
        ReportMovimientosBuscar rptFREPORT2 = new ReportMovimientosBuscar();
        private void mostrar()
        {
            try
            {
                DataTable dt = new DataTable();
                var funcion = new Dkardex();
                var parametros = new LKardex();
                parametros.Id_producto = Menuinv.idProducto;
                funcion.ReportKardexMov(ref dt, parametros);
                rptFREPORT2 = new ReportMovimientosBuscar();
                rptFREPORT2.DataSource = dt;
                reportViewer1.Report = rptFREPORT2;
                reportViewer1.RefreshReport ();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }
    }
}
