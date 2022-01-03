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
using Sunat.Logica;
namespace Ada369Csharp.Presentacion.INVENTARIOS_KARDEX
{
    public partial class KardexEntrada : UserControl
    {
        public KardexEntrada()
        {
            InitializeComponent();
        }
        int Idproducto;
        double CantidadActual;
        double PrecioVentaActual;
        double CostoActual;
        double PrecioMayoreoActual;
        double CostoNuevo;
        double cantidadAgregada;
        double costoAgregado;
        private void TXTBUSCARProducto_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }
        private void Buscar()
        {
            DataTable dt = new DataTable();
            var funcion = new Dkardex();
            funcion.BuscarprodInvent(ref dt, txtbuscar.Text);
            Bases.Multilinea(ref dgproductos);
            dgproductos.DataSource = dt;
            dgproductos.Columns[0].Visible = false;
            dgproductos.Visible = true;
            dgproductos.Size = new Size(578, 454);
            dgproductos.Location = new Point(txtbuscar.Location.X, txtbuscar.Location.Y + 35);
            dgproductos.BackgroundColor = Color.White;

        }

        private void DATALISTADO_MOTIVOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DatalistadoProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            obtenerDatos();
        }
        private void obtenerDatos()
        {
            Idproducto = Convert.ToInt32(dgproductos.SelectedCells[0].Value);
            txtbuscar.Text = dgproductos.SelectedCells[1].Value.ToString();
            var funcion = new Dproductos();
            var dt = new DataTable();
            var parametros = new Lproductos();
            parametros.Id_Producto1 = Idproducto;
            funcion.mostrarProdXid(ref dt, parametros);
            foreach (DataRow data in dt.Rows)
            {
                lblcantidadactual.Text = data["Stock"].ToString();
                CostoActual = Convert.ToDouble(data["Precio_de_compra"]);
                PrecioVentaActual = Convert.ToDouble(data["Precio_de_venta"]);
                PrecioMayoreoActual = Convert.ToDouble(data["Precio_mayoreo"]);
            }
            CantidadActual = Convert.ToDouble(lblcantidadactual.Text);
            txtcosto.Text = CostoActual.ToString();
            txtprecio_venta.Text = PrecioVentaActual.ToString();
            txtpreciomayoreo.Text = PrecioMayoreoActual.ToString();
            lblAnunciodeNuevosPrecios.Text = "";
            txtagregar.Text = "";
            txtcmotivo.Text = "";
            if (PrecioMayoreoActual == 0)
            {
                Label43.Visible = false;
                txtpreciomayoreo.Visible = false;
            }
            else
            {
                Label43.Visible = true;
                txtpreciomayoreo.Visible = true;
            }
           
            dgproductos.Visible = false;
        }

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            validaciones();
        }
        private void EditarPreciosProductos()
        {
            Lproductos parametros = new Lproductos();
            Editar_datos funcion = new Editar_datos();
            parametros.Id_Producto1 = Idproducto;
            parametros.Precio_de_venta = Convert.ToDouble(txtprecio_venta.Text);
            parametros.Precio_de_compra = CostoNuevo;
            parametros.Precio_mayoreo = Convert.ToDouble(txtpreciomayoreo.Text);
            parametros.Stock = txtagregar.Text;
            if (funcion.EditarPreciosProductos(parametros) == true)
            {
                insertar_KARDEX_Entrada();
            }
        }
        private void insertar_KARDEX_Entrada()
        {
            LKardex parametros = new LKardex();
            Insertar_datos funcion = new Insertar_datos();
            parametros.Fecha = txtfecha.Value;
            parametros.Motivo = txtcmotivo.Text;
            parametros.Cantidad = Convert.ToDouble(txtagregar.Text);
            parametros.Id_producto = Idproducto;
            if (funcion.insertar_KARDEX_Entrada(parametros) == true)
            {
                txtbuscar.Text = "";
                txtbuscar.Focus();
                dgproductos.Visible = true;
                MessageBox.Show("Registro realizado correctamente");
            }

        }
        private void validaciones()
        {
            if (!string.IsNullOrEmpty(txtagregar.Text))
            {
                if (!string.IsNullOrEmpty(txtcosto.Text))
                {
                    if (!string.IsNullOrEmpty(txtprecio_venta.Text))
                    {
                        if (!string.IsNullOrEmpty(txtpreciomayoreo.Text))
                        {
                            if (string.IsNullOrEmpty(txtcmotivo.Text))
                            {
                                txtcmotivo.Text = "SIN MOTIVO";
                            }
                            EditarPreciosProductos();
                        }
                        else
                        {
                            MessageBox.Show("El precio de venta al por mayor no puede estar vacio", "Valores vacios");
                            txtpreciomayoreo.Focus();
                        }

                    }
                    else
                    {
                        MessageBox.Show("El precio de venta no puede estar vacio", "Valores vacios");
                        txtprecio_venta.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("El Costo no puede estar vacio", "Valores vacios");
                    txtcosto.Focus();
                }

            }
            else
            {
                MessageBox.Show("El valor a agregar no puede estar vacio", "Valores vacios");
                txtagregar.Focus();
            }


        }

        private void txtagregar_TextChanged(object sender, EventArgs e)
        {
            calcular();
        }
        private void calcular()
        {
            if (!string.IsNullOrEmpty(txtagregar.Text))
            {
                if (!string.IsNullOrEmpty(txtcosto.Text))
                {
                    cantidadAgregada = Convert.ToDouble(txtagregar.Text);
                    costoAgregado = Convert.ToDouble(txtcosto.Text);
                    CostoNuevo = ((CostoActual * CantidadActual) + (costoAgregado * cantidadAgregada)) / (CantidadActual + cantidadAgregada);
                    lblAnunciodeNuevosPrecios.Text = "Se recibiran " + txtagregar.Text + " de stock, el nuevo costo sera de " + CostoNuevo.ToString();
                }


            }
        }

        private void txtcosto_TextChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void KardexEntrada_Load(object sender, EventArgs e)
        {
            lblAnunciodeNuevosPrecios.Text = "";
            Buscar();
        }

        private void txtagregar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bases.Separador_de_Numeros(txtagregar, e);
        }

        private void txtcosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bases.Separador_de_Numeros(txtcosto, e);

        }

        private void txtprecio_venta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bases.Separador_de_Numeros(txtprecio_venta, e);

        }

        private void txtpreciomayoreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bases.Separador_de_Numeros(txtpreciomayoreo, e);

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
