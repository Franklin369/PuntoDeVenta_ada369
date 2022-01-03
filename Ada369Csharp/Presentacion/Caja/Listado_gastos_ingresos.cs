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
namespace Ada369Csharp.Presentacion.CAJA
{
    public partial class Listado_gastos_ingresos : UserControl
    {
        public Listado_gastos_ingresos()
        {
            InitializeComponent();
        }
        int idcaja;
        DateTime fechaInicial;
        DateTime fechafinal;
        private void Listado_gastos_ingresos_Load(object sender, EventArgs e)
        {
            fechafinal = DateTime.Now;
            Mostrar_cierres_de_caja_pendiente();
            listar_gastos();
            listar_ingresos();
        }
        private void sumar_gastos()
        {
            double total=0;
            foreach (DataGridViewRow fila in datalistadoGastos.Rows )
            {
                total +=Convert.ToDouble ( (fila.Cells["Importe"].Value));
            }
            lbltotalGastos.Text =Convert.ToString (total);
        }
        private void sumar_Ingresos()
        {
            double total = 0;
            foreach (DataGridViewRow fila in datalistadoIngresos .Rows)
            {
                total += Convert.ToDouble((fila.Cells["Importe"].Value));
            }
            lbltotalIngresos .Text = Convert.ToString(total);
        }
        private void listar_gastos()
        {
            DataTable dt = new DataTable();
            Obtener_datos.mostrar_gastos_por_turnos(idcaja, fechaInicial, fechafinal, ref dt);
            datalistadoGastos.DataSource = dt;
            datalistadoGastos.Columns[1].Visible = false;
            Bases.Multilinea(ref datalistadoGastos);
            sumar_gastos();
        }
        private void listar_ingresos()
        {
            DataTable dt = new DataTable();
            Obtener_datos.mostrar_ingresos_por_turnos (idcaja, fechaInicial, fechafinal, ref dt);
            datalistadoIngresos.DataSource = dt;
            Bases.Multilinea(ref datalistadoIngresos);
            datalistadoIngresos.Columns[1].Visible = false;
            sumar_Ingresos();
        }
        private void Mostrar_cierres_de_caja_pendiente()
        {
            DataTable dt = new DataTable();
            Obtener_datos.mostrar_cierre_de_caja_pendiente(ref dt);
            foreach (DataRow dr in dt.Rows)
            {
                idcaja =Convert.ToInt32 ( dr["Id_caja"]);
                fechaInicial =Convert.ToDateTime(dr["fechainicio"]);
            }
        }

        private void datalistadoGastos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == datalistadoGastos.Columns ["EliminarG"].Index )
            {
                DialogResult result = MessageBox.Show("¿Realmente desea eliminar este Gasto?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result==DialogResult.OK )
                {
                    int idgasto = Convert.ToInt32(datalistadoGastos.SelectedCells[1].Value);
                    Eliminar_datos.eliminar_gasto(idgasto);
                    listar_gastos();
                }
            }
        }

        private void datalistadoIngresos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == datalistadoIngresos.Columns["EliminarI"].Index)
            {
                DialogResult result = MessageBox.Show("¿Realmente desea eliminar este Ingreso?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    int idingreso = Convert.ToInt32(datalistadoIngresos.SelectedCells[1].Value);
                    Eliminar_datos.eliminar_ingreso (idingreso);
                    listar_ingresos();
                }
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
