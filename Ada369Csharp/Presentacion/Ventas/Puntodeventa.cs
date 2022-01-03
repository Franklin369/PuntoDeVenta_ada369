using Ada369Csharp.Datos;
using Ada369Csharp.Logica;
using Sunat.Logica;
using Ada369Csharp.Presentacion.CAJA;
using Ada369Csharp.Presentacion.Configuraciones;
using Ada369Csharp.Presentacion.Gastos_varios;
using Ada369Csharp.Presentacion.HistorialVentas;
using Ada369Csharp.Presentacion.Ingresos_varios;
using Ada369Csharp.Presentacion.Menu;
using Ada369Csharp.Presentacion.REPORTES.Impresion_de_comprobantes;
using Ada369Csharp.Sunat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.Reporting.Processing;

namespace Ada369Csharp.Presentacion.Ventas
{
    public partial class Puntodeventa : UserControl
    {
        public Puntodeventa()
        {
            InitializeComponent();
        }
        System.Windows.Forms.Panel panelProductos = new System.Windows.Forms.Panel();
        int idproducto;
        string sevendePor;
        string ventagenerada = "NUEVA";
        int idventa;
        decimal cantidad;
        string Tipobusqueda;
        decimal total;
        decimal vuelto = 0;
        decimal efectivo_calculado = 0;
        decimal restante = 0;
        decimal credito = 0;
        string Tipopago;
        int idcliente = 0;
        string Comprobante = "-";
        int idcomprobante;
        string conexionsunat;
        string moneda;
        int iddettallev;
        string Impresora;
        string Totalletras;
        string Envioinmediato;
        private void btncerrar_Click(object sender, EventArgs e)
        {
            Dispose();

        }
        private void eliminarVentasimcompletas()
        {
            var funcion = new Dventas();
            funcion.eliminarVentasIncomp();

        }
        private void Puntodeventa_Load(object sender, EventArgs e)
        {
            eliminarVentasimcompletas();
            ValidarTiposBusqueda();
            ObtenerComprobanteDefecto();
            ValidarAperturacaja();
        }
        private void ValidarAperturacaja()
        {
            string resultado = null;
            var funcion = new Dmovicaja();
            funcion.MostrarCierresdeCaja(ref resultado);
            if (resultado == "Nuevo*****")
            {
                aperturaCaja();
            }
        }
        private void aperturaCaja()
        {
            var ctl = new APERTURA_DE_CAJA();
            ctl.Size = new Size(Width, Height + Height / 2);
            this.Controls.Add(ctl);
            ctl.BringToFront();
        }
        private void ObtenerComprobanteDefecto()
        {
            var funcion = new Dserializacion();
            var dt = new DataTable();
            funcion.ObtenerComprobanteDefecto(ref dt);
            Comprobante = dt.Rows[0][0].ToString();
            lblComprobante.Text = Comprobante;
            idcomprobante = Convert.ToInt32(dt.Rows[0][1]);
            Envioinmediato = dt.Rows[0][2].ToString();
            dibujarComprobantes();
            validarPedidodeCliente();
        }
        private void dibujarComprobantes()
        {
            Panelcomrpobantes.Controls.Clear();
            try
            {
                var funcion = new Dserializacion();
                var dt = new DataTable();
                funcion.mostrarSerializacion(ref dt);

                foreach (DataRow rdr in dt.Rows)
                {
                    Button b = new Button();
                    b.Text = rdr["tipodoc"].ToString();
                    b.Name = rdr["Id_serializacion"].ToString();
                    b.Tag = rdr["Envioinmediato"].ToString();
                    b.Size = new System.Drawing.Size(150, 60);
                    b.BackColor = Color.FromArgb(70, 70, 71);
                    b.Font = new Font("Segoe UI", 12);
                    b.FlatStyle = FlatStyle.Flat;
                    b.ForeColor = Color.WhiteSmoke;
                    Panelcomrpobantes.Controls.Add(b);
                    if (b.Text == Comprobante)
                    {
                        b.Visible = false;
                    }
                    b.Click += miEvento;
                }
                CONEXION.CONEXIONMAESTRA.cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void miEvento(object sender, EventArgs e)
        {
            idcomprobante = Convert.ToInt32(((Button)sender).Name);
            Envioinmediato = Convert.ToString(((Button)sender).Tag);
            Comprobante = ((Button)sender).Text;
            lblComprobante.Text = Comprobante;
            dibujarComprobantes();
            identificarTipopago();
            validarPedidodeCliente();

        }
        private void validarPedidodeCliente()
        {


            if (Comprobante == "FACTURA" && Tipopago == "CREDITO")
            {
                panelClienteFactura.Visible = false;
            }
            if (Comprobante == "FACTURA" && Tipopago == "EFECTIVO")
            {
                panelClienteFactura.Visible = true;
                lblCliente.Text = "Cliente: (Obligatorio)";
                lblCliente.ForeColor = Color.Crimson;

            }
            else if (Comprobante != "FACTURA" && Tipopago == "EFECTIVO")
            {
                panelClienteFactura.Visible = true;
                lblCliente.Text = "Cliente: (Opcional)";
                lblCliente.ForeColor = Color.DimGray;

            }

            if (Comprobante == "FACTURA")
            {
                panelClienteFactura.Visible = true;
                lblCliente.Text = "Cliente: (Obligatorio)";
                lblCliente.ForeColor = Color.Crimson;

            }
            else if (Comprobante != "FACTURA" && Tipopago == "TARJETA")
            {
                panelClienteFactura.Visible = true;
                lblCliente.Text = "Cliente: (Opcional)";
                lblCliente.ForeColor = Color.DimGray;
            }
            else if (Comprobante != "FACTURA" && Tipopago != "CREDITO")
            {
                panelClienteFactura.Visible = true;
                lblCliente.Text = "Cliente: (Opcional)";
                lblCliente.ForeColor = Color.DimGray;
            }


        }
        private void ValidarTiposBusqueda()
        {
            var funcion = new Dempresa();
            var dt = new DataTable();
            funcion.mostrarTipobusqueda(ref dt);
            Tipobusqueda = dt.Rows[0][0].ToString();
            conexionsunat = dt.Rows[0][1].ToString();
            moneda = dt.Rows[0][2].ToString();
            if (Tipobusqueda == "TECLADO")
            {
                btnlectora.BackColor = Color.WhiteSmoke;
                btnteclado.BackColor = Color.LightGreen;
                txtbuscar.Clear();
                txtbuscar.Focus();
            }
            else
            {
                btnlectora.BackColor = Color.LightGreen;
                btnteclado.BackColor = Color.WhiteSmoke;
                txtbuscar.Focus();
                txtbuscar.Clear();

            }
        }
        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            Validarbusquedas();
        }
        private void Validarbusquedas()
        {
            if (txtbuscar.Text == "")
            {
                ocultarPanelprod();
            }
            else if (txtbuscar.Text != "")
            {
                mostrarPanelprod();
            }
        }
        private void mostrarPanelprod()
        {
            Buscarproductos();
            panelProductos.Size = new System.Drawing.Size(600, 186);
            panelProductos.BackColor = Color.White;
            panelProductos.Location = new Point(txtbuscar.Location.X, txtbuscar.Location.Y + 22);
            panelProductos.Visible = true;
            dgProductos.Visible = true;
            dgProductos.Dock = DockStyle.Fill;
            dgProductos.BackgroundColor = Color.White;
            panelProductos.Controls.Add(dgProductos);
            this.Controls.Add(panelProductos);
            panelProductos.BringToFront();
        }
        private void ocultarPanelprod()
        {
            panelProductos.Visible = false;
            dgProductos.Visible = false;
        }
        private void Buscarproductos()
        {
            var dt = new DataTable();
            var funcion = new Dproductos();
            funcion.buscarProductos(ref dt, txtbuscar.Text);
            dgProductos.DataSource = dt;
            dgProductos.Columns[0].Visible = false;
            dgProductos.Columns[2].Visible = false;
            dgProductos.Columns[4].Visible = false;
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bases.Separador_de_Numeros(txtcantidad, e);
        }

        private void dgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idproducto = Convert.ToInt32(dgProductos.SelectedCells[0].Value);
            txtbuscar.Clear();
            dgProductos.Visible = false;
            InsertarVenta();
        }
        private void validarCantidad()
        {
            if (string.IsNullOrEmpty(txtcantidad.Text)) { txtcantidad.Text = "1"; }
            cantidad = Convert.ToDecimal(txtcantidad.Text);
        }
        private void InsertarVenta()
        {
            validarCantidad();
            if (ventagenerada == "NUEVA")
            {
                var funcion = new Dventas();
                funcion.insertarVenta(ref idventa);
                ventagenerada = "GENERADA";
                panelBienvenida.Visible = false;
                PanelTotales.Visible = true;
            }
            if (ventagenerada == "GENERADA")
            {
                InsertarDv();
            }
        }
        private void InsertarDv()
        {
            var funcion = new Ddetalleventas();
            var parametros = new LdetalleVenta();
            parametros.idventa = idventa;
            parametros.Id_producto = idproducto;
            parametros.cantidad = cantidad;
            funcion.insertarDetalleVenta(parametros);
            mostrarDv();
            txtcantidad.Text = "1";
        }
        private void mostrarDv()
        {
            var funcion = new Ddetalleventas();
            var dt = new DataTable();
            var parametros = new LdetalleVenta();
            parametros.idventa = idventa;
            funcion.MostrarDetalleVenta(ref dt, parametros);
            dgDetalleventa.DataSource = dt;
            Bases.Multilinea(ref dgDetalleventa);
            dgDetalleventa.Columns[8].Visible = false;
            dgDetalleventa.Columns[9].Visible = false;
            dgDetalleventa.Columns[10].Visible = false;
            dgDetalleventa.Columns[11].Visible = false;
            dgDetalleventa.Columns[12].Visible = false;
            dgDetalleventa.Columns[13].Visible = false;
            dgDetalleventa.Columns[14].Visible = false;
            dgDetalleventa.Columns[15].Visible = false;
            dgDetalleventa.Columns[16].Visible = false;

            sumar();
        }
        private void sumar()
        {
            try
            {
                decimal totalInterno = 0;
                foreach (DataGridViewRow fila in dgDetalleventa.Rows)
                {
                    totalInterno += Convert.ToDecimal(fila.Cells["Importe"].Value);
                    lbltotal.Text = moneda + " " + Convert.ToString(totalInterno);
                    total = totalInterno;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void btnlectora_Click(object sender, EventArgs e)
        {
            ModoLectora();
        }
        public void ModoLectora()
        {
            ocultarPanelprod();
            Tipobusqueda = "LECTORA";
            btnlectora.BackColor = Color.LightGreen;
            btnteclado.BackColor = Color.WhiteSmoke;
            txtbuscar.Clear();
            txtbuscar.Focus();
        }
        private void Modoteclado()
        {
            ocultarPanelprod();
            Tipobusqueda = "TECLADO";
            btnteclado.BackColor = Color.LightGreen;
            btnlectora.BackColor = Color.WhiteSmoke;
            txtbuscar.Clear();
            txtbuscar.Focus();
        }

        private void btnteclado_Click(object sender, EventArgs e)
        {
            Modoteclado();
        }
        private void btncobrar_Click(object sender, EventArgs e)
        {
            Cobrar();
        }
        private void Cobrar()
        {
            panelCobro.Location = new Point((Width - panelCobro.Width) / 2, (Height - panelCobro.Height) / 2);
            panelCobro.Visible = true;
            PanelTotales.Visible = false;
            PanelC1.Visible = false;
            dgDetalleventa.Visible = false;
            PanelOperaciones.Visible = false;
            lblTotalref.Text = lbltotal.Text;
            txtefectivo.Text = total.ToString();
            txttarjeta.Clear();
            txtcredito.Clear();
            txtreferencia.Clear();
            lblvuelto.Text = "0";
            idcliente = 0;
            ObtenerComprobanteDefecto();
        }
        private void btnCerrrar_Click(object sender, EventArgs e)
        {
            panelCobro.Visible = false;
            PanelTotales.Visible = true;
            PanelC1.Visible = true;
            dgDetalleventa.Visible = true;
            PanelOperaciones.Visible = true;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Procesar();
        }
        private void Procesar()
        {
            if (restante == 0)
            {
                identificarTipopago();
                Validartexbox();
                validarTipopago();
            }
            else
            {
                MessageBox.Show("El restante debe ser 0", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void validarTipopago()
        {
            int contadorreferencia = 0;
            contadorreferencia = txtreferencia.Text.Length;
            if ((Tipopago == "TARJETA" || Tipopago == "MIXTO") && txtreferencia.Text == "")
            {
                MessageBox.Show("Ingrese los ultimos 4 digitos de la tarjeta");
            }
            else if ((Tipopago == "TARJETA" || Tipopago == "MIXTO") && contadorreferencia < 4)
            {
                MessageBox.Show("Ingrese los ultimos 4 digitos de la tarjeta");
            }
            else if ((Tipopago == "TARJETA" || Tipopago == "MIXTO") && contadorreferencia > 4)
            {
                MessageBox.Show("Ingrese los ultimos 4 digitos de la tarjeta");
            }
            else
            {
                if (Tipopago == "EFECTIVO" && vuelto >= 0)
                {
                    Procesarventa();
                }
                else if (Tipopago == "EFECTIVO" && vuelto < 0)
                {
                    MessageBox.Show("El vuelto no puede ser menor a el Total pagado ", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (Tipopago == "TARJETA")
                {
                    Procesarventa();
                }


                if (Tipopago == "MIXTO")
                {
                    Procesarventa();
                }
            }
        }

        private void ValidarClienteStandar()
        {
            if (idcliente == 0)
            {
                MostrarclienteStandar();
            }
        }
        void MostrarclienteStandar()
        {
            var funcion = new Dclientes();
            funcion.mostrarClienteStandar(ref idcliente);
        }
        private void Procesarventa()
        {

            if (Comprobante == "FACTURA" && idcliente == 0 && Tipopago != "CREDITO")
            {
                MessageBox.Show("Seleccione un Cliente, para Facturas es Obligatorio", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (Comprobante == "FACTURA" && idcliente != 0)
            {
                Terminarventa();
            }

            else if (Comprobante != "FACTURA" && Tipopago != "CREDITO")
            {
                ValidarClienteStandar();
                Terminarventa();
            }
            else if (Comprobante != "FACTURA" && Tipopago == "CREDITO")
            {
                if (idcliente == 0)
                {
                    Terminarventa();
                }
                else
                {
                    MessageBox.Show("Seleccione un Cliente", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }


        }
        void Terminarventa()
        {
            confirmarVenta();
            if (conexionsunat == "SI" && Comprobante != "TICKET")
            {
                if (Envioinmediato == "SI")
                {
                    EmitirFacturaContado();
                }

            }
            imprimir_directo();
            Ventanueva();

        }

        void convertirTotalaletras()
        {
            try
            {
                int numero = Convert.ToInt32(Math.Floor(Convert.ToDecimal(total)));
                var totalString = CONEXION.total_en_letras.Num2Text(numero);
                string[] a = total.ToString().Split('.');
                string txttotaldecimal;
                txttotaldecimal = a[1];
                Totalletras = totalString + " CON " + txttotaldecimal + "/100 ";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }

        }
        private void MostrarImpresora()
        {
            var funcion = new Dcaja();
            var dt = new DataTable();
            funcion.MostrarImprTicket(ref dt);
            Impresora = dt.Rows[0][0].ToString();
        }
        private void MostrarTicket()
        {
            var dt = new DataTable();
            var funcion = new Dticket();
            var parametros = new Lticket();
            parametros.Idventa = idventa;
            parametros.Totalletras = Totalletras;
            funcion.mostrarTicket(ref dt, parametros);
            var rpt = new Ticket_report();
            rpt.table1.DataSource = dt;
            rpt.DataSource = dt;
            reportViewer1.Report = rpt;
            reportViewer1.RefreshReport();
        }
        private void imprimir_directo()
        {
            MostrarTicket();
            MostrarImpresora();
            try
            {
                var DOCUMENTO = new PrintDocument();
                DOCUMENTO.PrinterSettings.PrinterName = Impresora;
                if (DOCUMENTO.PrinterSettings.IsValid)
                {
                    PrinterSettings printerSettings = new PrinterSettings();
                    printerSettings.PrinterName = Impresora;
                    ReportProcessor reportProcessor = new ReportProcessor();
                    reportProcessor.PrintReport(reportViewer1.ReportSource, printerSettings);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
        private void Ventanueva()
        {
            panelCobro.Visible = false;
            txtbuscar.Clear();
            idventa = 0;
            ventagenerada = "NUEVA";
            PanelTotales.Visible = true;
            PanelC1.Visible = true;
            dgDetalleventa.Visible = true;
            PanelOperaciones.Visible = true;
            lbltotal.Text = "0";
            txtbuscarcliente.Clear();

            mostrarDv();
        }
        private void EmitirFacturaContado()
        {
            var parametrosVentas = new Lventas();
            var funcionVentas = new Dventas();
            var dtventas = new DataTable();
            parametrosVentas.idventa = idventa;
            funcionVentas.mostrarVentasXidventa(ref dtventas, parametrosVentas);

            foreach (DataRow dataventas in dtventas.Rows)
            {
                parametrosVentas.idventa = Convert.ToInt32(dataventas["idventa"]);
                parametrosVentas.Serie = dataventas["Serie"].ToString();
                parametrosVentas.Correlativo = dataventas["Correlativo"].ToString();
                parametrosVentas.fecha_venta = Convert.ToDateTime(dataventas["fecha_venta"]);
                parametrosVentas.Fecha_de_pago = Convert.ToDateTime(dataventas["Fecha_de_pago"]);
                parametrosVentas.CodigoComprobante = dataventas["Codigo"].ToString();
                parametrosVentas.contadorProductos = Convert.ToInt32(dataventas["ContadorProductos"]);
                parametrosVentas.EmpresaRUCemisor = dataventas["Ruc"].ToString();
                parametrosVentas.EmpresaRazonsocialEmisora = dataventas["RazonSocial"].ToString();
                parametrosVentas.Ubigeo = dataventas["Ubigeo"].ToString();
                var parametrosUbigeos = new Lcodigosubigeos();
                ObtenerUbigeos(parametrosVentas.Ubigeo, parametrosUbigeos);
                parametrosVentas.DptoempresaEmisora = parametrosUbigeos.Departamento;
                parametrosVentas.ProvempresaEmisora = parametrosUbigeos.Provincia;
                parametrosVentas.DistmpresaEmisora = parametrosUbigeos.Distrito;
                parametrosVentas.DireccionEmpresaEmisora = dataventas["DireccionFiscal"].ToString();
                parametrosVentas.EmpresaRUCcliente = dataventas["NroDoc"].ToString();
                parametrosVentas.EmpresaRazonsocialCliente = dataventas["Nombre"].ToString();
                parametrosVentas.DireccionCliente = dataventas["Direccion"].ToString();
                parametrosVentas.TotalIgv = Convert.ToDecimal(dataventas["TotalIgv"]);
                parametrosVentas.TotSubtotal = Convert.ToDecimal(dataventas["TotSubtotal"]);
                parametrosVentas.Monto_total = Convert.ToDecimal(dataventas["Monto_total"]);
                parametrosVentas.Porcentaje_IGV = Convert.ToDouble(dataventas["Porcentaje_IGV"]);

            }
            var funciondeDv = new Ddetalleventas();
            var parametrosDv = new LdetalleVenta();
            var dtDv = new DataTable();
            parametrosDv.idventa = parametrosVentas.idventa;
            funciondeDv.MostrarDetalleVenta(ref dtDv, parametrosDv);
            var detalle = new List<LdetalleVenta>();
            foreach (DataRow items in dtDv.Rows)
            {
                var datadv = new LdetalleVenta();
                datadv.Unidad_de_medida = items["Unidad_de_medida"].ToString();
                datadv.cantidad = Convert.ToDecimal(items["Cant"]);
                datadv.Total_a_pagar = Convert.ToDecimal(items["Importe"]);
                datadv.preciounitario = Convert.ToDecimal(items["P_Unit"]);
                datadv.Descripcion = items["Producto"].ToString();
                datadv.Codigo = items["Codigo"].ToString();
                datadv.CodigoProdSunat = items["CodProdSunat"].ToString();
                detalle.Add(datadv);
            }
            int estado = 0;
            var funcion = new EmitirComprobante();
            estado = funcion.EmitirFacturasContado(parametrosVentas, detalle);
            if (estado == 1)
            {
                editarEstadoSunatVenta();
            }
        }
        private void editarEstadoSunatVenta()
        {
            var funcion = new Dventas();
            var parametros = new Lventas();
            parametros.idventa = idventa;
            funcion.editarEstadoSunatVenta(parametros);
        }
        private void ObtenerUbigeos(string ubigeo, Lcodigosubigeos parametros)
        {
            var dt = new DataTable();
            var funcion = new Dcodigosubigeo();
            var parametrosUbigeo = new Lcodigosubigeos();
            parametrosUbigeo.Ubigeo = ubigeo;
            funcion.ObtenerUbicaionXubigeo(ref dt, parametrosUbigeo);
            parametros.Departamento = dt.Rows[0][0].ToString();
            parametros.Provincia = dt.Rows[0][1].ToString();
            parametros.Distrito = dt.Rows[0][2].ToString();

        }
        void confirmarVenta()
        {
            var funcion = new Dventas();
            var parametros = new Lventas();
            parametros.idventa = idventa;
            parametros.idclientev = idcliente;
            parametros.Monto_total = total;
            parametros.Tipo_de_pago = Tipopago;
            parametros.Saldo = vuelto;
            parametros.Pago_con = Convert.ToDecimal(txtefectivo.Text);
            parametros.Referencia_tarjeta = txtreferencia.Text;
            parametros.Vuelto = vuelto;
            parametros.Efectivo = efectivo_calculado;
            parametros.Credito = Convert.ToDecimal(txtcredito.Text);
            parametros.Tarjeta = Convert.ToDecimal(txttarjeta.Text);
            parametros.Idcomprobante = idcomprobante;
            funcion.confirmarVenta(parametros);
            convertirTotalaletras();
            DisminuirStock();
        }
        private void DisminuirStock()
        {
            var funcion = new Dproductos();
            var parametros = new Lproductos();

            var funciondeDv = new Ddetalleventas();
            var parametrosDv = new LdetalleVenta();
            var dtDv = new DataTable();
            parametrosDv.idventa = idventa;
            funciondeDv.MostrarDetalleVenta(ref dtDv, parametrosDv);
            foreach (DataRow items in dtDv.Rows)
            {
                string UsaInventarios = items["Usa_inventarios"].ToString();
                if (UsaInventarios == "SI")
                {
                    int idproducto = Convert.ToInt32(items["Id_producto"]);
                    double cantidad = Convert.ToDouble(items["Cant"]);
                    parametros.Id_Producto1 = idproducto;
                    parametros.Cantidad = cantidad;
                    funcion.disminuirStock(parametros);
                }
            }
        }

        void Validartexbox()
        {
            if (txtefectivo.Text == "")
            {
                txtefectivo.Text = "0";
            }
            if (txtcredito.Text == "")
            {
                txtcredito.Text = "0";
            }
            if (txttarjeta.Text == "")
            {
                txttarjeta.Text = "0";
            }
            if (lblvuelto.Text == "")
            {
                lblvuelto.Text = "0";
            }
        }

        private void identificarTipopago()
        {
            int indicadorEfectivo = 4;
            int indicadorCredito = 2;
            int indicadorTarjeta = 3;

            // validacion para evitar valores vacios
            if (txtefectivo.Text == "")
            {
                txtefectivo.Text = "0";
            }
            if (txttarjeta.Text == "")
            {
                txttarjeta.Text = "0";
            }
            if (txtcredito.Text == "")
            {
                txtcredito.Text = "0";
            }
            //validacion de .
            if (txtefectivo.Text == ".")
            {
                txtefectivo.Text = "0";
            }
            if (txttarjeta.Text == ".")
            {
                txttarjeta.Text = "0";
            }
            if (txtcredito.Text == ".")
            {
                txtcredito.Text = "0";
            }
            //validacion de 0
            if (txtefectivo.Text == "0")
            {
                indicadorEfectivo = 0;
            }
            if (txttarjeta.Text == "0")
            {
                indicadorTarjeta = 0;
            }
            if (txtcredito.Text == "0")
            {
                indicadorCredito = 0;
            }
            //calculo de indicador
            int calculo_identificacion = indicadorCredito + indicadorEfectivo + indicadorTarjeta;
            //consulta al identificador
            if (calculo_identificacion == 4)
            {
                Tipopago = "EFECTIVO";
            }
            if (calculo_identificacion == 2)
            {
                Tipopago = "CREDITO";
            }
            if (calculo_identificacion == 3)
            {
                Tipopago = "TARJETA";
            }
            if (calculo_identificacion > 4)
            {
                Tipopago = "MIXTO";
            }

        }
        private void txtefectivo_TextChanged(object sender, EventArgs e)
        {
            calcular_restante();
        }
        void calcular_restante()
        {
            try
            {
                decimal efectivo = 0;
                decimal tarjeta = 0;

                if (txtefectivo.Text == "")
                {
                    efectivo = 0;
                }
                else
                {
                    efectivo = Convert.ToDecimal(txtefectivo.Text);
                }
                if (txtcredito.Text == "")
                {
                    credito = 0;
                }
                else
                {
                    credito = Convert.ToDecimal(txtcredito.Text);
                }
                if (txttarjeta.Text == "")
                {
                    tarjeta = 0;
                }
                else
                {
                    tarjeta = Convert.ToDecimal(txttarjeta.Text);
                }

                if (txtefectivo.Text == "0.00")
                {
                    efectivo = 0;
                }
                if (txtcredito.Text == "0.00")
                {
                    credito = 0;
                }
                if (txttarjeta.Text == "0.00")
                {
                    tarjeta = 0;

                }

                if (txtefectivo.Text == ".")
                {
                    efectivo = 0;
                }
                if (txtcredito.Text == ".")
                {
                    tarjeta = 0;
                }
                if (txttarjeta.Text == ".")
                {
                    credito = 0;
                }

                try
                {
                    if (efectivo > total)
                    {
                        efectivo_calculado = efectivo - (total + credito + tarjeta);
                        if (efectivo_calculado < 0)
                        {
                            vuelto = 0;
                            lblvuelto.Text = "0";
                            txtrestante.Text = Convert.ToString(efectivo_calculado);
                            restante = efectivo_calculado;
                        }
                        else
                        {
                            vuelto = efectivo - (total - credito - tarjeta);
                            lblvuelto.Text = Convert.ToString(vuelto);
                            restante = efectivo - (total + credito + tarjeta + efectivo_calculado);
                            txtrestante.Text = Convert.ToString(restante);
                            txtrestante.Text = decimal.Parse(txtrestante.Text).ToString("##0.00");
                        }

                    }
                    else
                    {
                        vuelto = 0;
                        lblvuelto.Text = "0";
                        efectivo_calculado = efectivo;
                        restante = total - efectivo_calculado - credito - tarjeta;
                        txtrestante.Text = Convert.ToString(restante);
                        txtrestante.Text = decimal.Parse(txtrestante.Text).ToString("##0.00");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.StackTrace);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void txttarjeta_TextChanged(object sender, EventArgs e)
        {
            calcular_restante();
        }

        private void txtcredito_TextChanged(object sender, EventArgs e)
        {
            calcular_restante();
        }

        private void btnAgregarcliente_Click(object sender, EventArgs e)
        {
            var ctl = new Agregarcliente();
            ctl.Dock = DockStyle.Fill;
            panelCobro.Controls.Add(ctl);
            ctl.BringToFront();
        }

        private void txtbuscarcliente_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtbuscarcliente.Text))
            {
                buscarclientes();
            }
            else
            {
                dgClientes.Visible = false;
            }


        }
        private void buscarclientes()
        {
            DataTable dt = new DataTable();
            Obtener_datos.buscar_clientes(ref dt, txtbuscarcliente.Text);
            dgClientes.DataSource = dt;
            dgClientes.Visible = true;
            dgClientes.Size = new Size(288, 78);
            dgClientes.Location = new Point(panelClienteFactura.Location.X, panelClienteFactura.Location.Y + 80);
            dgClientes.Columns[0].Visible = false;
            dgClientes.Columns[2].Visible = false;
            dgClientes.Columns[3].Visible = false;
            dgClientes.Columns[4].Visible = false;
            dgClientes.Columns[5].Visible = false;
            dgClientes.Columns[6].Visible = false;
            dgClientes.BringToFront();

        }

        private void dgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idcliente = Convert.ToInt32(dgClientes.SelectedCells[0].Value);
            txtbuscarcliente.Text = dgClientes.SelectedCells[1].Value.ToString();
            dgClientes.Visible = false;
        }

        private void txtefectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bases.Separador_de_Numeros(txtefectivo, e);
        }

        private void txttarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bases.Separador_de_Numeros(txttarjeta, e);

        }

        private void txtcredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bases.Separador_de_Numeros(txtcredito, e);

        }

        private void txtreferencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtbuscarcliente_Click(object sender, EventArgs e)
        {
            txtbuscarcliente.SelectAll();
        }
        private void ObtenerdatosDV()
        {
            iddettallev = Convert.ToInt32(dgDetalleventa.SelectedCells[9].Value.ToString());
        }
        private void SumarCantDv()
        {
            var funcion = new Ddetalleventas();
            var parametros = new LdetalleVenta();
            parametros.iddetalle_venta = iddettallev;
            funcion.SumarCantDv(parametros);
            mostrarDv();
        }
        private void EliminarDv()
        {
            var funcion = new Ddetalleventas();
            var parametros = new LdetalleVenta();
            parametros.iddetalle_venta = iddettallev;
            funcion.EliminarDv(parametros);
            mostrarDv();
        }
        private void dgDetalleventa_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            ObtenerdatosDV();
            if (e.ColumnIndex == this.dgDetalleventa.Columns["S"].Index)
            {
                SumarCantDv();
            }
            if (e.ColumnIndex == this.dgDetalleventa.Columns["R"].Index)
            {
                RestarCantDv();
                EliminarVentas();
            }
            if (e.ColumnIndex == this.dgDetalleventa.Columns["EL"].Index)
            {
                EliminarDv();
                EliminarVentas();
            }

        }
        private void RestarCantDv()
        {
            var funcion = new Ddetalleventas();
            var parametros = new LdetalleVenta();
            parametros.iddetalle_venta = iddettallev;
            parametros.idventa = idventa;
            funcion.RestarCantDv(parametros);
            mostrarDv();
        }
        private void EliminarVentas()
        {
            if (dgDetalleventa.Rows.Count == 0)
            {
                var funcion = new Dventas();
                var parametros = new Lventas();
                parametros.idventa = idventa;
                funcion.eliminarVenta(parametros);
                ventagenerada = "NUEVA";
                idventa = 0;
            }

        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            var ctl = new Cierrecaja();
            ctl.Size = new Size(Width, Height);
            this.Controls.Add(ctl);
            ctl.BringToFront();
        }

        private void btndevoluciones_Click(object sender, EventArgs e)
        {
            var ctl = new HistorialVentasForm();
            ctl.Size = new Size(Width, Height);
            this.Controls.Add(ctl);
            ctl.BringToFront();
        }

        private void btnMovcaja_Click(object sender, EventArgs e)
        {
            var ctl = new Listado_gastos_ingresos();
            ctl.Size = new Size(Width, Height);
            this.Controls.Add(ctl);
            ctl.BringToFront();
        }

        private void btningreso_Click(object sender, EventArgs e)
        {
            var ctl = new IngresosVarios();
            ctl.Size = new Size(Width, Height);
            this.Controls.Add(ctl);
            ctl.BringToFront();
        }

        private void btnsalida_Click(object sender, EventArgs e)
        {
            var ctl = new Gastos();
            ctl.Size = new Size(Width, Height);
            this.Controls.Add(ctl);
            ctl.BringToFront();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dgDetalleventa.RowCount > 0)
            {
                DialogResult pregunta = MessageBox.Show("¿Realmente desea eliminar esta Venta?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (pregunta == DialogResult.OK)
                {
                    var funcion = new Dventas();
                    var parametros = new Lventas();
                    parametros.idventa = idventa;
                    funcion.eliminarVenta(parametros);
                    Ventanueva();
                }
            }
        }

        private void btnmayoreo_Click(object sender, EventArgs e)
        {
            aplicarPreciomayoreo();
        }
        private void aplicarPreciomayoreo()
        {
            if (dgDetalleventa.Rows.Count > 0)
            {
                LdetalleVenta parametros = new LdetalleVenta();
                Editar_datos funcion = new Editar_datos();
                parametros.Id_producto = idproducto;
                parametros.iddetalle_venta = iddettallev;
                if (funcion.aplicar_precio_mayoreo(parametros) == true)
                {
                    mostrarDv();
                }
            }

        }
    }
}
