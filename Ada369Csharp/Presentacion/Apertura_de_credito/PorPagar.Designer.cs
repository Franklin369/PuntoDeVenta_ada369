namespace Ada369Csharp.Presentacion.Apertura_de_credito
{
    partial class PorPagar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PorPagar));
            this.lblTipo = new System.Windows.Forms.Label();
            this.panelproveedor = new System.Windows.Forms.Panel();
            this.panelcorrdenadas = new System.Windows.Forms.Panel();
            this.datalistado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnagregar = new System.Windows.Forms.Button();
            this.txtdetalle = new System.Windows.Forms.TextBox();
            this.txtsaldo = new System.Windows.Forms.TextBox();
            this.txtproveedor = new System.Windows.Forms.TextBox();
            this.panelCREDITOS = new System.Windows.Forms.Panel();
            this.radiocredito = new System.Windows.Forms.RadioButton();
            this.radiocontado = new System.Windows.Forms.RadioButton();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label41 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_fechasoka = new System.Windows.Forms.Panel();
            this.txtfecha_de_pago = new System.Windows.Forms.DateTimePicker();
            this.Label21 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtfechadeventa = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.panelproveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado)).BeginInit();
            this.panelCREDITOS.SuspendLayout();
            this.panel_fechasoka.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTipo
            // 
            this.lblTipo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblTipo.ForeColor = System.Drawing.Color.Black;
            this.lblTipo.Location = new System.Drawing.Point(0, 0);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(470, 46);
            this.lblTipo.TabIndex = 531;
            this.lblTipo.Text = "Por pagar";
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelproveedor
            // 
            this.panelproveedor.BackColor = System.Drawing.Color.White;
            this.panelproveedor.Controls.Add(this.panelcorrdenadas);
            this.panelproveedor.Controls.Add(this.datalistado);
            this.panelproveedor.Controls.Add(this.btnagregar);
            this.panelproveedor.Controls.Add(this.txtdetalle);
            this.panelproveedor.Controls.Add(this.txtsaldo);
            this.panelproveedor.Controls.Add(this.txtproveedor);
            this.panelproveedor.Controls.Add(this.panelCREDITOS);
            this.panelproveedor.Controls.Add(this.Label5);
            this.panelproveedor.Controls.Add(this.Label41);
            this.panelproveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelproveedor.Location = new System.Drawing.Point(10, 46);
            this.panelproveedor.Margin = new System.Windows.Forms.Padding(4);
            this.panelproveedor.Name = "panelproveedor";
            this.panelproveedor.Size = new System.Drawing.Size(450, 154);
            this.panelproveedor.TabIndex = 535;
            this.panelproveedor.Paint += new System.Windows.Forms.PaintEventHandler(this.PANELCLIENTE_Paint);
            // 
            // panelcorrdenadas
            // 
            this.panelcorrdenadas.Location = new System.Drawing.Point(10, 35);
            this.panelcorrdenadas.Margin = new System.Windows.Forms.Padding(4);
            this.panelcorrdenadas.Name = "panelcorrdenadas";
            this.panelcorrdenadas.Size = new System.Drawing.Size(10, 9);
            this.panelcorrdenadas.TabIndex = 508;
            // 
            // datalistado
            // 
            this.datalistado.AllowUserToAddRows = false;
            this.datalistado.AllowUserToDeleteRows = false;
            this.datalistado.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.datalistado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datalistado.BackgroundColor = System.Drawing.Color.White;
            this.datalistado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datalistado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.datalistado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistado.ColumnHeadersVisible = false;
            this.datalistado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.datalistado.EnableHeadersVisualStyles = false;
            this.datalistado.Location = new System.Drawing.Point(404, 35);
            this.datalistado.Margin = new System.Windows.Forms.Padding(4);
            this.datalistado.Name = "datalistado";
            this.datalistado.ReadOnly = true;
            this.datalistado.RowHeadersVisible = false;
            this.datalistado.RowHeadersWidth = 9;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            this.datalistado.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.datalistado.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.datalistado.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.datalistado.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.datalistado.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.datalistado.RowTemplate.Height = 40;
            this.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalistado.Size = new System.Drawing.Size(23, 105);
            this.datalistado.TabIndex = 507;
            this.datalistado.Visible = false;
            this.datalistado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datalistado_CellClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.Visible = false;
            // 
            // btnagregar
            // 
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Location = new System.Drawing.Point(358, 5);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(24, 24);
            this.btnagregar.TabIndex = 506;
            this.btnagregar.Text = "+";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // txtdetalle
            // 
            this.txtdetalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtdetalle.Location = new System.Drawing.Point(140, 87);
            this.txtdetalle.Margin = new System.Windows.Forms.Padding(4);
            this.txtdetalle.Multiline = true;
            this.txtdetalle.Name = "txtdetalle";
            this.txtdetalle.Size = new System.Drawing.Size(272, 52);
            this.txtdetalle.TabIndex = 505;
            // 
            // txtsaldo
            // 
            this.txtsaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtsaldo.Location = new System.Drawing.Point(140, 48);
            this.txtsaldo.Margin = new System.Windows.Forms.Padding(4);
            this.txtsaldo.Name = "txtsaldo";
            this.txtsaldo.Size = new System.Drawing.Size(136, 24);
            this.txtsaldo.TabIndex = 505;
            this.txtsaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsaldo_KeyPress);
            // 
            // txtproveedor
            // 
            this.txtproveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtproveedor.Location = new System.Drawing.Point(10, 6);
            this.txtproveedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtproveedor.Name = "txtproveedor";
            this.txtproveedor.Size = new System.Drawing.Size(342, 23);
            this.txtproveedor.TabIndex = 455;
            this.txtproveedor.Click += new System.EventHandler(this.txtproveedor_Click);
            this.txtproveedor.TextChanged += new System.EventHandler(this.txtproveedor_TextChanged);
            // 
            // panelCREDITOS
            // 
            this.panelCREDITOS.Controls.Add(this.radiocredito);
            this.panelCREDITOS.Controls.Add(this.radiocontado);
            this.panelCREDITOS.Controls.Add(this.Label2);
            this.panelCREDITOS.Location = new System.Drawing.Point(300, 8);
            this.panelCREDITOS.Margin = new System.Windows.Forms.Padding(4);
            this.panelCREDITOS.Name = "panelCREDITOS";
            this.panelCREDITOS.Size = new System.Drawing.Size(10, 9);
            this.panelCREDITOS.TabIndex = 451;
            // 
            // radiocredito
            // 
            this.radiocredito.AutoSize = true;
            this.radiocredito.Checked = true;
            this.radiocredito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radiocredito.Location = new System.Drawing.Point(88, 17);
            this.radiocredito.Margin = new System.Windows.Forms.Padding(4);
            this.radiocredito.Name = "radiocredito";
            this.radiocredito.Size = new System.Drawing.Size(58, 17);
            this.radiocredito.TabIndex = 445;
            this.radiocredito.TabStop = true;
            this.radiocredito.Text = "Credito";
            this.radiocredito.UseVisualStyleBackColor = true;
            // 
            // radiocontado
            // 
            this.radiocontado.AutoSize = true;
            this.radiocontado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radiocontado.Location = new System.Drawing.Point(2, 17);
            this.radiocontado.Margin = new System.Windows.Forms.Padding(4);
            this.radiocontado.Name = "radiocontado";
            this.radiocontado.Size = new System.Drawing.Size(65, 17);
            this.radiocontado.TabIndex = 445;
            this.radiocontado.TabStop = true;
            this.radiocontado.Text = "Contado";
            this.radiocontado.UseVisualStyleBackColor = true;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(4, 0);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(96, 17);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Tipo de pago:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Black;
            this.Label5.Location = new System.Drawing.Point(80, 50);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(54, 17);
            this.Label5.TabIndex = 0;
            this.Label5.Text = "Saldo:";
            // 
            // Label41
            // 
            this.Label41.AutoSize = true;
            this.Label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label41.ForeColor = System.Drawing.Color.Black;
            this.Label41.Location = new System.Drawing.Point(70, 87);
            this.Label41.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label41.Name = "Label41";
            this.Label41.Size = new System.Drawing.Size(64, 17);
            this.Label41.TabIndex = 0;
            this.Label41.Text = "Detalle:";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 283);
            this.panel1.TabIndex = 536;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(460, 46);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 283);
            this.panel2.TabIndex = 537;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 200);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 9);
            this.panel3.TabIndex = 538;
            // 
            // panel_fechasoka
            // 
            this.panel_fechasoka.BackColor = System.Drawing.Color.White;
            this.panel_fechasoka.Controls.Add(this.txtfecha_de_pago);
            this.panel_fechasoka.Controls.Add(this.Label21);
            this.panel_fechasoka.Controls.Add(this.Label7);
            this.panel_fechasoka.Controls.Add(this.txtfechadeventa);
            this.panel_fechasoka.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_fechasoka.Location = new System.Drawing.Point(10, 209);
            this.panel_fechasoka.Margin = new System.Windows.Forms.Padding(4);
            this.panel_fechasoka.Name = "panel_fechasoka";
            this.panel_fechasoka.Size = new System.Drawing.Size(450, 52);
            this.panel_fechasoka.TabIndex = 540;
            // 
            // txtfecha_de_pago
            // 
            this.txtfecha_de_pago.Checked = false;
            this.txtfecha_de_pago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfecha_de_pago.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtfecha_de_pago.Location = new System.Drawing.Point(270, 19);
            this.txtfecha_de_pago.Margin = new System.Windows.Forms.Padding(4);
            this.txtfecha_de_pago.Name = "txtfecha_de_pago";
            this.txtfecha_de_pago.Size = new System.Drawing.Size(98, 23);
            this.txtfecha_de_pago.TabIndex = 447;
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label21.ForeColor = System.Drawing.Color.Black;
            this.Label21.Location = new System.Drawing.Point(204, 20);
            this.Label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(60, 17);
            this.Label21.TabIndex = 0;
            this.Label21.Text = "F. Venc:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.Black;
            this.Label7.Location = new System.Drawing.Point(14, 18);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(74, 17);
            this.Label7.TabIndex = 0;
            this.Label7.Text = "F. de Reg:";
            // 
            // txtfechadeventa
            // 
            this.txtfechadeventa.Checked = false;
            this.txtfechadeventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfechadeventa.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtfechadeventa.Location = new System.Drawing.Point(103, 18);
            this.txtfechadeventa.Margin = new System.Windows.Forms.Padding(4);
            this.txtfechadeventa.Name = "txtfechadeventa";
            this.txtfechadeventa.Size = new System.Drawing.Size(95, 23);
            this.txtfechadeventa.TabIndex = 447;
            this.txtfechadeventa.ValueChanged += new System.EventHandler(this.txtfechadeventa_ValueChanged);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(10, 261);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(88, 68);
            this.panel4.TabIndex = 541;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(372, 261);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(88, 68);
            this.panel5.TabIndex = 542;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(98, 261);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(274, 9);
            this.panel6.TabIndex = 543;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(98, 320);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(274, 9);
            this.panel7.TabIndex = 544;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(1)))));
            this.btnRegistrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(98, 270);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(274, 50);
            this.btnRegistrar.TabIndex = 545;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // PorPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 329);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel_fechasoka);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelproveedor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTipo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PorPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PorPagar";
            this.Load += new System.EventHandler(this.PorPagar_Load);
            this.panelproveedor.ResumeLayout(false);
            this.panelproveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado)).EndInit();
            this.panelCREDITOS.ResumeLayout(false);
            this.panelCREDITOS.PerformLayout();
            this.panel_fechasoka.ResumeLayout(false);
            this.panel_fechasoka.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label lblTipo;
        internal System.Windows.Forms.Panel panelproveedor;
        private System.Windows.Forms.Button btnagregar;
        internal System.Windows.Forms.TextBox txtdetalle;
        internal System.Windows.Forms.TextBox txtsaldo;
        internal System.Windows.Forms.TextBox txtproveedor;
        internal System.Windows.Forms.Panel panelCREDITOS;
        internal System.Windows.Forms.RadioButton radiocredito;
        internal System.Windows.Forms.RadioButton radiocontado;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label41;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Panel panel_fechasoka;
        internal System.Windows.Forms.DateTimePicker txtfecha_de_pago;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.DateTimePicker txtfechadeventa;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnRegistrar;
        internal System.Windows.Forms.DataGridView datalistado;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.Panel panelcorrdenadas;
    }
}