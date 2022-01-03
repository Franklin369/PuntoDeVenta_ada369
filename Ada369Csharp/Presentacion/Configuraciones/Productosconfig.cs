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
using System.Management;
using Sunat.Logica;
using Ada369Csharp.Logica;
using Ada369Csharp.Datos;
using Ada369Csharp.CONEXION;

namespace Ada369Csharp.Presentacion.Configuraciones
{
    public partial class Productosconfig : UserControl
    {

        public Productosconfig()
        {
            InitializeComponent();
        }
        public static int idcaja;
        string codigoProdsunat = "";
        public static int idusuario;
        int lblIdGrupo;
        string usarInventarios;
        string stock;
        double stockminimo;
        string fechaVencimiento;
        string sevendea;
        string lblEstadoCodigo;
        string lblfechasvenci;
        int idproducto;
        string CodigoUdm;

        private void mostrarUnidadM()
        {
            var funcion = new DunidadM();
            var dt = new DataTable();
            funcion.mostrarUndm(ref dt);
            txtum.DisplayMember = "Descripcion";
            txtum.ValueMember = "Codigo";
            txtum.DataSource = dt;
        }
        private void PictureBox2_Click(object sender, EventArgs e)
        {
           
            Panelregistro.Dock = DockStyle.Fill;
            Panelregistro.Visible = true;
            CheckInventarios.Checked = true;
            panelInventario.Visible = true;
            dgGrupos.Visible = true;
            btnGuardar_grupo.Visible = false;
            BtnGuardarCambios.Visible = false;
            BtnCancelar.Visible = false;
            btnNuevoGrupo.Visible = true;
            mostrar_grupos();
            txtgrupo.Text = "";
            lblEstadoCodigo = "NUEVO";
            dgGrupos.Visible = true;
            btnGuardar_grupo.Visible = false;
            BtnGuardarCambios.Visible = false;
            BtnCancelar.Visible = false;
            btnNuevoGrupo.Visible = true;
            mostrar_grupos();

            txtapartirde.Text = "0";
            txtstock.ReadOnly = false;
            Panel25.Enabled = true;
            idproducto = 0;

            panelInventario.Visible = true;

            txtdescripcion.AutoCompleteCustomSource = CONEXION.DataHelper.LoadAutoComplete();
            txtdescripcion.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtdescripcion.AutoCompleteSource = AutoCompleteSource.CustomSource;

            Panelregistro.Visible = true;
            porunidad.Checked = true;
            No_aplica_fecha.Checked = false;
            Limpiar();
            txtdescripcion.Text = "";
            panelInventario.Visible = true;


            btnguardar.Visible = true;
            btnguardarCamb.Visible = false;



        }
        internal void Limpiar()
        {
            txtdescripcion.Text = "";
            txtcosto.Text = "0";
            txtPrecioventa.Text = "0";
            txtpreciomayoreo.Text = "0";
            txtgrupo.Text = "";

            agranel.Checked = false;
            txtstockminimo.Text = "0";
            txtstock.Text = "0";
            lblEstadoCodigo = "NUEVO";
        }

        private void Productos_ok_Load(object sender, EventArgs e)
        {

            Bases.Cambiar_idioma_regional();

            Panelregistro.Visible = false;
            txtbusca.Text = "Buscar...";
            sumar_costo_de_inventario_CONTAR_PRODUCTOS();
            buscar();
            mostrar_grupos();
            mostrarUnidadM();
            ObtenerIniciosesion();
            Obtener_datos.Obtener_id_caja_PorSerial(ref idcaja);

        }
        private void ObtenerIniciosesion()
        {
            var funcion = new DiniciosSesion();
            var dt = new DataTable();
            funcion.mostrarInicioSesionTable(ref dt);
            idusuario = Convert.ToInt32(dt.Rows[0][2]);
        }

        private void mostrar_grupos()
        {
            try
            {
                var dt = new DataTable();
                var funcion = new Dproductos();
                funcion.mostrargrupos(ref dt, txtgrupo.Text);
                dgGrupos.DataSource = dt;
                CONEXIONMAESTRA.cerrar();
                dgGrupos.DataSource = dt;
                dgGrupos.Columns[2].Visible = false;
                dgGrupos.Columns[3].Width = 500;
                dgGrupos.Visible = true;
                dgGrupos.Size = new Size(487, 190);
                dgGrupos.Location = new Point(txtgrupo.Location.X, txtgrupo.Location.Y + 30);
                dgGrupos.BringToFront();
                dgGrupos.BackgroundColor = Color.White;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Bases.Multilinea(ref datalistado);
        }

        private void btnGuardar_grupo_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("insertar_Grupo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Grupo", txtgrupo.Text);
                cmd.Parameters.AddWithValue("@Por_defecto", "NO");
                cmd.ExecuteNonQuery();
                con.Close();
                mostrar_grupos();

                lblIdGrupo = Convert.ToInt32(dgGrupos.SelectedCells[2].Value);
                txtgrupo.Text = dgGrupos.SelectedCells[3].Value.ToString();

                dgGrupos.Visible = false;
                btnGuardar_grupo.Visible = false;
                BtnGuardarCambios.Visible = false;
                BtnCancelar.Visible = false;
                btnNuevoGrupo.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnNuevoGrupo_Click(object sender, EventArgs e)
        {
            txtgrupo.Text = "Escribe el Nuevo GRUPO";
            txtgrupo.SelectAll();
            txtgrupo.Focus();
            btnGuardar_grupo.Visible = true;
            BtnGuardarCambios.Visible = false;
            BtnCancelar.Visible = true;
            btnNuevoGrupo.Visible = false;
        }

        private void txtgrupo_TextChanged(object sender, EventArgs e)
        {
            mostrar_grupos();
        }
        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            btnGuardar_grupo.Visible = false;
            BtnGuardarCambios.Visible = false;
            BtnCancelar.Visible = false;
            btnNuevoGrupo.Visible = true;
            txtgrupo.Clear();
            mostrar_grupos();

        }
        private void ValidarInventarios()
        {
            if (usarInventarios == "SI")
            {
                stock = txtstock.Text;
                stockminimo = Convert.ToDouble(txtstockminimo.Text);
            }
            else
            {
                stock = "Ilimitado";
                stockminimo = 0;
                txtstock.Text = "0";
            }
            if (No_aplica_fecha.Checked == true)
            {
                fechaVencimiento = "NO APLICA";
            }

            if (No_aplica_fecha.Checked == false)
            {
                fechaVencimiento = txtfechaoka.Text;
            }

        }
        private void ValidarSevendepor()
        {
            if (porunidad.Checked == true) sevendea = "Unidad";
            if (agranel.Checked == true) sevendea = "Granel";
        }
        private void ValidarNulos()
        {
            if (txtpreciomayoreo.Text == "0" | txtpreciomayoreo.Text == "") txtapartirde.Text = "0";

        }
        private void insertar_productos()
        {
            ValidarSevendepor();
            ValidarNulos();
            ValidarInventarios();
            var funcion = new Dproductos();
            var parametros = new Lproductos();
            parametros.Descripcion = txtdescripcion.Text;
            parametros.Id_grupo = lblIdGrupo;
            parametros.Usa_inventarios = usarInventarios;
            parametros.Stock = stock;
            parametros.Precio_de_compra = Convert.ToDouble(txtcosto.Text);
            parametros.Fecha_de_vencimiento = fechaVencimiento;
            parametros.Precio_de_venta = Convert.ToDouble(txtPrecioventa.Text);
            parametros.Codigo = txtcodigodebarras.Text;
            parametros.Se_vende_a = sevendea;
            parametros.Stock_minimo = stockminimo;
            parametros.Precio_mayoreo = Convert.ToDouble(txtpreciomayoreo.Text);
            parametros.A_partir_de = Convert.ToDouble(txtapartirde.Text);
            parametros.CodigoSunat = codigoProdsunat;
            parametros.CodUm = txtum.SelectedValue.ToString();
            parametros.Cantidad = Convert.ToDouble(txtstock.Text);
            if (funcion.InsertarProducto(parametros) == true)
            {
                Panelregistro.Visible = false;
                txtbusca.Text = txtdescripcion.Text;
                buscar();
            }
        }


        private void editar_productos()
        {
            try
            {
                ValidarSevendepor();
                ValidarNulos();
                ValidarInventarios();
                var funcion = new Dproductos();
                var parametros = new Lproductos();
                parametros.Id_Producto1 = idproducto;
                parametros.Descripcion = txtdescripcion.Text;
                parametros.Id_grupo = lblIdGrupo;
                parametros.Usa_inventarios = usarInventarios;
                parametros.Stock = stock;
                parametros.Precio_de_compra = Convert.ToDouble(txtcosto.Text);
                parametros.Fecha_de_vencimiento = fechaVencimiento;
                parametros.Precio_de_venta = Convert.ToDouble(txtPrecioventa.Text);
                parametros.Codigo = txtcodigodebarras.Text;
                parametros.Se_vende_a = sevendea;
                parametros.Stock_minimo = stockminimo;
                parametros.Precio_mayoreo = Convert.ToDouble(txtpreciomayoreo.Text);
                parametros.A_partir_de = Convert.ToDouble(txtapartirde.Text);
                parametros.CodigoSunat = codigoProdsunat;
                parametros.CodUm = txtum.SelectedValue.ToString();
                parametros.Cantidad = Convert.ToDouble(txtstock.Text);
                if (funcion.Editarproductos(parametros) == true)
                {
                    Panelregistro.Visible = false;
                    txtbusca.Text = txtdescripcion.Text;
                    buscar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void buscar()
        {
            var funcion = new Dproductos();
            var dt = new DataTable();
            funcion.buscarProductos(ref dt, txtbusca.Text);
            datalistado.DataSource = dt;
            datalistado.Columns[2].Visible = false;
            Bases.Multilinea(ref datalistado);
            sumar_costo_de_inventario_CONTAR_PRODUCTOS();
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
                lblcosto_inventario.Text = resultado + " " + importe;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);

                lblcosto_inventario.Text = resultado + " " + 0;
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
                lblcantidad_productos.Text = conteoresultado;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);

                conteoresultado = "";
                lblcantidad_productos.Text = "0";
            }

        }
        private void CheckInventarios_CheckedChanged(object sender, EventArgs e)
        {
            if (idproducto != 0 & Convert.ToDouble(txtstock.Text) > 0)
            {
                if (CheckInventarios.Checked == false)
                {
                    MessageBox.Show("Hay Aun En Stock, Dirijete al Modulo Inventarios para Ajustar el Inventario a cero", "Stock Existente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    panelInventario.Visible = true;
                    CheckInventarios.Checked = true;
                }
            }

            if (idproducto != 0 & Convert.ToDouble(txtstock.Text) == 0)
            {
                if (CheckInventarios.Checked == false)
                {
                    panelInventario.Visible = false;

                }
            }

            if (idproducto == 0)
            {
                if (CheckInventarios.Checked == false)
                {
                    panelInventario.Visible = false;

                }
            }

            if (CheckInventarios.Checked == true)
            {
                usarInventarios = "SI";
                panelInventario.Visible = true;
            }
            else
            {
                usarInventarios = "NO";
            }

        }



        private void datalistadoGrupos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.dgGrupos.Columns["EliminarG"].Index)
            {
                DialogResult result;
                result = MessageBox.Show("¿Realmente desea eliminar este Grupo?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    SqlCommand cmd;
                    try
                    {
                        foreach (DataGridViewRow row in dgGrupos.SelectedRows)
                        {

                            int onekey = Convert.ToInt32(row.Cells["Idline"].Value);

                            try
                            {

                                try
                                {

                                    SqlConnection con = new SqlConnection();
                                    con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                                    con.Open();
                                    cmd = new SqlCommand("eliminar_grupos", con);
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.AddWithValue("@id", onekey);
                                    cmd.ExecuteNonQuery();
                                    con.Close();

                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }

                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show(ex.Message);
                            }

                        }
                        txtgrupo.Text = "GENERAL";
                        mostrar_grupos();
                        lblIdGrupo = Convert.ToInt32(dgGrupos.SelectedCells[2].Value);
                        dgGrupos.Visible = true;
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            if (e.ColumnIndex == this.dgGrupos.Columns["EditarG"].Index)

            {
                lblIdGrupo = Convert.ToInt32(dgGrupos.SelectedCells[2].Value);
                txtgrupo.Text = dgGrupos.SelectedCells[3].Value.ToString();
                dgGrupos.Visible = false;
                btnGuardar_grupo.Visible = false;
                BtnGuardarCambios.Visible = true;
                BtnCancelar.Visible = true;
                btnNuevoGrupo.Visible = false;
            }
            if (e.ColumnIndex == this.dgGrupos.Columns["Grupo"].Index)
            {
                lblIdGrupo = Convert.ToInt32(dgGrupos.SelectedCells[2].Value.ToString());
                txtgrupo.Text = dgGrupos.SelectedCells[3].Value.ToString();
                dgGrupos.Visible = false;
                btnGuardar_grupo.Visible = false;
                BtnGuardarCambios.Visible = false;
                BtnCancelar.Visible = false;
                btnNuevoGrupo.Visible = true;
                if (lblEstadoCodigo == "NUEVO")
                {
                    GENERAR_CODIGO_DE_BARRAS_AUTOMATICO();
                }

            }


        }
        private void GENERAR_CODIGO_DE_BARRAS_AUTOMATICO()
        {
            double resultado;
            string queryMoneda;
            queryMoneda = "SELECT max(Id_Producto1)  FROM Producto1";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
            SqlCommand comMoneda = new SqlCommand(queryMoneda, con);
            try
            {
                con.Open();
                resultado = Convert.ToDouble(comMoneda.ExecuteScalar()) + 1;
                con.Close();
            }
            catch (Exception ex)
            {
                resultado = 1;
            }

            string Cadena = txtgrupo.Text;
            string[] Palabra;
            String espacio = " ";
            Palabra = Cadena.Split(Convert.ToChar(espacio));
            try
            {

                txtcodigodebarras.Text = resultado + Palabra[0].Substring(0, 2) + 369;
            }
            catch (Exception ex)
            {
            }
        }




        bool SECUENCIA = true;

        private void txtcosto_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            Bases.Separador_de_Numeros(txtcosto, e);

        }


        private void txtbusca_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }
        internal void Obtenerdatos()
        {
            try
            {

                idproducto = Convert.ToInt32(datalistado.SelectedCells[2].Value);
                var funcion = new Dproductos();
                var dt = new DataTable();
                var parametros = new Lproductos();
                parametros.Id_Producto1 = idproducto;
                funcion.mostrarProdXid(ref dt, parametros);
                foreach (DataRow data in dt.Rows)
                {
                    txtcodigodebarras.Text = data["Codigo"].ToString();
                    txtgrupo.Text = data["grupo"].ToString();
                    txtdescripcion.Text = data["Descripcion"].ToString();
                    lblIdGrupo = Convert.ToInt32(data["Id_grupo"].ToString());
                    txtcosto.Text = data["Precio_de_compra"].ToString();
                    txtpreciomayoreo.Text = data["Precio_mayoreo"].ToString();
                    sevendea = data["Se_vende_a"].ToString();
                    usarInventarios = data["Usa_inventarios"].ToString();
                    txtstockminimo.Text = data["Stock_minimo"].ToString();
                    lblfechasvenci = data["Fecha_de_vencimiento"].ToString();
                    txtstock.Text = data["Stock"].ToString();
                    txtPrecioventa.Text = data["Precio_de_venta"].ToString();
                    txtapartirde.Text = data["A_partir_de"].ToString();
                    CodigoUdm = data["CodUm"].ToString();
                    codigoProdsunat = data["CodigoSunat"].ToString();
                }
                btnguardar.Visible = false;
                btnguardarCamb.Visible = true;
                lblEstadoCodigo = "EDITAR";
                dgGrupos.Visible = false;
                BtnGuardarCambios.Visible = false;
                btnGuardar_grupo.Visible = false;
                BtnCancelar.Visible = false;
                btnNuevoGrupo.Visible = true;
                Panelregistro.Visible = true;
                Panelregistro.Dock = DockStyle.Fill;
                if (sevendea == "Unidad")
                {
                    porunidad.Checked = true;
                }
                if (sevendea == "Granel")
                {
                    agranel.Checked = true;
                }

                if (lblfechasvenci == "NO APLICA")
                {
                    No_aplica_fecha.Checked = true;
                }
                if (lblfechasvenci != "NO APLICA")
                {
                    No_aplica_fecha.Checked = false;
                }
                try
                {
                    double TotalVentaVariabledouble;
                    double precioventa = Convert.ToDouble(txtPrecioventa.Text);
                    double txtcostov = Convert.ToDouble(txtcosto.Text);
                    TotalVentaVariabledouble = ((precioventa - txtcostov) / (txtcostov)) * 100;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                if (usarInventarios == "SI")
                {

                    panelInventario.Visible = true;
                    panelInventario.Visible = true;
                    txtstock.ReadOnly = true;
                    CheckInventarios.Checked = true;

                }
                if (usarInventarios == "NO")
                {
                    CheckInventarios.Checked = false;
                    panelInventario.Visible = false;
                    panelInventario.Visible = false;
                    txtstock.ReadOnly = true;
                    txtstock.Text = "0";
                    txtstockminimo.Text = "0";
                    No_aplica_fecha.Checked = true;
                    txtstock.ReadOnly = false;
                }
                dgGrupos.Visible = false;
                dgcodigossunat.Visible = false;
                mostrarUdmXcod();
                mostrarCodigoSunatXcod();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void mostrarUdmXcod()
        {
            var funcion = new DunidadM();
            var parametros = new LunidadM();
            var dt = new DataTable();
            parametros.Codigo = CodigoUdm;
            funcion.mostrarUdmXcod(ref dt, parametros);
            txtum.Text = dt.Rows[0][2].ToString();
        }
        private void mostrarCodigoSunatXcod()
        {
            var funcion = new DcodigosProdsunat();
            var parametros = new LcodigosSunat();
            var dt = new DataTable();
            parametros.codigo = codigoProdsunat;
            funcion.mostrarCodSunatXCod(ref dt, parametros);
            txtcodigoSunat.Text = dt.Rows[0][1].ToString();
        }
        private void datalistado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.datalistado.Columns["Eliminar"].Index)
            {
                DialogResult result;
                result = MessageBox.Show("¿Realmente desea eliminar este Producto?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    idproducto = Convert.ToInt32(datalistado.SelectedCells[2].Value);
                    var funcion = new Dproductos();
                    var parametros = new Lproductos();
                    parametros.Id_Producto1 = idproducto;
                    funcion.EliminarProducto(parametros);
                    buscar();
                }
            }
            if (e.ColumnIndex == this.datalistado.Columns["Editar"].Index)
            {
                Obtenerdatos();
            }
        }

        private void txtstock2_MouseClick_1(object sender, MouseEventArgs e)
        {
            try
            {
                if (idproducto != 0)
                {
                    Tmensajes.SetToolTip(txtstock, "Para modificar el Stock Hazlo desde el Modulo de Inventarios");
                    Tmensajes.ToolTipTitle = "Accion denegada";
                    Tmensajes.ToolTipIcon = ToolTipIcon.Info;

                }
            }
            catch (Exception ex)
            {

            }
        }


        private void btnGenerarCodigo_Click_1(object sender, EventArgs e)
        {
            GENERAR_CODIGO_DE_BARRAS_AUTOMATICO();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Panelregistro.Visible = false;
        }
        private void txtPorcentajeGanancia_TextChanged_1(object sender, EventArgs e)
        {
            TimerCalucular_porcentaje_ganancia.Stop();

            TimerCalcular_precio_venta.Start();
            TimerCalucular_porcentaje_ganancia.Stop();
        }

        private void TimerCalucular_porcentaje_ganancia_Tick(object sender, EventArgs e)
        {
            TimerCalucular_porcentaje_ganancia.Stop();
            try
            {


                double TotalVentaVariabledouble;
                double TXTPRECIODEVENTA2V = Convert.ToDouble(txtPrecioventa.Text);
                double txtcostov = Convert.ToDouble(txtcosto.Text);

                TotalVentaVariabledouble = ((TXTPRECIODEVENTA2V - txtcostov) / (txtcostov)) * 100;


            }
            catch (Exception ex)
            {

            }
        }


        private void datalistado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Obtenerdatos();
        }

      

        
        private void TXTPRECIODEVENTA2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Bases.Separador_de_Numeros(txtPrecioventa, e);
        }

        private void txtpreciomayoreo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Bases.Separador_de_Numeros(txtpreciomayoreo, e);
        }

        private void txtapartirde_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Bases.Separador_de_Numeros(txtapartirde, e);
        }

        private void txtstock2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Bases.Separador_de_Numeros(txtstock, e);
        }

        private void txtstockminimo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Bases.Separador_de_Numeros(txtstockminimo, e);
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtcodigoSunat_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtcodigoSunat.Text))
            {
                BuscarcodProdSunat();
            }
            else
            {
                dgcodigossunat.Visible = false;
            }
        }
        private void BuscarcodProdSunat()
        {
            var funcion = new DcodigosProdsunat();
            var dt = new DataTable();
            funcion.buscarCodProdSunat(ref dt, txtcodigoSunat.Text);
            dgcodigossunat.DataSource = dt;
            dgcodigossunat.Visible = true;
            dgcodigossunat.Columns[1].Visible = false;
        }

        private void dgcodigossunat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codigoProdsunat = dgcodigossunat.SelectedCells[1].Value.ToString();
            txtcodigoSunat.Text = dgcodigossunat.SelectedCells[0].Value.ToString();
            dgcodigossunat.Visible = false;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            double txtpreciomayoreoV = Convert.ToDouble(txtpreciomayoreo.Text);

            double txtapartirdeV = Convert.ToDouble(txtapartirde.Text);
            double txtcostoV = Convert.ToDouble(txtcosto.Text);
            double precioventa = Convert.ToDouble(txtPrecioventa.Text);
            if (txtpreciomayoreo.Text == "") txtpreciomayoreo.Text = "0";
            if (txtapartirde.Text == "") txtapartirde.Text = "0";
            if ((txtpreciomayoreoV > 0 & Convert.ToDouble(txtapartirde.Text) > 0) | (txtpreciomayoreoV == 0 & txtapartirdeV == 0))
            {
                if (txtcostoV >= precioventa)
                {
                    if (!string.IsNullOrEmpty(codigoProdsunat))
                    {
                        DialogResult result;
                        result = MessageBox.Show("El precio de Venta es menor que el COSTO, Esto Te puede Generar Perdidas", "Producto con Perdidas", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (result == DialogResult.OK)
                        {
                            insertar_productos();
                        }
                        else
                        {
                            txtPrecioventa.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un codigo Sunat");
                    }
                }
                else if (txtcostoV < precioventa)
                {
                    insertar_productos();
                }
            }
            else if (txtpreciomayoreoV != 0 | txtapartirdeV != 0)
            {
                MessageBox.Show("Estas configurando Precio mayoreo, debes completar los campos de Precio mayoreo y A partir de, si no deseas configurarlo dejalos en blanco", "Datos incompletos", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
        private void btnguardarCamb_Click(object sender, EventArgs e)
        {
            double txtpreciomayoreoV = Convert.ToDouble(txtpreciomayoreo.Text);

            double txtapartirdeV = Convert.ToDouble(txtapartirde.Text);
            double txtcostoV = Convert.ToDouble(txtcosto.Text);
            double precioventa = Convert.ToDouble(txtPrecioventa.Text);
            if (txtpreciomayoreo.Text == "") txtpreciomayoreo.Text = "0";
            if (txtapartirde.Text == "") txtapartirde.Text = "0";
            if ((txtpreciomayoreoV > 0 & Convert.ToDouble(txtapartirde.Text) > 0) | (txtpreciomayoreoV == 0 & txtapartirdeV == 0))
            {
                if (txtcostoV >= precioventa)
                {

                    DialogResult result;
                    result = MessageBox.Show("El precio de Venta es menor que el COSTO, Esto Te puede Generar Perdidas", "Producto con Perdidas", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (result == DialogResult.OK)
                    {
                        editar_productos();
                    }
                    else
                    {
                        txtPrecioventa.Focus();
                    }


                }
                else if (txtcostoV < precioventa)
                {
                    editar_productos();
                }
            }
            else if (txtpreciomayoreoV != 0 | txtapartirdeV != 0)
            {
                MessageBox.Show("Estas configurando Precio mayoreo, debes completar los campos de Precio mayoreo y A partir de, si no deseas configurarlo dejalos en blanco", "Datos incompletos", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void txtbusca_Click(object sender, EventArgs e)
        {
            txtbusca.SelectAll();
        }
    }
}
