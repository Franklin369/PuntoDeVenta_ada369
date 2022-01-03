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
using Ada369Csharp.Presentacion.Ventas;

namespace Ada369Csharp.Presentacion.Configuraciones
{
    public partial class Proveedoresconfig : UserControl
    {
        public Proveedoresconfig()
        {
            InitializeComponent();
        }
        int idproveedor;
        string estado;
        //Crud--------
        private void insertar()
        {
            Lproveedores parametros = new Lproveedores();
            Insertar_datos funcion = new Insertar_datos();
            parametros.Nombre = txtnombre.Text;
            parametros.IdentificadorFiscal = txtIdentificador.Text;
            parametros.Celular = txtcelular.Text;
            parametros.Direccion = txtdireccion.Text;
            if (funcion.insertar_Proveedores(parametros) == true)
            {
                mostrar();
            }

        }
        private void mostrar()
        {
            DataTable dt = new DataTable();
            Obtener_datos.mostrar_Proveedores(ref dt);
            datalistado.DataSource = dt;
            Panelregistro.Visible = false;
            pintarDatalistado();
        }
        private void editar()
        {
            Lproveedores parametros = new Lproveedores();
            Editar_datos funcion = new Editar_datos();
            parametros.IdProveedor = idproveedor;
            parametros.Nombre = txtnombre.Text;
            parametros.IdentificadorFiscal = txtIdentificador.Text;
            parametros.Celular = txtcelular.Text;
            parametros.Direccion = txtdireccion.Text;
            if (funcion.editar_Proveedores (parametros)==true )
            {
                mostrar();
            }
        }
        private void eliminar()
        {
            try
            {
                Lproveedores parametros = new Lproveedores();
                Eliminar_datos funcion = new Eliminar_datos();
                parametros.IdProveedor = idproveedor;
                if (funcion.eliminar_Proveedores(parametros) == true)
                {
                    mostrar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }
        private void restaurar()
        {
            Lproveedores parametros = new Lproveedores();
            Editar_datos funcion = new Editar_datos();
            parametros.IdProveedor = idproveedor;
            if (funcion.restaurar_Proveedores(parametros) == true)
            {
                mostrar();
            }

        }
        private void buscar()
        {
            DataTable dt = new DataTable();
            Obtener_datos.buscar_Proveedores(ref dt, txtbusca.Text);
            datalistado.DataSource = dt;
            pintarDatalistado();
        }
        //------------
        private void pintarDatalistado()
        {
            Bases.Multilinea(ref datalistado);
            datalistado.Columns[2].Visible = false;
            foreach (DataGridViewRow row in datalistado.Rows)
            {
                string estado = Convert.ToString(row.Cells["Estado"].Value);
                if (estado =="ELIMINADO")
                {
                    row.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Strikeout | FontStyle.Bold);
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }

            }
        }
        private void pNuevo_Click(object sender, EventArgs e)
        {
          
            Nuevo();
        }
       private void Nuevo()
        {
            Panelregistro.Visible = true;
            limpiar();
            btnGuardar.Visible = true;
            btnGuardarCambios.Visible = false;
            txtnombre.Focus();
            Panelregistro.Dock = DockStyle.Fill;
        }
        private void limpiar()
        {
            txtnombre.Clear();
            txtcelular.Clear();
            txtdireccion.Clear();
            txtIdentificador.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtnombre.Text))
            {
                rellenarCamposVacios();
                insertar();
            }
            else
            {
                MessageBox.Show("Ingrese un nombre", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
      
        private void rellenarCamposVacios()
        {
            if (string.IsNullOrEmpty(txtcelular.Text )) { txtcelular.Text = "-"; };
            if (string.IsNullOrEmpty(txtdireccion.Text)) { txtdireccion.Text = "-"; };
            if (string.IsNullOrEmpty(txtIdentificador.Text)) { txtIdentificador.Text = "-"; };

        }

        private void datalistado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex ==datalistado.Columns["Editar"].Index )
            {
                obtenerDatos();
            }
            if (e.ColumnIndex == datalistado.Columns["Eliminar"].Index)
            {
                obtenerId_estado();
                if (estado == "ACTIVO")
                {
                    DialogResult result = MessageBox.Show("¿Realmente desea eliminar este Registro?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == System.Windows.Forms.DialogResult.OK)
                    {
                        eliminar();
                    }
                }
            }
        }

        private void obtenerId_estado()
        {
            try
            {
                idproveedor = Convert.ToInt32(datalistado.SelectedCells[2].Value);
                estado = datalistado.SelectedCells[7].Value.ToString();

            }
            catch (Exception)
            {

            }
        }
        private void obtenerDatos()
        {
            try
            {
                idproveedor = Convert.ToInt32 ( datalistado.SelectedCells[2].Value);
                txtnombre.Text = datalistado.SelectedCells[3].Value.ToString();
                txtdireccion.Text = datalistado.SelectedCells[4].Value.ToString();
                txtIdentificador.Text = datalistado.SelectedCells[5].Value.ToString();
                txtcelular.Text = datalistado.SelectedCells[6].Value.ToString();
                estado= datalistado.SelectedCells[7].Value.ToString();
                if (estado =="ELIMINADO")
                {
                    DialogResult result = MessageBox.Show("Este Proveedor se Elimino. ¿Desea Volver a Habilitarlo?", "Restaurando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == System.Windows.Forms.DialogResult.OK)
                    {
                        restaurar();
                        prepararEdicion();
                    }
                      
                }
                else
                {
                    prepararEdicion();
                }
            }
            catch (Exception)
            {
            
            }
        }
      
        private void prepararEdicion()
        {
            Panelregistro.Visible = true;
            Panelregistro.Dock = DockStyle.Fill;
            btnGuardar.Visible = false;
            btnGuardarCambios.Visible = true;
        }
        private void Proveedoresconfig_Load(object sender, EventArgs e)
        {
            mostrar();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Panelregistro.Visible = false;
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtnombre.Text))
            {
                rellenarCamposVacios();
                editar();
            }
            else
            {
                MessageBox.Show("Ingrese un nombre", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void txtbusca_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
