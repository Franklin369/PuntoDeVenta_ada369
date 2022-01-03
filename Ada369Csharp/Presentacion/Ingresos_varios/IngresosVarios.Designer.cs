namespace Ada369Csharp.Presentacion.Ingresos_varios
{
    partial class IngresosVarios
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
            this.lbltipo = new System.Windows.Forms.Label();
            this.PanelDetalle = new System.Windows.Forms.Panel();
            this.txtfecha = new System.Windows.Forms.DateTimePicker();
            this.txtdetalle = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtimporte = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TXTACCION = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.GuardarRegistro = new System.Windows.Forms.Button();
            this.btnvolver = new System.Windows.Forms.Button();
            this.panelcomprobante = new System.Windows.Forms.Panel();
            this.Panel8 = new System.Windows.Forms.Panel();
            this.txttipocomprobante = new System.Windows.Forms.ComboBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtnrocomprobante = new System.Windows.Forms.TextBox();
            this.btnComprobante = new System.Windows.Forms.CheckBox();
            this.btncerrar = new System.Windows.Forms.Button();
            this.PanelDetalle.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelcomprobante.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltipo
            // 
            this.lbltipo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbltipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lbltipo.ForeColor = System.Drawing.Color.Black;
            this.lbltipo.Location = new System.Drawing.Point(0, 0);
            this.lbltipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(587, 50);
            this.lbltipo.TabIndex = 459;
            this.lbltipo.Text = "INGRESOS (+)";
            this.lbltipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelDetalle
            // 
            this.PanelDetalle.BackColor = System.Drawing.Color.White;
            this.PanelDetalle.Controls.Add(this.txtfecha);
            this.PanelDetalle.Controls.Add(this.txtdetalle);
            this.PanelDetalle.Controls.Add(this.Label4);
            this.PanelDetalle.Controls.Add(this.Label8);
            this.PanelDetalle.Controls.Add(this.txtimporte);
            this.PanelDetalle.Controls.Add(this.Label2);
            this.PanelDetalle.Controls.Add(this.TXTACCION);
            this.PanelDetalle.Location = new System.Drawing.Point(5, 53);
            this.PanelDetalle.Name = "PanelDetalle";
            this.PanelDetalle.Size = new System.Drawing.Size(576, 135);
            this.PanelDetalle.TabIndex = 468;
            // 
            // txtfecha
            // 
            this.txtfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtfecha.Location = new System.Drawing.Point(125, 45);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(188, 26);
            this.txtfecha.TabIndex = 464;
            // 
            // txtdetalle
            // 
            this.txtdetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdetalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdetalle.Location = new System.Drawing.Point(125, 77);
            this.txtdetalle.Margin = new System.Windows.Forms.Padding(4);
            this.txtdetalle.Multiline = true;
            this.txtdetalle.Name = "txtdetalle";
            this.txtdetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtdetalle.Size = new System.Drawing.Size(416, 49);
            this.txtdetalle.TabIndex = 217;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.Black;
            this.Label4.Location = new System.Drawing.Point(54, 79);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(63, 20);
            this.Label4.TabIndex = 216;
            this.Label4.Text = "Detalle:";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.Color.Black;
            this.Label8.Location = new System.Drawing.Point(60, 46);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(58, 20);
            this.Label8.TabIndex = 214;
            this.Label8.Text = "Fecha:";
            // 
            // txtimporte
            // 
            this.txtimporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtimporte.Font = new System.Drawing.Font("Arial", 12F);
            this.txtimporte.Location = new System.Drawing.Point(125, 8);
            this.txtimporte.Margin = new System.Windows.Forms.Padding(4);
            this.txtimporte.Name = "txtimporte";
            this.txtimporte.Size = new System.Drawing.Size(221, 26);
            this.txtimporte.TabIndex = 218;
            this.txtimporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtimporte_KeyPress);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Arial", 12F);
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(67, 10);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(55, 18);
            this.Label2.TabIndex = 215;
            this.Label2.Text = "Monto:";
            // 
            // TXTACCION
            // 
            this.TXTACCION.AutoSize = true;
            this.TXTACCION.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TXTACCION.ForeColor = System.Drawing.Color.Black;
            this.TXTACCION.Location = new System.Drawing.Point(259, 91);
            this.TXTACCION.Name = "TXTACCION";
            this.TXTACCION.Size = new System.Drawing.Size(70, 20);
            this.TXTACCION.TabIndex = 528;
            this.TXTACCION.Text = "ACCION";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.GuardarRegistro);
            this.flowLayoutPanel1.Controls.Add(this.btnvolver);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 333);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(573, 48);
            this.flowLayoutPanel1.TabIndex = 473;
            // 
            // GuardarRegistro
            // 
            this.GuardarRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(1)))));
            this.GuardarRegistro.FlatAppearance.BorderSize = 0;
            this.GuardarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuardarRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarRegistro.Location = new System.Drawing.Point(3, 3);
            this.GuardarRegistro.Name = "GuardarRegistro";
            this.GuardarRegistro.Size = new System.Drawing.Size(111, 33);
            this.GuardarRegistro.TabIndex = 462;
            this.GuardarRegistro.Text = "Guardar";
            this.GuardarRegistro.UseVisualStyleBackColor = false;
            this.GuardarRegistro.Click += new System.EventHandler(this.GuardarRegistro_Click);
            // 
            // btnvolver
            // 
            this.btnvolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnvolver.FlatAppearance.BorderSize = 0;
            this.btnvolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolver.Location = new System.Drawing.Point(120, 3);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(181, 33);
            this.btnvolver.TabIndex = 464;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = false;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // panelcomprobante
            // 
            this.panelcomprobante.BackColor = System.Drawing.Color.White;
            this.panelcomprobante.Controls.Add(this.Panel8);
            this.panelcomprobante.Controls.Add(this.txttipocomprobante);
            this.panelcomprobante.Controls.Add(this.Label10);
            this.panelcomprobante.Controls.Add(this.Label7);
            this.panelcomprobante.Controls.Add(this.txtnrocomprobante);
            this.panelcomprobante.Location = new System.Drawing.Point(5, 236);
            this.panelcomprobante.Margin = new System.Windows.Forms.Padding(4);
            this.panelcomprobante.Name = "panelcomprobante";
            this.panelcomprobante.Size = new System.Drawing.Size(576, 80);
            this.panelcomprobante.TabIndex = 472;
            // 
            // Panel8
            // 
            this.Panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(1)))));
            this.Panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel8.Location = new System.Drawing.Point(0, 0);
            this.Panel8.Name = "Panel8";
            this.Panel8.Size = new System.Drawing.Size(576, 4);
            this.Panel8.TabIndex = 531;
            // 
            // txttipocomprobante
            // 
            this.txttipocomprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txttipocomprobante.FormattingEnabled = true;
            this.txttipocomprobante.Items.AddRange(new object[] {
            "SIN COMPROBANTE",
            "FACTURA",
            "BOLETA",
            "BOLETO DE VIAJE",
            "TICKET DE FACTURA",
            "Otro"});
            this.txttipocomprobante.Location = new System.Drawing.Point(190, 14);
            this.txttipocomprobante.Margin = new System.Windows.Forms.Padding(4);
            this.txttipocomprobante.Name = "txttipocomprobante";
            this.txttipocomprobante.Size = new System.Drawing.Size(327, 28);
            this.txttipocomprobante.TabIndex = 224;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Label10.Location = new System.Drawing.Point(22, 49);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(158, 20);
            this.Label10.TabIndex = 223;
            this.Label10.Text = "Nro de comprobante:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Label7.Location = new System.Drawing.Point(21, 17);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(163, 20);
            this.Label7.TabIndex = 222;
            this.Label7.Text = "Tipo de comprobante:";
            // 
            // txtnrocomprobante
            // 
            this.txtnrocomprobante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnrocomprobante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnrocomprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtnrocomprobante.Location = new System.Drawing.Point(190, 49);
            this.txtnrocomprobante.Margin = new System.Windows.Forms.Padding(4);
            this.txtnrocomprobante.Name = "txtnrocomprobante";
            this.txtnrocomprobante.Size = new System.Drawing.Size(327, 26);
            this.txtnrocomprobante.TabIndex = 221;
            // 
            // btnComprobante
            // 
            this.btnComprobante.AutoSize = true;
            this.btnComprobante.BackColor = System.Drawing.Color.Transparent;
            this.btnComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.btnComprobante.ForeColor = System.Drawing.Color.Red;
            this.btnComprobante.Location = new System.Drawing.Point(5, 195);
            this.btnComprobante.Margin = new System.Windows.Forms.Padding(4);
            this.btnComprobante.Name = "btnComprobante";
            this.btnComprobante.Size = new System.Drawing.Size(262, 33);
            this.btnComprobante.TabIndex = 471;
            this.btnComprobante.Text = "Sin COMPROBANTE";
            this.btnComprobante.UseVisualStyleBackColor = false;
            this.btnComprobante.CheckedChanged += new System.EventHandler(this.btnComprobante_CheckedChanged);
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
            this.btncerrar.Location = new System.Drawing.Point(11, 14);
            this.btncerrar.Margin = new System.Windows.Forms.Padding(5);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(56, 29);
            this.btncerrar.TabIndex = 620;
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // IngresosVarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelcomprobante);
            this.Controls.Add(this.btnComprobante);
            this.Controls.Add(this.PanelDetalle);
            this.Controls.Add(this.lbltipo);
            this.Name = "IngresosVarios";
            this.Size = new System.Drawing.Size(587, 395);
            this.Load += new System.EventHandler(this.IngresosVarios_Load);
            this.PanelDetalle.ResumeLayout(false);
            this.PanelDetalle.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelcomprobante.ResumeLayout(false);
            this.panelcomprobante.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lbltipo;
        internal System.Windows.Forms.Panel PanelDetalle;
        internal System.Windows.Forms.DateTimePicker txtfecha;
        internal System.Windows.Forms.TextBox txtdetalle;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtimporte;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label TXTACCION;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        internal System.Windows.Forms.Button GuardarRegistro;
        internal System.Windows.Forms.Button btnvolver;
        internal System.Windows.Forms.Panel panelcomprobante;
        internal System.Windows.Forms.Panel Panel8;
        internal System.Windows.Forms.ComboBox txttipocomprobante;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtnrocomprobante;
        internal System.Windows.Forms.CheckBox btnComprobante;
        private System.Windows.Forms.Button btncerrar;
    }
}