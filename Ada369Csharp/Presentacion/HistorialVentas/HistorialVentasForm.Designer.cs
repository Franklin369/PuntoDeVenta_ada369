namespace Ada369Csharp.Presentacion.HistorialVentas
{
    partial class HistorialVentasForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialVentasForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncerrar = new System.Windows.Forms.Button();
            this.datalistadoVentas = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Panel29 = new System.Windows.Forms.Panel();
            this.txtbusca = new System.Windows.Forms.TextBox();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel7 = new System.Windows.Forms.Panel();
            this.Label51 = new System.Windows.Forms.Label();
            this.MenuStrip2 = new System.Windows.Forms.MenuStrip();
            this.btnHoy = new System.Windows.Forms.ToolStripMenuItem();
            this.ff = new System.Windows.Forms.DateTimePicker();
            this.fi = new System.Windows.Forms.DateTimePicker();
            this.Label20 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.panelBienvenida = new System.Windows.Forms.Panel();
            this.Label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Pcancelado = new System.Windows.Forms.PictureBox();
            this.panelTicket = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Telerik.ReportViewer.WinForms.ReportViewer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip5 = new System.Windows.Forms.MenuStrip();
            this.btnEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip6 = new System.Windows.Forms.MenuStrip();
            this.btnReimprimir = new System.Windows.Forms.ToolStripMenuItem();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblestadoSun = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistadoVentas)).BeginInit();
            this.panel2.SuspendLayout();
            this.MenuStrip1.SuspendLayout();
            this.Panel7.SuspendLayout();
            this.MenuStrip2.SuspendLayout();
            this.panelBienvenida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pcancelado)).BeginInit();
            this.panelTicket.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip5.SuspendLayout();
            this.menuStrip6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btncerrar);
            this.panel1.Controls.Add(this.datalistadoVentas);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Panel7);
            this.panel1.Controls.Add(this.Label17);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 612);
            this.panel1.TabIndex = 0;
            // 
            // btncerrar
            // 
            this.btncerrar.BackgroundImage = global::Ada369Csharp.Properties.Resources.volverblack;
            this.btncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.FlatAppearance.BorderSize = 0;
            this.btncerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btncerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.Location = new System.Drawing.Point(12, 12);
            this.btncerrar.Margin = new System.Windows.Forms.Padding(5);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(56, 29);
            this.btncerrar.TabIndex = 620;
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // datalistadoVentas
            // 
            this.datalistadoVentas.AllowUserToAddRows = false;
            this.datalistadoVentas.AllowUserToDeleteRows = false;
            this.datalistadoVentas.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            this.datalistadoVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.datalistadoVentas.BackgroundColor = System.Drawing.Color.White;
            this.datalistadoVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datalistadoVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.datalistadoVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datalistadoVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.datalistadoVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datalistadoVentas.DefaultCellStyle = dataGridViewCellStyle13;
            this.datalistadoVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datalistadoVentas.EnableHeadersVisualStyles = false;
            this.datalistadoVentas.Location = new System.Drawing.Point(0, 237);
            this.datalistadoVentas.Name = "datalistadoVentas";
            this.datalistadoVentas.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datalistadoVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.datalistadoVentas.RowHeadersVisible = false;
            this.datalistadoVentas.RowHeadersWidth = 9;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Gainsboro;
            this.datalistadoVentas.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.datalistadoVentas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.datalistadoVentas.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.datalistadoVentas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.datalistadoVentas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.datalistadoVentas.RowTemplate.Height = 40;
            this.datalistadoVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalistadoVentas.Size = new System.Drawing.Size(365, 375);
            this.datalistadoVentas.TabIndex = 549;
            this.datalistadoVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datalistadoVentas_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Panel29);
            this.panel2.Controls.Add(this.txtbusca);
            this.panel2.Controls.Add(this.MenuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 181);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 56);
            this.panel2.TabIndex = 548;
            // 
            // Panel29
            // 
            this.Panel29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(198)))), ((int)(((byte)(91)))));
            this.Panel29.Location = new System.Drawing.Point(12, 40);
            this.Panel29.Name = "Panel29";
            this.Panel29.Size = new System.Drawing.Size(273, 2);
            this.Panel29.TabIndex = 536;
            // 
            // txtbusca
            // 
            this.txtbusca.BackColor = System.Drawing.Color.White;
            this.txtbusca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbusca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtbusca.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtbusca.ForeColor = System.Drawing.Color.Black;
            this.txtbusca.Location = new System.Drawing.Point(12, 15);
            this.txtbusca.Name = "txtbusca";
            this.txtbusca.Size = new System.Drawing.Size(272, 22);
            this.txtbusca.TabIndex = 534;
            this.txtbusca.TextChanged += new System.EventHandler(this.txtbusca_TextChanged);
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.AutoSize = false;
            this.MenuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem5,
            this.toolStripMenuItem1});
            this.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MenuStrip1.Location = new System.Drawing.Point(286, 6);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.ShowItemToolTips = true;
            this.MenuStrip1.Size = new System.Drawing.Size(67, 45);
            this.MenuStrip1.TabIndex = 535;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // ToolStripMenuItem5
            // 
            this.ToolStripMenuItem5.AutoSize = false;
            this.ToolStripMenuItem5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ToolStripMenuItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripMenuItem5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.ToolStripMenuItem5.ForeColor = System.Drawing.Color.Black;
            this.ToolStripMenuItem5.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItem5.Image")));
            this.ToolStripMenuItem5.Name = "ToolStripMenuItem5";
            this.ToolStripMenuItem5.Size = new System.Drawing.Size(50, 30);
            this.ToolStripMenuItem5.Text = "+";
            this.ToolStripMenuItem5.ToolTipText = "Guardar ";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(126, 41);
            this.toolStripMenuItem1.Text = "ToolStripMenuItem3";
            // 
            // Panel7
            // 
            this.Panel7.BackColor = System.Drawing.Color.White;
            this.Panel7.Controls.Add(this.Label51);
            this.Panel7.Controls.Add(this.MenuStrip2);
            this.Panel7.Controls.Add(this.ff);
            this.Panel7.Controls.Add(this.fi);
            this.Panel7.Controls.Add(this.Label20);
            this.Panel7.Controls.Add(this.Label19);
            this.Panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel7.Location = new System.Drawing.Point(0, 49);
            this.Panel7.Name = "Panel7";
            this.Panel7.Size = new System.Drawing.Size(365, 132);
            this.Panel7.TabIndex = 547;
            // 
            // Label51
            // 
            this.Label51.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(63)))));
            this.Label51.Dock = System.Windows.Forms.DockStyle.Left;
            this.Label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.Label51.ForeColor = System.Drawing.Color.White;
            this.Label51.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label51.Location = new System.Drawing.Point(0, 0);
            this.Label51.Name = "Label51";
            this.Label51.Size = new System.Drawing.Size(46, 132);
            this.Label51.TabIndex = 547;
            this.Label51.Text = "F\r\nI\r\nL\r\nT\r\nR\r\nO\r\nS";
            this.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuStrip2
            // 
            this.MenuStrip2.AutoSize = false;
            this.MenuStrip2.BackColor = System.Drawing.Color.Transparent;
            this.MenuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.MenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHoy});
            this.MenuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MenuStrip2.Location = new System.Drawing.Point(124, 73);
            this.MenuStrip2.Name = "MenuStrip2";
            this.MenuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MenuStrip2.ShowItemToolTips = true;
            this.MenuStrip2.Size = new System.Drawing.Size(131, 37);
            this.MenuStrip2.TabIndex = 545;
            this.MenuStrip2.Text = "MenuStrip7";
            // 
            // btnHoy
            // 
            this.btnHoy.BackColor = System.Drawing.Color.Gainsboro;
            this.btnHoy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHoy.ForeColor = System.Drawing.Color.Black;
            this.btnHoy.Image = ((System.Drawing.Image)(resources.GetObject("btnHoy.Image")));
            this.btnHoy.Name = "btnHoy";
            this.btnHoy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.btnHoy.Size = new System.Drawing.Size(100, 33);
            this.btnHoy.Text = "Hoy (Todos)";
            this.btnHoy.Click += new System.EventHandler(this.btnHoy_Click);
            // 
            // ff
            // 
            this.ff.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.ff.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ff.Location = new System.Drawing.Point(131, 43);
            this.ff.Name = "ff";
            this.ff.Size = new System.Drawing.Size(124, 27);
            this.ff.TabIndex = 543;
            this.ff.ValueChanged += new System.EventHandler(this.ff_ValueChanged);
            // 
            // fi
            // 
            this.fi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.fi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fi.Location = new System.Drawing.Point(131, 10);
            this.fi.Name = "fi";
            this.fi.Size = new System.Drawing.Size(124, 27);
            this.fi.TabIndex = 543;
            this.fi.ValueChanged += new System.EventHandler(this.fi_ValueChanged);
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.Label20.ForeColor = System.Drawing.Color.Black;
            this.Label20.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label20.Location = new System.Drawing.Point(52, 43);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(68, 22);
            this.Label20.TabIndex = 460;
            this.Label20.Text = "Hasta:";
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.Label19.ForeColor = System.Drawing.Color.Black;
            this.Label19.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label19.Location = new System.Drawing.Point(52, 10);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(73, 22);
            this.Label19.TabIndex = 460;
            this.Label19.Text = "Desde:";
            // 
            // Label17
            // 
            this.Label17.BackColor = System.Drawing.Color.Transparent;
            this.Label17.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Label17.ForeColor = System.Drawing.Color.Black;
            this.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label17.Location = new System.Drawing.Point(0, 0);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(365, 49);
            this.Label17.TabIndex = 542;
            this.Label17.Text = "Ventas Realizadas";
            this.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBienvenida
            // 
            this.panelBienvenida.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBienvenida.Controls.Add(this.Label8);
            this.panelBienvenida.Controls.Add(this.pictureBox1);
            this.panelBienvenida.Controls.Add(this.panel4);
            this.panelBienvenida.Location = new System.Drawing.Point(728, 122);
            this.panelBienvenida.Name = "panelBienvenida";
            this.panelBienvenida.Size = new System.Drawing.Size(138, 59);
            this.panelBienvenida.TabIndex = 1;
            // 
            // Label8
            // 
            this.Label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F);
            this.Label8.ForeColor = System.Drawing.Color.DimGray;
            this.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label8.Location = new System.Drawing.Point(0, 331);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(138, 0);
            this.Label8.TabIndex = 2;
            this.Label8.Text = "Elije una Venta para Empezar";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Ada369Csharp.Properties.Resources.ada369logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 238);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(138, 238);
            this.panel4.TabIndex = 1;
            // 
            // Pcancelado
            // 
            this.Pcancelado.Image = ((System.Drawing.Image)(resources.GetObject("Pcancelado.Image")));
            this.Pcancelado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Pcancelado.Location = new System.Drawing.Point(872, 132);
            this.Pcancelado.Name = "Pcancelado";
            this.Pcancelado.Size = new System.Drawing.Size(206, 345);
            this.Pcancelado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pcancelado.TabIndex = 568;
            this.Pcancelado.TabStop = false;
            this.Pcancelado.Visible = false;
            // 
            // panelTicket
            // 
            this.panelTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.panelTicket.Controls.Add(this.reportViewer1);
            this.panelTicket.Controls.Add(this.panel5);
            this.panelTicket.Controls.Add(this.panel3);
            this.panelTicket.Location = new System.Drawing.Point(420, 187);
            this.panelTicket.Name = "panelTicket";
            this.panelTicket.Size = new System.Drawing.Size(635, 397);
            this.panelTicket.TabIndex = 569;
            this.panelTicket.Visible = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AccessibilityKeyMap = null;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 85);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(490, 312);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.menuStrip5);
            this.panel3.Controls.Add(this.menuStrip6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(490, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(145, 397);
            this.panel3.TabIndex = 571;
            // 
            // menuStrip5
            // 
            this.menuStrip5.AutoSize = false;
            this.menuStrip5.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip5.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEliminar});
            this.menuStrip5.Location = new System.Drawing.Point(7, 11);
            this.menuStrip5.Name = "menuStrip5";
            this.menuStrip5.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip5.ShowItemToolTips = true;
            this.menuStrip5.Size = new System.Drawing.Size(146, 47);
            this.menuStrip5.TabIndex = 568;
            this.menuStrip5.Text = "MenuStrip7";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.btnEliminar.Size = new System.Drawing.Size(117, 43);
            this.btnEliminar.Text = "Cancelar Venta";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // menuStrip6
            // 
            this.menuStrip6.AutoSize = false;
            this.menuStrip6.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip6.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReimprimir});
            this.menuStrip6.Location = new System.Drawing.Point(8, 58);
            this.menuStrip6.Name = "menuStrip6";
            this.menuStrip6.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip6.ShowItemToolTips = true;
            this.menuStrip6.Size = new System.Drawing.Size(145, 47);
            this.menuStrip6.TabIndex = 569;
            this.menuStrip6.Text = "MenuStrip7";
            // 
            // btnReimprimir
            // 
            this.btnReimprimir.AutoSize = false;
            this.btnReimprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(1)))));
            this.btnReimprimir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnReimprimir.ForeColor = System.Drawing.Color.Black;
            this.btnReimprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnReimprimir.Image")));
            this.btnReimprimir.Name = "btnReimprimir";
            this.btnReimprimir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.btnReimprimir.Size = new System.Drawing.Size(117, 43);
            this.btnReimprimir.Text = "Re-Imprimir";
            this.btnReimprimir.Click += new System.EventHandler(this.btnReimprimir_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblestadoSun);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(490, 85);
            this.panel5.TabIndex = 572;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(14, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 22);
            this.label2.TabIndex = 460;
            this.label2.Text = "Estado SUNAT:";
            // 
            // lblestadoSun
            // 
            this.lblestadoSun.AutoSize = true;
            this.lblestadoSun.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.lblestadoSun.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblestadoSun.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblestadoSun.Location = new System.Drawing.Point(171, 34);
            this.lblestadoSun.Name = "lblestadoSun";
            this.lblestadoSun.Size = new System.Drawing.Size(17, 22);
            this.lblestadoSun.TabIndex = 460;
            this.lblestadoSun.Text = "-";
            // 
            // HistorialVentasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelTicket);
            this.Controls.Add(this.Pcancelado);
            this.Controls.Add(this.panelBienvenida);
            this.Controls.Add(this.panel1);
            this.Name = "HistorialVentasForm";
            this.Size = new System.Drawing.Size(1598, 612);
            this.Load += new System.EventHandler(this.HistorialVentasForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datalistadoVentas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.Panel7.ResumeLayout(false);
            this.Panel7.PerformLayout();
            this.MenuStrip2.ResumeLayout(false);
            this.MenuStrip2.PerformLayout();
            this.panelBienvenida.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pcancelado)).EndInit();
            this.panelTicket.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.menuStrip5.ResumeLayout(false);
            this.menuStrip5.PerformLayout();
            this.menuStrip6.ResumeLayout(false);
            this.menuStrip6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Panel Panel7;
        internal System.Windows.Forms.Label Label51;
        internal System.Windows.Forms.MenuStrip MenuStrip2;
        internal System.Windows.Forms.ToolStripMenuItem btnHoy;
        internal System.Windows.Forms.DateTimePicker ff;
        internal System.Windows.Forms.DateTimePicker fi;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.Panel Panel29;
        internal System.Windows.Forms.TextBox txtbusca;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem5;
        internal System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        internal System.Windows.Forms.DataGridView datalistadoVentas;
        private System.Windows.Forms.Panel panelBienvenida;
        internal System.Windows.Forms.Label Label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        internal System.Windows.Forms.PictureBox Pcancelado;
        private System.Windows.Forms.Panel panelTicket;
        internal System.Windows.Forms.MenuStrip menuStrip6;
        internal System.Windows.Forms.ToolStripMenuItem btnReimprimir;
        internal System.Windows.Forms.MenuStrip menuStrip5;
        internal System.Windows.Forms.ToolStripMenuItem btnEliminar;
        private Telerik.ReportViewer.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        internal System.Windows.Forms.Label lblestadoSun;
        internal System.Windows.Forms.Label label2;
    }
}