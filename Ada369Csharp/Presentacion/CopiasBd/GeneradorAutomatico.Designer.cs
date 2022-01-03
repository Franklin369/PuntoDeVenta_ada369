namespace Ada369Csharp.Presentacion.CopiasBd
{
    partial class GeneradorAutomatico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneradorAutomatico));
            this.Panel12 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.lbltiempo = new System.Windows.Forms.Label();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripButton22 = new System.Windows.Forms.ToolStripButton();
            this.btncancelar = new System.Windows.Forms.Button();
            this.Pcargando = new System.Windows.Forms.PictureBox();
            this.timerContador = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Panel12.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pcargando)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel12
            // 
            this.Panel12.BackColor = System.Drawing.Color.White;
            this.Panel12.Controls.Add(this.Label1);
            this.Panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel12.Location = new System.Drawing.Point(0, 0);
            this.Panel12.Name = "Panel12";
            this.Panel12.Size = new System.Drawing.Size(491, 45);
            this.Panel12.TabIndex = 613;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.Label1.Location = new System.Drawing.Point(3, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(193, 24);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Copia de seguridad";
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.lbltiempo);
            this.Panel1.Controls.Add(this.txtRuta);
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.ToolStrip1);
            this.Panel1.Controls.Add(this.btncancelar);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 45);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(491, 260);
            this.Panel1.TabIndex = 615;
            // 
            // lbltiempo
            // 
            this.lbltiempo.AutoSize = true;
            this.lbltiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.lbltiempo.Location = new System.Drawing.Point(191, 62);
            this.lbltiempo.Name = "lbltiempo";
            this.lbltiempo.Size = new System.Drawing.Size(107, 76);
            this.lbltiempo.TabIndex = 599;
            this.lbltiempo.Text = "10";
            // 
            // txtRuta
            // 
            this.txtRuta.BackColor = System.Drawing.Color.White;
            this.txtRuta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtRuta.Enabled = false;
            this.txtRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRuta.Location = new System.Drawing.Point(62, 225);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(405, 26);
            this.txtRuta.TabIndex = 1;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.White;
            this.Label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.Label4.Location = new System.Drawing.Point(50, 14);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(388, 48);
            this.Label4.TabIndex = 0;
            this.Label4.Text = "SE GENERARA COPIA DE SEGURIDAD \r\nPROGRAMADA EN:";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.White;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Label2.Location = new System.Drawing.Point(58, 198);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(218, 20);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Ruta de Copias de Seguridad";
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.AutoSize = false;
            this.ToolStrip1.BackColor = System.Drawing.Color.White;
            this.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButton22});
            this.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.ToolStrip1.Location = new System.Drawing.Point(20, 186);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ToolStrip1.Size = new System.Drawing.Size(72, 49);
            this.ToolStrip1.TabIndex = 595;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // ToolStripButton22
            // 
            this.ToolStripButton22.BackColor = System.Drawing.Color.White;
            this.ToolStripButton22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ToolStripButton22.ForeColor = System.Drawing.Color.Black;
            this.ToolStripButton22.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton22.Image")));
            this.ToolStripButton22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolStripButton22.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton22.Name = "ToolStripButton22";
            this.ToolStripButton22.Size = new System.Drawing.Size(37, 46);
            this.ToolStripButton22.Text = "+";
            this.ToolStripButton22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolStripButton22.ToolTipText = "Buscar Ruta";
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.Transparent;
            this.btncancelar.BackgroundImage = global::Ada369Csharp.Properties.Resources.naranja;
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btncancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(165, 140);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(133, 43);
            this.btncancelar.TabIndex = 2;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // Pcargando
            // 
            this.Pcargando.Image = ((System.Drawing.Image)(resources.GetObject("Pcargando.Image")));
            this.Pcargando.Location = new System.Drawing.Point(144, 326);
            this.Pcargando.Name = "Pcargando";
            this.Pcargando.Size = new System.Drawing.Size(190, 113);
            this.Pcargando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pcargando.TabIndex = 616;
            this.Pcargando.TabStop = false;
            this.Pcargando.Visible = false;
            // 
            // timerContador
            // 
            this.timerContador.Interval = 1000;
            this.timerContador.Tick += new System.EventHandler(this.timerContador_Tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GeneradorAutomatico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(491, 451);
            this.Controls.Add(this.Pcargando);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Panel12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GeneradorAutomatico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GeneradorAutomatico_FormClosing);
            this.Load += new System.EventHandler(this.GeneradorAutomatico_Load);
            this.Panel12.ResumeLayout(false);
            this.Panel12.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pcargando)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel12;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label lbltiempo;
        internal System.Windows.Forms.TextBox txtRuta;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton ToolStripButton22;
        internal System.Windows.Forms.Button btncancelar;
        internal System.Windows.Forms.PictureBox Pcargando;
        private System.Windows.Forms.Timer timerContador;
        private System.Windows.Forms.Timer timer1;
    }
}