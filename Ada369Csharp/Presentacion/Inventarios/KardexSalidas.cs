using Ada369Csharp.Datos;
using Ada369Csharp.Logica;
using Sunat.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ada369Csharp.Presentacion.INVENTARIOS_KARDEX
{
    public partial class KardexSalidas : UserControl
    {
        public KardexSalidas()
        {
            InitializeComponent();
        }
        int Idproducto;
        private void TXTBUSCARProducto_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }
        private void Buscar()
        {
            DataTable dt = new DataTable();
            var funcion = new Dkardex();
            funcion.BuscarprodInvent(ref dt,txtbuscar.Text);
            Bases.Multilinea(ref dgproductos);
            dgproductos.DataSource = dt;
            dgproductos.Columns[0].Visible = false;
            dgproductos.Visible = true;
            dgproductos.Size = new Size(557, 281);
            dgproductos.Location = new Point(txtbuscar.Location.X, txtbuscar.Location.Y+35);
            dgproductos.BackgroundColor = Color.White;

        }

        private void txtagregar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bases.Separador_de_Numeros(txtcantidad, e);

        }
        private void KardexSalidas_Load(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            validaciones();
        }
        private void validaciones()
        {
            if (!string.IsNullOrEmpty(txtcantidad.Text))
            {
                if (string.IsNullOrEmpty(txtcmotivo.Text))
                {
                    txtcmotivo.Text = "SIN MOTIVO";
                }
                Disminuir();

            }
            else
            {
                MessageBox.Show("El valor a agregar no puede estar vacio", "Valores vacios");
                txtcantidad.Focus();
            }
        }
        private void Disminuir()
        {
            var funcion = new Dproductos();
            var parametros = new Lproductos();
            parametros.Id_Producto1 = Idproducto;
            parametros.Cantidad =Convert.ToDouble(txtcantidad.Text);
            if(funcion.disminuirStock(parametros)==true)
            {
                insertar_KARDEX_SALIDA();
            }
        }
        private void insertar_KARDEX_SALIDA()
        {
            LKardex parametros = new LKardex();
            Insertar_datos funcion = new Insertar_datos();
            parametros.Fecha = txtfecha.Value;
            parametros.Motivo = txtcmotivo.Text;
            parametros.Cantidad = Convert.ToDouble(txtcantidad.Text);
            parametros.Id_producto = Idproducto;
            if (funcion.insertar_KARDEX_SALIDA(parametros) == true)
            {
                txtbuscar.Text = "";
                txtbuscar.Focus();
                dgproductos.Visible = true;
                Buscar();
                MessageBox.Show("Registro realizado correctamente");

            }

        }
      
        private void DatalistadoProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            obtenerDatos();
        }
        private void obtenerDatos()
        {
            Idproducto = Convert.ToInt32(dgproductos.SelectedCells[0].Value);
            txtbuscar.Text = dgproductos.SelectedCells[1].Value.ToString();
            txtcantidad.Text = "";
            txtcmotivo.Text = "";          
            dgproductos.Visible = false;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
