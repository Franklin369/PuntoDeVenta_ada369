using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ada369Csharp.Datos;
using Ada369Csharp.Logica;
using Sunat.Logica;
using Ada369Csharp.Presentacion.Configuraciones;

namespace Ada369Csharp.Presentacion.Compras
{
    public partial class RealizarCompra : UserControl
    {
        public RealizarCompra()
        {
            InitializeComponent();
        }
        string estadocompra;
        int idproducto;
        Panel panel_mostrador_de_productos = new Panel();
        string Tipo_de_busqueda;
        int idcompra = 0;
        int idproveedor;
        string sevendePor;
        double txtpantalla;
        int iddetallecompra;
        bool SECUENCIA = true;

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if(txtbuscar.Text =="")
            {
                ocultar_mostrar_productos();
            }
            else
            {
                mostrar_productos();
            }
            BuscarProductos();


        }
        private void BuscarProductos()
        {
            var dt = new DataTable();
            var funcion = new Dproductos();
            funcion.buscarProductos(ref dt, txtbuscar.Text);
            dgProductos.DataSource = dt;
            dgProductos.Columns[0].Visible = false;
            dgProductos.Columns[1].Visible = false;
            dgProductos.Columns[2].Width = 600;
            dgProductos.Columns[3].Visible = false;
            dgProductos.Columns[4].Visible = false;
            dgProductos.Columns[5].Visible = false;
            dgProductos.Columns[6].Visible = false;
            dgProductos.Columns[7].Visible = false;
            dgProductos.Columns[8].Visible = false;
            dgProductos.Columns[9].Visible = false;
            dgProductos.Columns[10].Visible = false;

        }

        private void mostrar_productos()
        {
            panel_mostrador_de_productos.Size = new Size(600, 186);
            panel_mostrador_de_productos.BackColor = Color.White;
            panel_mostrador_de_productos.Location = new Point(panelReferenciaProductos.Location.X, panelReferenciaProductos.Location.Y);
            panel_mostrador_de_productos.Visible = true;
            dgProductos.Visible = true;
            dgProductos.Dock = DockStyle.Fill;
            dgProductos.BackgroundColor = Color.White;
            lbltipodebusqueda2.Visible = false;
            panel_mostrador_de_productos.Controls.Add(dgProductos);
            this.Controls.Add(panel_mostrador_de_productos);
            panel_mostrador_de_productos.BringToFront();
        }
        private void ocultar_mostrar_productos()
        {
            panel_mostrador_de_productos.Visible = false;
            dgProductos.Visible = false;
            lbltipodebusqueda2.Visible = true;
        }

        private void RealizarCompra_Load(object sender, EventArgs e)
        {
            estadocompra = "COMPRA NUEVA";
            dibujarProveedores();
            eliminarComprasvacias();
        }
        private void dibujarProveedores()
        {
            var funcion = new Dproveedores();
            DataTable dt = new DataTable();
            funcion.buscar_Proveedores(ref dt, txtBuscarproveedores.Text);
            FlowpanelProveedor.Controls.Clear();
            foreach(DataRow rdr in dt.Rows)
            {
                Button b = new Button();
                b.Size = new Size(149, 65);
                b.Text = rdr["Nombre"].ToString();
                b.Name = rdr["IdProveedor"].ToString();
                b.BackColor = Color.FromArgb(43, 43, 43);
                b.Font = new Font("Microsoft Sans Serif", 12);
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.ForeColor = Color.White;
                FlowpanelProveedor.Controls.Add(b);
                b.Click += B_Click;
            }

        }

        private void B_Click(object sender, EventArgs e)
        {
            idproveedor = Convert.ToInt32(((Button)sender).Name);
            //Deseleccionar
            foreach (Button b in FlowpanelProveedor.Controls)
            {
                if(b is Button)
                {
                    b.BackColor = Color.FromArgb(43, 43, 43);
                }
            }
            //Seleccionar button
            foreach(Button b2 in FlowpanelProveedor.Controls)
            {
                if (b2 is Button)
                {
                    if(b2.Name ==idproveedor.ToString())
                    {
                        b2.BackColor = Color.FromArgb(81, 175, 73);
                    }
                }
            }

        }

        private void txtBuscarproveedores_TextChanged(object sender, EventArgs e)
        {
            dibujarProveedores();
        }

        private void dgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbuscar.Text = dgProductos.SelectedCells[9].Value.ToString();
            idproducto = Convert.ToInt32(dgProductos.SelectedCells[1].Value);
            panel_mostrador_de_productos.Visible = false;
            insertarCompra();
        }
        private void insertarCompra()
        {
            var funcion = new Dcompras();
            var parametros = new Ldetallecompra();
            parametros.Estado = estadocompra;
            parametros.Cantidad = 1;
            parametros.Costo = 1;
            parametros.Moneda = "-";
            parametros.Descripcion = txtbuscar.Text;
            parametros.IdProducto = idproducto;
            if(funcion.Insertar_Compras(parametros)==true)
            {
                estadocompra = "COMPRA GENERADA";
                mostrarUltimoIdcompra();
                mostrarDetallecompra();
            }


        }
        private void eliminarComprasvacias()
        {
            var funcion = new Dcompras();
            funcion.eliminarComprasvacias();

        }
        private void mostrarUltimoIdcompra()
        {
            var funcion = new Dcompras();
            funcion.MostrarUltimoIdcompra(ref idcompra);
        }
        private void mostrarDetallecompra()
        {
            var dt = new DataTable();
            var funcion = new Ddetallecompra();
            var parametros = new Ldetallecompra();
            parametros.IdCompra = idcompra;
            funcion.mostrar_DetalleCompra(ref dt, parametros);
            dgDetallecompra.DataSource = dt;
            dgDetallecompra.Columns[1].Visible = false;
            dgDetallecompra.Columns[2].Visible = false;
            dgDetallecompra.Columns[3].Visible = false;
            dgDetallecompra.Columns[8].Visible = false;
            dgDetallecompra.Columns[9].Visible = false;
            Bases.Multilinea(ref dgDetallecompra);
            sumar();


        }
        private void sumar()
        {
            try
            {
                int x;
                x = dgDetallecompra.Rows.Count;
                if (x == 0)
                {
                    txt_total_suma.Text = "0.00";
                }
                double totalpagar;
                totalpagar = 0;
                foreach (DataGridViewRow fila in dgDetallecompra.Rows)
                {
                    totalpagar += Convert.ToDouble( fila.Cells["Total"].Value);
                    txt_total_suma.Text = totalpagar.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void dgDetallecompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            iddetallecompra = Convert.ToInt32(dgDetallecompra.SelectedCells[1].Value);
            idproducto = Convert.ToInt32(dgDetallecompra.SelectedCells[3].Value);
            sevendePor = (dgDetallecompra.SelectedCells[8].Value.ToString());
            if (e.ColumnIndex == dgDetallecompra.Columns["EL"].Index)
            {
                eliminar_detalle_compra();
            }

        }
        private void eliminar_detalle_compra()
        {
            var funcion = new Ddetallecompra();
            var parametros = new Ldetallecompra();
            parametros.IdDetallecompra = iddetallecompra;
            funcion.eliminar_detalle_compra(parametros);
            mostrarDetallecompra();

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtmonto.Text = txtmonto.Text + "1";

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtmonto.Text = txtmonto.Text + "2";

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtmonto.Text = txtmonto.Text + "3";

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtmonto.Text = txtmonto.Text + "4";

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtmonto.Text = txtmonto.Text + "5";

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtmonto.Text = txtmonto.Text + "6";

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtmonto.Text = txtmonto.Text + "7";

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtmonto.Text = txtmonto.Text + "8";

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtmonto.Text = txtmonto.Text + "9";

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtmonto.Text = txtmonto.Text + "0";

        }

        private void btnborrartodo_Click(object sender, EventArgs e)
        {
            txtmonto.Clear();
            SECUENCIA = true;
        }

        private void btnSeparador_Click(object sender, EventArgs e)
        {
            if (SECUENCIA == true)
            {
                txtmonto.Text = txtmonto.Text + ".";
                SECUENCIA = false;
                

            }
            else
            {
                return;
            }


        }

        private void txtmonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bases.Separador_de_Numeros(txtmonto, e);
        }

        private void btncantidad_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtmonto.Text))
            {
                if (dgDetallecompra.RowCount > 0)
                {
                    if (sevendePor == "Unidad")
                    {
                        string cadena = txtmonto.Text;
                        if (cadena.Contains("."))
                        {
                            MessageBox.Show("Este Producto no acepta decimales ya que esta configurado para ser vendido por UNIDAD", "Formato Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                        else
                        {
                            BotonCantidad();
                        }


                    }
                    else
                    {
                        BotonCantidad();
                    }

                }
                else
                {
                    txtmonto.Clear();
                    txtmonto.Focus();
                }

            }
        }
        private void BotonCantidad()
        {
            txtpantalla = Convert.ToDouble(txtmonto.Text);
            double Cantidad;
            Cantidad = Convert.ToDouble(dgDetallecompra.SelectedCells[5].Value);
            string ControlStock;
            ControlStock = dgDetallecompra.SelectedCells[9].Value.ToString();
            if (ControlStock == "SI")
            {
                editar_detalle_compra_Cantidad();
                txtmonto.Clear();
            }

        }
        private void editar_detalle_compra_Cantidad()
        {
            var funcion = new Ddetallecompra();
            var parametros = new Ldetallecompra();
            parametros.IdCompra = idcompra;
            parametros.IdProducto = idproducto;
            parametros.Cantidad = txtpantalla;
            funcion.editar_detalle_compra_Cantidad(parametros);
            mostrarDetallecompra();

        }

        private void btnprecio_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtmonto.Text))
            {
                editar_detalle_compra_Precio();
            }
            else
            {
                txtmonto.Clear();
                txtmonto.Focus();
            }
        }
        private void editar_detalle_compra_Precio()
        {
            txtpantalla = Convert.ToDouble(txtmonto.Text);
            var funcion = new Ddetallecompra();
            var parametros = new Ldetallecompra();
            parametros.IdCompra = idcompra;
            parametros.IdProducto = idproducto;
            parametros.Costo = txtpantalla;
            funcion.editar_detalle_compra_Precio(parametros);
            mostrarDetallecompra();
            txtmonto.Clear();



        }

        private void btnagregarPro_Click(object sender, EventArgs e)
        {
            //var frm = new Proveedores();
            //frm.FormClosed += Frm_FormClosed;
            //frm.ShowDialog();
        }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            dibujarProveedores();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            confirmarCompra();
        }
        private void confirmarCompra()
        {
            var funcion = new Dcompras();
            var parametros = new Lcompras();
            parametros.Idcompra = idcompra;
            parametros.Total = Convert.ToDouble(txt_total_suma.Text);
            parametros.IdProveedor = idproveedor;
            if(funcion.confirmarCompra(parametros)==true)
            {
                insertarKardex();
                insertarStock();
                MessageBox.Show("Compra realizada correctamente");
                Limpiar();
            }

        }
        private void Limpiar()
        {
            txtmonto.Clear();
            txtbuscar.Clear();
            idcompra = 0;
            mostrarDetallecompra();
            estadocompra = "COMPRA NUEVA";
        }
        private void insertarKardex()
        {
            var parametros = new LKardex();
            var funcion = new Dkardex();
            parametros.Fecha = DateTime.Now;
            parametros.Motivo = "COMPRAS";
            foreach (DataGridViewRow rdr in dgDetallecompra.Rows)
            {
                double cantidad = Convert.ToDouble(rdr.Cells["Cantidad"].Value);
                int idproducto = Convert.ToInt32(rdr.Cells["Id_Producto1"].Value);
                parametros.Cantidad = cantidad;
                parametros.Id_producto = idproducto;
                funcion.insertar_KARDEX_Entrada(parametros);

            }

        }
        private void insertarStock()
        {
            var parametros = new Lproductos();
            var funcion = new Dproductos();
            foreach (DataGridViewRow rdr in dgDetallecompra.Rows)
            {
                double cantidad = Convert.ToDouble(rdr.Cells["Cantidad"].Value);
                int idproducto = Convert.ToInt32(rdr.Cells["Id_Producto1"].Value);
                parametros.Stock = cantidad.ToString();
                parametros.Id_Producto1 = idproducto;
                funcion.aumentarStock(parametros);

            }

        }

        private void txtbuscar_Click(object sender, EventArgs e)
        {
            txtbuscar.SelectAll();
        }
    }
}
