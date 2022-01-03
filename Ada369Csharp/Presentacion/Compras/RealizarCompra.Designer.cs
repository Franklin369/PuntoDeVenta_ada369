namespace Ada369Csharp.Presentacion.Compras
{
    partial class RealizarCompra
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RealizarCompra));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelOperaciones = new System.Windows.Forms.Panel();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btncantidad = new System.Windows.Forms.Button();
            this.Panel15 = new System.Windows.Forms.Panel();
            this.txt_total_suma = new System.Windows.Forms.Label();
            this.txtmonto = new System.Windows.Forms.TextBox();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnprecio = new System.Windows.Forms.Button();
            this.btnSeparador = new System.Windows.Forms.Button();
            this.btnborrartodo = new System.Windows.Forms.Button();
            this.FlowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.panelC2 = new System.Windows.Forms.Panel();
            this.panelReferenciaProductos = new System.Windows.Forms.Panel();
            this.lbltipodebusqueda2 = new System.Windows.Forms.Label();
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnteclado = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.panelProveedores = new System.Windows.Forms.Panel();
            this.btnagregarPro = new System.Windows.Forms.Button();
            this.FlowpanelProveedor = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarproveedores = new System.Windows.Forms.TextBox();
            this.dgDetallecompra = new System.Windows.Forms.DataGridView();
            this.EL = new System.Windows.Forms.DataGridViewImageColumn();
            this.PanelOperaciones.SuspendLayout();
            this.Panel15.SuspendLayout();
            this.FlowLayoutPanel2.SuspendLayout();
            this.panelC2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            this.panelProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetallecompra)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelOperaciones
            // 
            this.PanelOperaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.PanelOperaciones.Controls.Add(this.btnguardar);
            this.PanelOperaciones.Controls.Add(this.btncantidad);
            this.PanelOperaciones.Controls.Add(this.Panel15);
            this.PanelOperaciones.Controls.Add(this.txtmonto);
            this.PanelOperaciones.Controls.Add(this.btn0);
            this.PanelOperaciones.Controls.Add(this.btnprecio);
            this.PanelOperaciones.Controls.Add(this.btnSeparador);
            this.PanelOperaciones.Controls.Add(this.btnborrartodo);
            this.PanelOperaciones.Controls.Add(this.FlowLayoutPanel2);
            this.PanelOperaciones.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelOperaciones.Location = new System.Drawing.Point(687, 0);
            this.PanelOperaciones.Name = "PanelOperaciones";
            this.PanelOperaciones.Size = new System.Drawing.Size(290, 651);
            this.PanelOperaciones.TabIndex = 621;
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.Transparent;
            this.btnguardar.BackgroundImage = global::Ada369Csharp.Properties.Resources.verde;
            this.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnguardar.FlatAppearance.BorderSize = 0;
            this.btnguardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnguardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Location = new System.Drawing.Point(3, 354);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(149, 65);
            this.btnguardar.TabIndex = 607;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btncantidad
            // 
            this.btncantidad.BackColor = System.Drawing.Color.Transparent;
            this.btncantidad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncantidad.BackgroundImage")));
            this.btncantidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncantidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncantidad.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btncantidad.FlatAppearance.BorderSize = 0;
            this.btncantidad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btncantidad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btncantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncantidad.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.btncantidad.ForeColor = System.Drawing.Color.White;
            this.btncantidad.Location = new System.Drawing.Point(193, 109);
            this.btncantidad.Name = "btncantidad";
            this.btncantidad.Size = new System.Drawing.Size(90, 55);
            this.btncantidad.TabIndex = 41;
            this.btncantidad.Text = "CANT";
            this.btncantidad.UseVisualStyleBackColor = false;
            this.btncantidad.Click += new System.EventHandler(this.btncantidad_Click);
            // 
            // Panel15
            // 
            this.Panel15.BackColor = System.Drawing.Color.Transparent;
            this.Panel15.Controls.Add(this.txt_total_suma);
            this.Panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel15.Location = new System.Drawing.Point(0, 0);
            this.Panel15.Name = "Panel15";
            this.Panel15.Size = new System.Drawing.Size(290, 64);
            this.Panel15.TabIndex = 540;
            // 
            // txt_total_suma
            // 
            this.txt_total_suma.BackColor = System.Drawing.Color.Transparent;
            this.txt_total_suma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_total_suma.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.txt_total_suma.ForeColor = System.Drawing.Color.Black;
            this.txt_total_suma.Location = new System.Drawing.Point(0, 0);
            this.txt_total_suma.Name = "txt_total_suma";
            this.txt_total_suma.Size = new System.Drawing.Size(290, 64);
            this.txt_total_suma.TabIndex = 507;
            this.txt_total_suma.Text = "0";
            this.txt_total_suma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtmonto
            // 
            this.txtmonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.txtmonto.Location = new System.Drawing.Point(3, 67);
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.Size = new System.Drawing.Size(280, 35);
            this.txtmonto.TabIndex = 606;
            this.txtmonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtmonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmonto_KeyPress);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Transparent;
            this.btn0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn0.BackgroundImage")));
            this.btn0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold);
            this.btn0.ForeColor = System.Drawing.Color.White;
            this.btn0.Location = new System.Drawing.Point(3, 292);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(55, 56);
            this.btn0.TabIndex = 605;
            this.btn0.Text = "0";
            this.btn0.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnprecio
            // 
            this.btnprecio.BackColor = System.Drawing.Color.Transparent;
            this.btnprecio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnprecio.BackgroundImage")));
            this.btnprecio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnprecio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnprecio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnprecio.FlatAppearance.BorderSize = 0;
            this.btnprecio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnprecio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnprecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprecio.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.btnprecio.ForeColor = System.Drawing.Color.White;
            this.btnprecio.Location = new System.Drawing.Point(193, 171);
            this.btnprecio.Name = "btnprecio";
            this.btnprecio.Size = new System.Drawing.Size(90, 55);
            this.btnprecio.TabIndex = 41;
            this.btnprecio.Text = "PREC";
            this.btnprecio.UseVisualStyleBackColor = false;
            this.btnprecio.Click += new System.EventHandler(this.btnprecio_Click);
            // 
            // btnSeparador
            // 
            this.btnSeparador.BackColor = System.Drawing.Color.Transparent;
            this.btnSeparador.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSeparador.BackgroundImage")));
            this.btnSeparador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSeparador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeparador.FlatAppearance.BorderSize = 0;
            this.btnSeparador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSeparador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSeparador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeparador.Font = new System.Drawing.Font("Calibri", 21F, System.Drawing.FontStyle.Bold);
            this.btnSeparador.ForeColor = System.Drawing.Color.White;
            this.btnSeparador.Location = new System.Drawing.Point(64, 292);
            this.btnSeparador.Name = "btnSeparador";
            this.btnSeparador.Size = new System.Drawing.Size(55, 56);
            this.btnSeparador.TabIndex = 604;
            this.btnSeparador.Text = ",";
            this.btnSeparador.UseVisualStyleBackColor = false;
            this.btnSeparador.Click += new System.EventHandler(this.btnSeparador_Click);
            // 
            // btnborrartodo
            // 
            this.btnborrartodo.BackColor = System.Drawing.Color.Transparent;
            this.btnborrartodo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnborrartodo.BackgroundImage")));
            this.btnborrartodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnborrartodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnborrartodo.FlatAppearance.BorderSize = 0;
            this.btnborrartodo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnborrartodo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnborrartodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnborrartodo.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.btnborrartodo.ForeColor = System.Drawing.Color.White;
            this.btnborrartodo.Location = new System.Drawing.Point(125, 292);
            this.btnborrartodo.Name = "btnborrartodo";
            this.btnborrartodo.Size = new System.Drawing.Size(55, 56);
            this.btnborrartodo.TabIndex = 603;
            this.btnborrartodo.Text = "Borrar";
            this.btnborrartodo.UseVisualStyleBackColor = false;
            this.btnborrartodo.Click += new System.EventHandler(this.btnborrartodo_Click);
            // 
            // FlowLayoutPanel2
            // 
            this.FlowLayoutPanel2.Controls.Add(this.btn1);
            this.FlowLayoutPanel2.Controls.Add(this.btn2);
            this.FlowLayoutPanel2.Controls.Add(this.btn3);
            this.FlowLayoutPanel2.Controls.Add(this.btn4);
            this.FlowLayoutPanel2.Controls.Add(this.btn5);
            this.FlowLayoutPanel2.Controls.Add(this.btn6);
            this.FlowLayoutPanel2.Controls.Add(this.btn7);
            this.FlowLayoutPanel2.Controls.Add(this.btn8);
            this.FlowLayoutPanel2.Controls.Add(this.btn9);
            this.FlowLayoutPanel2.Location = new System.Drawing.Point(0, 106);
            this.FlowLayoutPanel2.Name = "FlowLayoutPanel2";
            this.FlowLayoutPanel2.Size = new System.Drawing.Size(187, 184);
            this.FlowLayoutPanel2.TabIndex = 602;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Transparent;
            this.btn1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn1.BackgroundImage")));
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold);
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(3, 3);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(55, 55);
            this.btn1.TabIndex = 40;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Transparent;
            this.btn2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn2.BackgroundImage")));
            this.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold);
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(64, 3);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(55, 55);
            this.btn2.TabIndex = 41;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Transparent;
            this.btn3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn3.BackgroundImage")));
            this.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold);
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.Location = new System.Drawing.Point(125, 3);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(55, 55);
            this.btn3.TabIndex = 42;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Transparent;
            this.btn4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn4.BackgroundImage")));
            this.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold);
            this.btn4.ForeColor = System.Drawing.Color.White;
            this.btn4.Location = new System.Drawing.Point(3, 64);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(55, 55);
            this.btn4.TabIndex = 35;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Transparent;
            this.btn5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn5.BackgroundImage")));
            this.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold);
            this.btn5.ForeColor = System.Drawing.Color.White;
            this.btn5.Location = new System.Drawing.Point(64, 64);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(55, 55);
            this.btn5.TabIndex = 36;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Transparent;
            this.btn6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn6.BackgroundImage")));
            this.btn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold);
            this.btn6.ForeColor = System.Drawing.Color.White;
            this.btn6.Location = new System.Drawing.Point(125, 64);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(55, 55);
            this.btn6.TabIndex = 37;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Transparent;
            this.btn7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn7.BackgroundImage")));
            this.btn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold);
            this.btn7.ForeColor = System.Drawing.Color.White;
            this.btn7.Location = new System.Drawing.Point(3, 125);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(55, 55);
            this.btn7.TabIndex = 30;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Transparent;
            this.btn8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn8.BackgroundImage")));
            this.btn8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold);
            this.btn8.ForeColor = System.Drawing.Color.White;
            this.btn8.Location = new System.Drawing.Point(64, 125);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(55, 55);
            this.btn8.TabIndex = 31;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Transparent;
            this.btn9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn9.BackgroundImage")));
            this.btn9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold);
            this.btn9.ForeColor = System.Drawing.Color.White;
            this.btn9.Location = new System.Drawing.Point(125, 125);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(55, 55);
            this.btn9.TabIndex = 32;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // panelC2
            // 
            this.panelC2.BackColor = System.Drawing.Color.White;
            this.panelC2.Controls.Add(this.panelReferenciaProductos);
            this.panelC2.Controls.Add(this.lbltipodebusqueda2);
            this.panelC2.Controls.Add(this.dgProductos);
            this.panelC2.Controls.Add(this.btnteclado);
            this.panelC2.Controls.Add(this.txtbuscar);
            this.panelC2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelC2.Location = new System.Drawing.Point(0, 0);
            this.panelC2.Name = "panelC2";
            this.panelC2.Size = new System.Drawing.Size(687, 64);
            this.panelC2.TabIndex = 622;
            // 
            // panelReferenciaProductos
            // 
            this.panelReferenciaProductos.Location = new System.Drawing.Point(12, 47);
            this.panelReferenciaProductos.Name = "panelReferenciaProductos";
            this.panelReferenciaProductos.Size = new System.Drawing.Size(13, 10);
            this.panelReferenciaProductos.TabIndex = 636;
            // 
            // lbltipodebusqueda2
            // 
            this.lbltipodebusqueda2.AutoSize = true;
            this.lbltipodebusqueda2.BackColor = System.Drawing.Color.White;
            this.lbltipodebusqueda2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbltipodebusqueda2.ForeColor = System.Drawing.Color.DimGray;
            this.lbltipodebusqueda2.Location = new System.Drawing.Point(24, 18);
            this.lbltipodebusqueda2.Name = "lbltipodebusqueda2";
            this.lbltipodebusqueda2.Size = new System.Drawing.Size(201, 18);
            this.lbltipodebusqueda2.TabIndex = 635;
            this.lbltipodebusqueda2.Text = "Buscar por Codigo de Barras";
            this.lbltipodebusqueda2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgProductos
            // 
            this.dgProductos.AllowUserToAddRows = false;
            this.dgProductos.AllowUserToDeleteRows = false;
            this.dgProductos.AllowUserToResizeRows = false;
            this.dgProductos.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.ColumnHeadersVisible = false;
            this.dgProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgProductos.EnableHeadersVisualStyles = false;
            this.dgProductos.Location = new System.Drawing.Point(533, 3);
            this.dgProductos.MultiSelect = false;
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.ReadOnly = true;
            this.dgProductos.RowHeadersVisible = false;
            this.dgProductos.RowHeadersWidth = 9;
            this.dgProductos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.dgProductos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgProductos.RowTemplate.Height = 40;
            this.dgProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProductos.Size = new System.Drawing.Size(148, 40);
            this.dgProductos.TabIndex = 634;
            this.dgProductos.Visible = false;
            this.dgProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductos_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // btnteclado
            // 
            this.btnteclado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnteclado.FlatAppearance.BorderSize = 0;
            this.btnteclado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnteclado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnteclado.Image = global::Ada369Csharp.Properties.Resources.cobrosIcono;
            this.btnteclado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnteclado.Location = new System.Drawing.Point(392, 7);
            this.btnteclado.Name = "btnteclado";
            this.btnteclado.Size = new System.Drawing.Size(99, 34);
            this.btnteclado.TabIndex = 633;
            this.btnteclado.Text = "Teclado";
            this.btnteclado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnteclado.UseVisualStyleBackColor = false;
            // 
            // txtbuscar
            // 
            this.txtbuscar.BackColor = System.Drawing.Color.White;
            this.txtbuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtbuscar.Location = new System.Drawing.Point(12, 15);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(374, 26);
            this.txtbuscar.TabIndex = 631;
            this.txtbuscar.Click += new System.EventHandler(this.txtbuscar_Click);
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // panelProveedores
            // 
            this.panelProveedores.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelProveedores.Controls.Add(this.btnagregarPro);
            this.panelProveedores.Controls.Add(this.FlowpanelProveedor);
            this.panelProveedores.Controls.Add(this.label1);
            this.panelProveedores.Controls.Add(this.txtBuscarproveedores);
            this.panelProveedores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelProveedores.Location = new System.Drawing.Point(0, 484);
            this.panelProveedores.Name = "panelProveedores";
            this.panelProveedores.Size = new System.Drawing.Size(687, 167);
            this.panelProveedores.TabIndex = 623;
            // 
            // btnagregarPro
            // 
            this.btnagregarPro.BackColor = System.Drawing.Color.Transparent;
            this.btnagregarPro.BackgroundImage = global::Ada369Csharp.Properties.Resources.naranja;
            this.btnagregarPro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnagregarPro.FlatAppearance.BorderSize = 0;
            this.btnagregarPro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnagregarPro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnagregarPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregarPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregarPro.ForeColor = System.Drawing.Color.White;
            this.btnagregarPro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnagregarPro.Location = new System.Drawing.Point(479, 3);
            this.btnagregarPro.Name = "btnagregarPro";
            this.btnagregarPro.Size = new System.Drawing.Size(90, 40);
            this.btnagregarPro.TabIndex = 635;
            this.btnagregarPro.Text = "Agregar";
            this.btnagregarPro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnagregarPro.UseVisualStyleBackColor = false;
            this.btnagregarPro.Click += new System.EventHandler(this.btnagregarPro_Click);
            // 
            // FlowpanelProveedor
            // 
            this.FlowpanelProveedor.Location = new System.Drawing.Point(7, 49);
            this.FlowpanelProveedor.Name = "FlowpanelProveedor";
            this.FlowpanelProveedor.Size = new System.Drawing.Size(674, 104);
            this.FlowpanelProveedor.TabIndex = 634;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 633;
            this.label1.Text = "Proveedor:";
            // 
            // txtBuscarproveedores
            // 
            this.txtBuscarproveedores.BackColor = System.Drawing.Color.White;
            this.txtBuscarproveedores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarproveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBuscarproveedores.Location = new System.Drawing.Point(107, 11);
            this.txtBuscarproveedores.Name = "txtBuscarproveedores";
            this.txtBuscarproveedores.Size = new System.Drawing.Size(365, 26);
            this.txtBuscarproveedores.TabIndex = 632;
            this.txtBuscarproveedores.TextChanged += new System.EventHandler(this.txtBuscarproveedores_TextChanged);
            // 
            // dgDetallecompra
            // 
            this.dgDetallecompra.AllowUserToAddRows = false;
            this.dgDetallecompra.AllowUserToDeleteRows = false;
            this.dgDetallecompra.AllowUserToResizeRows = false;
            this.dgDetallecompra.BackgroundColor = System.Drawing.Color.White;
            this.dgDetallecompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgDetallecompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgDetallecompra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDetallecompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgDetallecompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetallecompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EL});
            this.dgDetallecompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDetallecompra.EnableHeadersVisualStyles = false;
            this.dgDetallecompra.GridColor = System.Drawing.Color.Gainsboro;
            this.dgDetallecompra.Location = new System.Drawing.Point(0, 64);
            this.dgDetallecompra.Name = "dgDetallecompra";
            this.dgDetallecompra.ReadOnly = true;
            this.dgDetallecompra.RowHeadersVisible = false;
            this.dgDetallecompra.RowHeadersWidth = 9;
            this.dgDetallecompra.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgDetallecompra.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgDetallecompra.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgDetallecompra.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.dgDetallecompra.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgDetallecompra.RowTemplate.Height = 36;
            this.dgDetallecompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDetallecompra.Size = new System.Drawing.Size(687, 420);
            this.dgDetallecompra.TabIndex = 624;
            this.dgDetallecompra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDetallecompra_CellClick);
            // 
            // EL
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.NullValue = null;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.EL.DefaultCellStyle = dataGridViewCellStyle10;
            this.EL.HeaderText = "";
            this.EL.Image = ((System.Drawing.Image)(resources.GetObject("EL.Image")));
            this.EL.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.EL.Name = "EL";
            this.EL.ReadOnly = true;
            this.EL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EL.ToolTipText = "Opcional \"Supr\" para Eliminar";
            // 
            // RealizarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgDetallecompra);
            this.Controls.Add(this.panelProveedores);
            this.Controls.Add(this.panelC2);
            this.Controls.Add(this.PanelOperaciones);
            this.Name = "RealizarCompra";
            this.Size = new System.Drawing.Size(977, 651);
            this.Load += new System.EventHandler(this.RealizarCompra_Load);
            this.PanelOperaciones.ResumeLayout(false);
            this.PanelOperaciones.PerformLayout();
            this.Panel15.ResumeLayout(false);
            this.FlowLayoutPanel2.ResumeLayout(false);
            this.panelC2.ResumeLayout(false);
            this.panelC2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            this.panelProveedores.ResumeLayout(false);
            this.panelProveedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetallecompra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel PanelOperaciones;
        private System.Windows.Forms.Button btnguardar;
        internal System.Windows.Forms.Button btncantidad;
        internal System.Windows.Forms.Panel Panel15;
        internal System.Windows.Forms.Label txt_total_suma;
        internal System.Windows.Forms.TextBox txtmonto;
        internal System.Windows.Forms.Button btn0;
        internal System.Windows.Forms.Button btnprecio;
        internal System.Windows.Forms.Button btnSeparador;
        internal System.Windows.Forms.Button btnborrartodo;
        internal System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel2;
        internal System.Windows.Forms.Button btn1;
        internal System.Windows.Forms.Button btn2;
        internal System.Windows.Forms.Button btn3;
        internal System.Windows.Forms.Button btn4;
        internal System.Windows.Forms.Button btn5;
        internal System.Windows.Forms.Button btn6;
        internal System.Windows.Forms.Button btn7;
        internal System.Windows.Forms.Button btn8;
        internal System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Panel panelC2;
        private System.Windows.Forms.Panel panelReferenciaProductos;
        internal System.Windows.Forms.Label lbltipodebusqueda2;
        public System.Windows.Forms.DataGridView dgProductos;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.Button btnteclado;
        internal System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Panel panelProveedores;
        private System.Windows.Forms.Button btnagregarPro;
        private System.Windows.Forms.FlowLayoutPanel FlowpanelProveedor;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtBuscarproveedores;
        internal System.Windows.Forms.DataGridView dgDetallecompra;
        private System.Windows.Forms.DataGridViewImageColumn EL;
    }
}
