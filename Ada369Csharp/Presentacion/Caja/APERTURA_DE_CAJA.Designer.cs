namespace Ada369Csharp.Presentacion.CAJA
{
    partial class APERTURA_DE_CAJA
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
            this.PanelCaja = new System.Windows.Forms.Panel();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtmonto = new System.Windows.Forms.TextBox();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnguardar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnomitir = new System.Windows.Forms.ToolStripMenuItem();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PanelCaja.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelCaja
            // 
            this.PanelCaja.BackColor = System.Drawing.Color.White;
            this.PanelCaja.Controls.Add(this.Panel2);
            this.PanelCaja.Controls.Add(this.txtmonto);
            this.PanelCaja.Controls.Add(this.MenuStrip1);
            this.PanelCaja.Controls.Add(this.Label9);
            this.PanelCaja.Controls.Add(this.Label1);
            this.PanelCaja.Location = new System.Drawing.Point(34, 42);
            this.PanelCaja.Name = "PanelCaja";
            this.PanelCaja.Size = new System.Drawing.Size(408, 239);
            this.PanelCaja.TabIndex = 566;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.White;
            this.Panel2.Controls.Add(this.Label2);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel2.Location = new System.Drawing.Point(0, 0);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(408, 59);
            this.Panel2.TabIndex = 565;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(0, 0);
            this.Label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(408, 59);
            this.Label2.TabIndex = 532;
            this.Label2.Text = "Dinero en Caja";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtmonto
            // 
            this.txtmonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtmonto.Location = new System.Drawing.Point(45, 131);
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.Size = new System.Drawing.Size(284, 30);
            this.txtmonto.TabIndex = 564;
            this.txtmonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmonto_KeyPress);
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.AutoSize = false;
            this.MenuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnguardar,
            this.btnomitir});
            this.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MenuStrip1.Location = new System.Drawing.Point(45, 164);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.ShowItemToolTips = true;
            this.MenuStrip1.Size = new System.Drawing.Size(216, 43);
            this.MenuStrip1.TabIndex = 562;
            this.MenuStrip1.Text = "MenuStrip7";
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(63)))), ((int)(((byte)(67)))));
            this.btnguardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(70, 39);
            this.btnguardar.Text = "Iniciar";
            this.btnguardar.ToolTipText = "Iniciar";
            this.btnguardar.Click += new System.EventHandler(this.ToolStripMenuItem2_Click);
            // 
            // btnomitir
            // 
            this.btnomitir.BackColor = System.Drawing.Color.White;
            this.btnomitir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnomitir.ForeColor = System.Drawing.Color.Black;
            this.btnomitir.Name = "btnomitir";
            this.btnomitir.Size = new System.Drawing.Size(71, 39);
            this.btnomitir.Text = "Omitir";
            this.btnomitir.ToolTipText = "Omitir";
            this.btnomitir.Click += new System.EventHandler(this.btnomitir_Click);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.ForeColor = System.Drawing.Color.Black;
            this.Label9.Location = new System.Drawing.Point(12, 75);
            this.Label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(0, 13);
            this.Label9.TabIndex = 533;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(27, 95);
            this.Label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(317, 31);
            this.Label1.TabIndex = 511;
            this.Label1.Text = "¿Efectivo inicial en Caja?";
            // 
            // APERTURA_DE_CAJA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PanelCaja);
            this.Name = "APERTURA_DE_CAJA";
            this.Size = new System.Drawing.Size(463, 301);
            this.Load += new System.EventHandler(this.APERTURA_DE_CAJA_Load);
            this.PanelCaja.ResumeLayout(false);
            this.PanelCaja.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel PanelCaja;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtmonto;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem btnguardar;
        internal System.Windows.Forms.ToolStripMenuItem btnomitir;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Timer timer1;
    }
}