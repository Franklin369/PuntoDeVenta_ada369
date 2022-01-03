
namespace Ada369Csharp.Presentacion.Menu
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelbotones = new System.Windows.Forms.FlowLayoutPanel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnLicencia = new System.Windows.Forms.Button();
            this.PanelLicencia = new System.Windows.Forms.Panel();
            this.lblestadoLicencia = new System.Windows.Forms.Label();
            this.PictureBox16 = new System.Windows.Forms.PictureBox();
            this.PictureBox9 = new System.Windows.Forms.PictureBox();
            this.Label66 = new System.Windows.Forms.Label();
            this.panelVisor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel13.SuspendLayout();
            this.PanelLicencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panel1.Controls.Add(this.panelbotones);
            this.panel1.Controls.Add(this.panel13);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 527);
            this.panel1.TabIndex = 3;
            // 
            // panelbotones
            // 
            this.panelbotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelbotones.Location = new System.Drawing.Point(0, 138);
            this.panelbotones.Name = "panelbotones";
            this.panelbotones.Size = new System.Drawing.Size(200, 389);
            this.panelbotones.TabIndex = 1;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.btnLicencia);
            this.panel13.Controls.Add(this.PanelLicencia);
            this.panel13.Controls.Add(this.PictureBox9);
            this.panel13.Controls.Add(this.Label66);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(200, 138);
            this.panel13.TabIndex = 631;
            // 
            // btnLicencia
            // 
            this.btnLicencia.BackColor = System.Drawing.Color.Transparent;
            this.btnLicencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLicencia.FlatAppearance.BorderSize = 0;
            this.btnLicencia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLicencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLicencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLicencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLicencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLicencia.Location = new System.Drawing.Point(6, 62);
            this.btnLicencia.Name = "btnLicencia";
            this.btnLicencia.Size = new System.Drawing.Size(156, 28);
            this.btnLicencia.TabIndex = 608;
            this.btnLicencia.Text = "Activar Licencia";
            this.btnLicencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLicencia.UseVisualStyleBackColor = false;
            this.btnLicencia.Click += new System.EventHandler(this.btnLicencia_Click);
            // 
            // PanelLicencia
            // 
            this.PanelLicencia.Controls.Add(this.lblestadoLicencia);
            this.PanelLicencia.Controls.Add(this.PictureBox16);
            this.PanelLicencia.Location = new System.Drawing.Point(6, 89);
            this.PanelLicencia.Margin = new System.Windows.Forms.Padding(10);
            this.PanelLicencia.Name = "PanelLicencia";
            this.PanelLicencia.Size = new System.Drawing.Size(194, 46);
            this.PanelLicencia.TabIndex = 603;
            // 
            // lblestadoLicencia
            // 
            this.lblestadoLicencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblestadoLicencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblestadoLicencia.ForeColor = System.Drawing.Color.Gray;
            this.lblestadoLicencia.Location = new System.Drawing.Point(22, 0);
            this.lblestadoLicencia.Name = "lblestadoLicencia";
            this.lblestadoLicencia.Size = new System.Drawing.Size(172, 46);
            this.lblestadoLicencia.TabIndex = 603;
            this.lblestadoLicencia.Text = "Licencia de prueba activada hasta el 02 agosto 2023";
            this.lblestadoLicencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PictureBox16
            // 
            this.PictureBox16.Dock = System.Windows.Forms.DockStyle.Left;
            this.PictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox16.Image")));
            this.PictureBox16.Location = new System.Drawing.Point(0, 0);
            this.PictureBox16.Margin = new System.Windows.Forms.Padding(10);
            this.PictureBox16.Name = "PictureBox16";
            this.PictureBox16.Size = new System.Drawing.Size(22, 46);
            this.PictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox16.TabIndex = 602;
            this.PictureBox16.TabStop = false;
            // 
            // PictureBox9
            // 
            this.PictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox9.Image")));
            this.PictureBox9.Location = new System.Drawing.Point(6, 12);
            this.PictureBox9.Name = "PictureBox9";
            this.PictureBox9.Size = new System.Drawing.Size(52, 44);
            this.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox9.TabIndex = 607;
            this.PictureBox9.TabStop = false;
            // 
            // Label66
            // 
            this.Label66.AutoSize = true;
            this.Label66.BackColor = System.Drawing.Color.Transparent;
            this.Label66.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.Label66.ForeColor = System.Drawing.Color.White;
            this.Label66.Location = new System.Drawing.Point(64, 24);
            this.Label66.Name = "Label66";
            this.Label66.Size = new System.Drawing.Size(126, 19);
            this.Label66.TabIndex = 600;
            this.Label66.Text = "Ada 369 v 2.0";
            // 
            // panelVisor
            // 
            this.panelVisor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panelVisor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVisor.Location = new System.Drawing.Point(200, 0);
            this.panelVisor.Name = "panelVisor";
            this.panelVisor.Size = new System.Drawing.Size(803, 527);
            this.panelVisor.TabIndex = 4;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelVisor);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MenuPrincipal";
            this.Size = new System.Drawing.Size(1003, 527);
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.PanelLicencia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel panelbotones;
        private System.Windows.Forms.Panel panel13;
        internal System.Windows.Forms.PictureBox PictureBox9;
        private System.Windows.Forms.Panel panelVisor;
        internal System.Windows.Forms.Panel PanelLicencia;
        internal System.Windows.Forms.Label lblestadoLicencia;
        internal System.Windows.Forms.PictureBox PictureBox16;
        internal System.Windows.Forms.Button btnLicencia;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label Label66;
    }
}