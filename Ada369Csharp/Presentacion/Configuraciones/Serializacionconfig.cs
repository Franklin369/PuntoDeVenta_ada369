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
using Ada369Csharp.Logica;
using Sunat.Logica;
using Ada369Csharp.Datos;
namespace Ada369Csharp.Presentacion.Configuraciones
{
    public partial class Serializacionconfig : UserControl
    {

        public Serializacionconfig()
        {
            InitializeComponent();
        }
        string valor_por_defecto;
        int idserie;
        string Envioinmediato;
        private void Serializacionconfig_Load(object sender, EventArgs e)
        {
            Mostrar();
            panel3.Visible = false;
        }
        private void Mostrar()
        {
            var dt = new DataTable();
            var funcion = new Dserializacion();
            funcion.ListarSerializacion(ref dt);
            datalistado.DataSource = dt;
            datalistado.Columns[1].Visible = false;
            datalistado.Columns[3].Visible = false;
            datalistado.Columns[4].Visible = false;
            datalistado.Columns[5].Visible = false;
            datalistado.Columns[6].Visible = false;
            datalistado.Columns[7].Visible = false;
            datalistado.Columns[8].Visible = false;
            datalistado.Columns[9].Visible = false;
            Bases.Multilinea(ref datalistado);

        }

        private void GUARDARCAMBIOS_Click(object sender, EventArgs e)
        {
            Editarserializacion();

        }
        private void validarEnvioinmediato()
        {
            if (checkenvioinmediato.Checked == true)
            {
                Envioinmediato = "SI";
            }
            else
            {
                Envioinmediato = "NO";
            }
        }
        private void validarporDefecto()
        {
            if (checkDefecto.Checked == true)
            {
                valor_por_defecto = "SI";
            }
            else
            {
                valor_por_defecto = "NO";
            }
        }
        private void Editarserializacion()
        {
            validarporDefecto();
            validarEnvioinmediato();
            var funcion = new Dserializacion();
            var parametros = new Lserializacion();
            parametros.Serie = txtSerie.Text;
            parametros.Cantidadnumeros = TXTCANTIDADDECEROS.Text;
            parametros.numerofin = txtnumerofin.Text;
            parametros.tipodoc = TXTCOMPRO.Text;
            parametros.Id_serializacion = idserie;
            parametros.Envioinmediato = Envioinmediato;
            if (funcion.editarSerializacion(parametros) == true)
            {
                elijirPordefecto();
                Mostrar();
                panel3.Visible = false;
            }
        }
        private void elijirPordefecto()
        {
            if (checkDefecto.Checked == true)
            {
                var funcion = new Dserializacion();
                var parametros = new Lserializacion();
                parametros.Id_serializacion = idserie;
                funcion.editarCompDefecto(parametros);
            }


        }
        private void datalistado_DoubleClick(object sender, EventArgs e)
        {
            panel3.Visible = true;
            try
            {
                idserie = Convert.ToInt32(datalistado.SelectedCells[1].Value);
                TXTCOMPRO.Text = datalistado.SelectedCells[6].Value.ToString();
                TXTCANTIDADDECEROS.Text = datalistado.SelectedCells[3].Value.ToString();
                txtnumerofin.Text = datalistado.SelectedCells[10].Value.ToString();
                txtSerie.Text = datalistado.SelectedCells[2].Value.ToString();
                btnguardar.Visible = true;
                valor_por_defecto = datalistado.SelectedCells[7].Value.ToString();
                Envioinmediato = datalistado.SelectedCells[13].Value.ToString();
                if (Envioinmediato == "SI")
                {
                    checkenvioinmediato.Checked = true;
                }
                else
                {
                    checkenvioinmediato.Checked = false;
                }
                if (valor_por_defecto == "SI")
                {
                    checkDefecto.Visible = false;
                    checkDefecto.Checked = true;
                }
                else
                {
                    checkDefecto.Visible = true;
                    checkDefecto.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void VOLVEROK_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void checkenvioinmediato_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkDefecto_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
