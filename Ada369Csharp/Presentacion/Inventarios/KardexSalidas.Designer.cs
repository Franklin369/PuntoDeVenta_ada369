namespace Ada369Csharp.Presentacion.INVENTARIOS_KARDEX
{
    partial class KardexSalidas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.dgproductos = new System.Windows.Forms.DataGridView();
            this.Label24 = new System.Windows.Forms.Label();
            this.ComboBox3 = new System.Windows.Forms.ComboBox();
            this.txtcmotivo = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.btn_insertar = new System.Windows.Forms.Button();
            this.txtfecha = new System.Windows.Forms.DateTimePicker();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.Label44 = new System.Windows.Forms.Label();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.Label41 = new System.Windows.Forms.Label();
            this.btncerrar = new System.Windows.Forms.Button();
            this.Panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgproductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(44, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 54);
            this.label1.TabIndex = 549;
            this.label1.Text = "SALIDA DE PRODUCTO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel5
            // 
            this.Panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Panel5.Controls.Add(this.dgproductos);
            this.Panel5.Controls.Add(this.Label24);
            this.Panel5.Controls.Add(this.ComboBox3);
            this.Panel5.Controls.Add(this.txtcmotivo);
            this.Panel5.Controls.Add(this.Label7);
            this.Panel5.Controls.Add(this.btn_insertar);
            this.Panel5.Controls.Add(this.txtfecha);
            this.Panel5.Controls.Add(this.txtcantidad);
            this.Panel5.Controls.Add(this.Label5);
            this.Panel5.Controls.Add(this.txtbuscar);
            this.Panel5.Controls.Add(this.Label44);
            this.Panel5.Controls.Add(this.ComboBox1);
            this.Panel5.Controls.Add(this.Label41);
            this.Panel5.Location = new System.Drawing.Point(44, 78);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(584, 400);
            this.Panel5.TabIndex = 548;
            // 
            // dgproductos
            // 
            this.dgproductos.AllowUserToAddRows = false;
            this.dgproductos.AllowUserToDeleteRows = false;
            this.dgproductos.AllowUserToResizeRows = false;
            this.dgproductos.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgproductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgproductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgproductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgproductos.ColumnHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgproductos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgproductos.EnableHeadersVisualStyles = false;
            this.dgproductos.Location = new System.Drawing.Point(536, 119);
            this.dgproductos.Name = "dgproductos";
            this.dgproductos.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgproductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgproductos.RowHeadersVisible = false;
            this.dgproductos.RowHeadersWidth = 5;
            this.dgproductos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            this.dgproductos.RowTemplate.Height = 33;
            this.dgproductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgproductos.Size = new System.Drawing.Size(28, 40);
            this.dgproductos.TabIndex = 488;
            this.dgproductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatalistadoProductos_CellClick);
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.Location = new System.Drawing.Point(595, 301);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(39, 13);
            this.Label24.TabIndex = 508;
            this.Label24.Text = "Label1";
            // 
            // ComboBox3
            // 
            this.ComboBox3.FormattingEnabled = true;
            this.ComboBox3.Location = new System.Drawing.Point(587, 267);
            this.ComboBox3.Name = "ComboBox3";
            this.ComboBox3.Size = new System.Drawing.Size(158, 21);
            this.ComboBox3.TabIndex = 509;
            // 
            // txtcmotivo
            // 
            this.txtcmotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtcmotivo.Location = new System.Drawing.Point(168, 245);
            this.txtcmotivo.Multiline = true;
            this.txtcmotivo.Name = "txtcmotivo";
            this.txtcmotivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtcmotivo.Size = new System.Drawing.Size(360, 52);
            this.txtcmotivo.TabIndex = 505;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Label7.ForeColor = System.Drawing.Color.Black;
            this.Label7.Location = new System.Drawing.Point(61, 209);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(102, 25);
            this.Label7.TabIndex = 0;
            this.Label7.Text = "F. de Reg:";
            // 
            // btn_insertar
            // 
            this.btn_insertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(1)))));
            this.btn_insertar.FlatAppearance.BorderSize = 0;
            this.btn_insertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_insertar.ForeColor = System.Drawing.Color.Black;
            this.btn_insertar.Location = new System.Drawing.Point(168, 303);
            this.btn_insertar.Name = "btn_insertar";
            this.btn_insertar.Size = new System.Drawing.Size(362, 44);
            this.btn_insertar.TabIndex = 527;
            this.btn_insertar.Text = "+ GUARDAR ";
            this.btn_insertar.UseVisualStyleBackColor = false;
            this.btn_insertar.Click += new System.EventHandler(this.btn_insertar_Click);
            // 
            // txtfecha
            // 
            this.txtfecha.Checked = false;
            this.txtfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtfecha.Location = new System.Drawing.Point(168, 209);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(152, 30);
            this.txtfecha.TabIndex = 447;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtcantidad.Location = new System.Drawing.Point(168, 150);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(182, 38);
            this.txtcantidad.TabIndex = 492;
            this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtagregar_KeyPress);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Label5.ForeColor = System.Drawing.Color.Black;
            this.Label5.Location = new System.Drawing.Point(7, 148);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(163, 39);
            this.Label5.TabIndex = 491;
            this.Label5.Text = "Cantidad:";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtbuscar.Location = new System.Drawing.Point(13, 66);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(551, 35);
            this.txtbuscar.TabIndex = 490;
            this.txtbuscar.TextChanged += new System.EventHandler(this.TXTBUSCARProducto_TextChanged);
            // 
            // Label44
            // 
            this.Label44.AutoSize = true;
            this.Label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Label44.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label44.Location = new System.Drawing.Point(10, 41);
            this.Label44.Name = "Label44";
            this.Label44.Size = new System.Drawing.Size(153, 24);
            this.Label44.TabIndex = 489;
            this.Label44.Text = "Buscar producto:";
            // 
            // ComboBox1
            // 
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Location = new System.Drawing.Point(168, 71);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(117, 21);
            this.ComboBox1.TabIndex = 497;
            // 
            // Label41
            // 
            this.Label41.AutoSize = true;
            this.Label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Label41.ForeColor = System.Drawing.Color.Black;
            this.Label41.Location = new System.Drawing.Point(87, 261);
            this.Label41.Name = "Label41";
            this.Label41.Size = new System.Drawing.Size(76, 25);
            this.Label41.TabIndex = 0;
            this.Label41.Text = "Motivo:";
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
            this.btncerrar.Location = new System.Drawing.Point(16, 21);
            this.btncerrar.Margin = new System.Windows.Forms.Padding(5);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(56, 29);
            this.btncerrar.TabIndex = 618;
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // KardexSalidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Panel5);
            this.Name = "KardexSalidas";
            this.Size = new System.Drawing.Size(667, 512);
            this.Load += new System.EventHandler(this.KardexSalidas_Load);
            this.Panel5.ResumeLayout(false);
            this.Panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgproductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Panel Panel5;
        internal System.Windows.Forms.DataGridView dgproductos;
        internal System.Windows.Forms.Label Label24;
        internal System.Windows.Forms.ComboBox ComboBox3;
        internal System.Windows.Forms.TextBox txtcmotivo;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Button btn_insertar;
        internal System.Windows.Forms.DateTimePicker txtfecha;
        internal System.Windows.Forms.TextBox txtcantidad;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtbuscar;
        internal System.Windows.Forms.Label Label44;
        internal System.Windows.Forms.ComboBox ComboBox1;
        internal System.Windows.Forms.Label Label41;
        private System.Windows.Forms.Button btncerrar;
    }
}