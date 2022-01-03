namespace Ada369Csharp.Presentacion.Compras
{
    partial class Admincompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admincompras));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btncomprar = new System.Windows.Forms.Button();
            this.btnhistorial = new System.Windows.Forms.Button();
            this.Label36 = new System.Windows.Forms.Label();
            this.panelvisor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.Label36);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 513);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btncomprar);
            this.flowLayoutPanel1.Controls.Add(this.btnhistorial);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 47);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(183, 466);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btncomprar
            // 
            this.btncomprar.BackColor = System.Drawing.Color.Transparent;
            this.btncomprar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncomprar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncomprar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btncomprar.FlatAppearance.BorderSize = 0;
            this.btncomprar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btncomprar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btncomprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncomprar.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.btncomprar.ForeColor = System.Drawing.Color.White;
            this.btncomprar.Location = new System.Drawing.Point(3, 3);
            this.btncomprar.Name = "btncomprar";
            this.btncomprar.Size = new System.Drawing.Size(158, 68);
            this.btncomprar.TabIndex = 43;
            this.btncomprar.Text = "Comprar";
            this.btncomprar.UseVisualStyleBackColor = false;
            this.btncomprar.Click += new System.EventHandler(this.btncomprar_Click);
            // 
            // btnhistorial
            // 
            this.btnhistorial.BackColor = System.Drawing.Color.Transparent;
            this.btnhistorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnhistorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhistorial.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnhistorial.FlatAppearance.BorderSize = 0;
            this.btnhistorial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnhistorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnhistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhistorial.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.btnhistorial.ForeColor = System.Drawing.Color.White;
            this.btnhistorial.Location = new System.Drawing.Point(3, 77);
            this.btnhistorial.Name = "btnhistorial";
            this.btnhistorial.Size = new System.Drawing.Size(158, 66);
            this.btnhistorial.TabIndex = 44;
            this.btnhistorial.Text = "Historial de compras";
            this.btnhistorial.UseVisualStyleBackColor = false;
            this.btnhistorial.Click += new System.EventHandler(this.btnhistorial_Click);
            // 
            // Label36
            // 
            this.Label36.BackColor = System.Drawing.Color.Transparent;
            this.Label36.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.Label36.ForeColor = System.Drawing.Color.DimGray;
            this.Label36.Location = new System.Drawing.Point(0, 0);
            this.Label36.Name = "Label36";
            this.Label36.Size = new System.Drawing.Size(183, 47);
            this.Label36.TabIndex = 509;
            this.Label36.Text = "Compras";
            this.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelvisor
            // 
            this.panelvisor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panelvisor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelvisor.Location = new System.Drawing.Point(183, 0);
            this.panelvisor.Name = "panelvisor";
            this.panelvisor.Size = new System.Drawing.Size(697, 513);
            this.panelvisor.TabIndex = 1;
            // 
            // Admincompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 513);
            this.Controls.Add(this.panelvisor);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admincompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        internal System.Windows.Forms.Label Label36;
        internal System.Windows.Forms.Button btncomprar;
        internal System.Windows.Forms.Button btnhistorial;
        private System.Windows.Forms.Panel panelvisor;
    }
}