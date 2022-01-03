namespace Ada369Csharp.Presentacion.Configuraciones
{
    partial class BalanzaForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BalanzaForm));
            this.uI_ShadowPanel1 = new UIDC.UI_ShadowPanel();
            this.btnenviar = new System.Windows.Forms.Button();
            this.lblestado = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProbar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ListaPuertos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.puertos = new System.IO.Ports.SerialPort(this.components);
            this.uI_ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uI_ShadowPanel1
            // 
            this.uI_ShadowPanel1.AddControl = null;
            this.uI_ShadowPanel1.Controls.Add(this.btnenviar);
            this.uI_ShadowPanel1.Controls.Add(this.lblestado);
            this.uI_ShadowPanel1.Controls.Add(this.pictureBox4);
            this.uI_ShadowPanel1.Controls.Add(this.pictureBox3);
            this.uI_ShadowPanel1.Controls.Add(this.btnguardar);
            this.uI_ShadowPanel1.Controls.Add(this.label5);
            this.uI_ShadowPanel1.Controls.Add(this.txtresultado);
            this.uI_ShadowPanel1.Controls.Add(this.label1);
            this.uI_ShadowPanel1.Controls.Add(this.btnProbar);
            this.uI_ShadowPanel1.Controls.Add(this.label4);
            this.uI_ShadowPanel1.Controls.Add(this.pictureBox2);
            this.uI_ShadowPanel1.Controls.Add(this.panel2);
            this.uI_ShadowPanel1.Controls.Add(this.panel1);
            this.uI_ShadowPanel1.Controls.Add(this.ListaPuertos);
            this.uI_ShadowPanel1.Controls.Add(this.label2);
            this.uI_ShadowPanel1.Controls.Add(this.label3);
            this.uI_ShadowPanel1.Controls.Add(this.pictureBox1);
            this.uI_ShadowPanel1.Controls.Add(this.Label14);
            this.uI_ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uI_ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.uI_ShadowPanel1.Name = "uI_ShadowPanel1";
            this.uI_ShadowPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.uI_ShadowPanel1.Size = new System.Drawing.Size(832, 423);
            this.uI_ShadowPanel1.SizeShadow = 10;
            this.uI_ShadowPanel1.TabIndex = 0;
            this.uI_ShadowPanel1.TypeShadowPanel = UIDC.UI_ShadowPanel.ShadowsPanel.Center;
            // 
            // btnenviar
            // 
            this.btnenviar.Location = new System.Drawing.Point(532, 348);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(149, 46);
            this.btnenviar.TabIndex = 629;
            this.btnenviar.Text = "Enviar";
            this.btnenviar.UseVisualStyleBackColor = true;
            this.btnenviar.Visible = false;
            this.btnenviar.Click += new System.EventHandler(this.btnenviar_Click);
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.BackColor = System.Drawing.Color.Transparent;
            this.lblestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lblestado.ForeColor = System.Drawing.Color.DimGray;
            this.lblestado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblestado.Location = new System.Drawing.Point(437, 27);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(28, 25);
            this.lblestado.TabIndex = 612;
            this.lblestado.Text = "--";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Ada369Csharp.Properties.Resources.tres;
            this.pictureBox4.Location = new System.Drawing.Point(715, 283);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 67);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 628;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Ada369Csharp.Properties.Resources.dos;
            this.pictureBox3.Location = new System.Drawing.Point(715, 173);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 67);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 627;
            this.pictureBox3.TabStop = false;
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.Transparent;
            this.btnguardar.BackgroundImage = global::Ada369Csharp.Properties.Resources.rosa;
            this.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnguardar.FlatAppearance.BorderSize = 0;
            this.btnguardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnguardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Location = new System.Drawing.Point(318, 347);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(134, 47);
            this.btnguardar.TabIndex = 626;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(255, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(339, 40);
            this.label5.TabIndex = 625;
            this.label5.Text = "Paso 3: Si ya reconoce el peso, entonces\r\nde click a *Guardar*";
            // 
            // txtresultado
            // 
            this.txtresultado.BackColor = System.Drawing.Color.Black;
            this.txtresultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtresultado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtresultado.Enabled = false;
            this.txtresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.txtresultado.ForeColor = System.Drawing.Color.Red;
            this.txtresultado.Location = new System.Drawing.Point(516, 204);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(155, 38);
            this.txtresultado.TabIndex = 624;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(458, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 623;
            this.label1.Text = "Peso:";
            // 
            // btnProbar
            // 
            this.btnProbar.BackColor = System.Drawing.Color.Transparent;
            this.btnProbar.BackgroundImage = global::Ada369Csharp.Properties.Resources.azul;
            this.btnProbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProbar.FlatAppearance.BorderSize = 0;
            this.btnProbar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnProbar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnProbar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProbar.ForeColor = System.Drawing.Color.White;
            this.btnProbar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProbar.Location = new System.Drawing.Point(318, 203);
            this.btnProbar.Name = "btnProbar";
            this.btnProbar.Size = new System.Drawing.Size(134, 47);
            this.btnProbar.TabIndex = 622;
            this.btnProbar.Text = "Probar";
            this.btnProbar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProbar.UseVisualStyleBackColor = false;
            this.btnProbar.Click += new System.EventHandler(this.btnProbar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(252, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(419, 20);
            this.label4.TabIndex = 621;
            this.label4.Text = "Paso 1: Conecte su balanza y seleccione un Puerto";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Ada369Csharp.Properties.Resources.uno;
            this.pictureBox2.Location = new System.Drawing.Point(715, 61);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 620;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(252, 265);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(527, 1);
            this.panel2.TabIndex = 619;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(252, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 1);
            this.panel1.TabIndex = 619;
            // 
            // ListaPuertos
            // 
            this.ListaPuertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaPuertos.FormattingEnabled = true;
            this.ListaPuertos.Location = new System.Drawing.Point(421, 104);
            this.ListaPuertos.Name = "ListaPuertos";
            this.ListaPuertos.Size = new System.Drawing.Size(159, 28);
            this.ListaPuertos.TabIndex = 616;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(333, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 612;
            this.label2.Text = "Puerto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(252, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 20);
            this.label3.TabIndex = 611;
            this.label3.Text = "Paso 1: Elija un Puerto y de click a Probar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Ada369Csharp.Properties.Resources._6030;
            this.pictureBox1.Location = new System.Drawing.Point(10, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 350);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 194;
            this.pictureBox1.TabStop = false;
            // 
            // Label14
            // 
            this.Label14.BackColor = System.Drawing.Color.Transparent;
            this.Label14.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.Label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label14.Location = new System.Drawing.Point(10, 10);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(812, 53);
            this.Label14.TabIndex = 193;
            this.Label14.Text = "Configurar Balanza Electronica";
            this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // puertos
            // 
            this.puertos.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.puertos_DataReceived);
            // 
            // BalanzaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(832, 423);
            this.Controls.Add(this.uI_ShadowPanel1);
            this.Name = "BalanzaForm";
            this.Load += new System.EventHandler(this.BalanzaForm_Load);
            this.uI_ShadowPanel1.ResumeLayout(false);
            this.uI_ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UIDC.UI_ShadowPanel uI_ShadowPanel1;
        internal System.Windows.Forms.Label Label14;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ListaPuertos;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProbar;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnguardar;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.IO.Ports.SerialPort puertos;
        internal System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.Button btnenviar;
    }
}