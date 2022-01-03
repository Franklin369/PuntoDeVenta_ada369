namespace Ada369Csharp.Presentacion.Compras
{
    partial class HistorialCompras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialCompras));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.datalistadoCompras = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Panel29 = new System.Windows.Forms.Panel();
            this.txtbusca = new System.Windows.Forms.TextBox();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Label17 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgDetallecompra = new System.Windows.Forms.DataGridView();
            this.EL = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelProveedores = new System.Windows.Forms.Panel();
            this.lbltotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistadoCompras)).BeginInit();
            this.panel2.SuspendLayout();
            this.MenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetallecompra)).BeginInit();
            this.panelProveedores.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.datalistadoCompras);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Label17);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 542);
            this.panel1.TabIndex = 2;
            // 
            // datalistadoCompras
            // 
            this.datalistadoCompras.AllowUserToAddRows = false;
            this.datalistadoCompras.AllowUserToDeleteRows = false;
            this.datalistadoCompras.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.datalistadoCompras.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datalistadoCompras.BackgroundColor = System.Drawing.Color.White;
            this.datalistadoCompras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datalistadoCompras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.datalistadoCompras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datalistadoCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datalistadoCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistadoCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datalistadoCompras.DefaultCellStyle = dataGridViewCellStyle3;
            this.datalistadoCompras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datalistadoCompras.EnableHeadersVisualStyles = false;
            this.datalistadoCompras.Location = new System.Drawing.Point(0, 97);
            this.datalistadoCompras.Name = "datalistadoCompras";
            this.datalistadoCompras.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datalistadoCompras.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.datalistadoCompras.RowHeadersVisible = false;
            this.datalistadoCompras.RowHeadersWidth = 9;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro;
            this.datalistadoCompras.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.datalistadoCompras.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.datalistadoCompras.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.datalistadoCompras.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.datalistadoCompras.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.datalistadoCompras.RowTemplate.Height = 40;
            this.datalistadoCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalistadoCompras.Size = new System.Drawing.Size(365, 445);
            this.datalistadoCompras.TabIndex = 549;
            this.datalistadoCompras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datalistadoCompras_CellClick);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Panel29);
            this.panel2.Controls.Add(this.txtbusca);
            this.panel2.Controls.Add(this.MenuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 41);
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
            // Label17
            // 
            this.Label17.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Label17.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Label17.ForeColor = System.Drawing.Color.Black;
            this.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label17.Location = new System.Drawing.Point(0, 0);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(365, 41);
            this.Label17.TabIndex = 542;
            this.Label17.Text = "Compras realizadas";
            this.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(365, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 542);
            this.panel3.TabIndex = 624;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDetallecompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgDetallecompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetallecompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EL});
            this.dgDetallecompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDetallecompra.EnableHeadersVisualStyles = false;
            this.dgDetallecompra.GridColor = System.Drawing.Color.Gainsboro;
            this.dgDetallecompra.Location = new System.Drawing.Point(370, 0);
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
            this.dgDetallecompra.Size = new System.Drawing.Size(506, 485);
            this.dgDetallecompra.TabIndex = 625;
            // 
            // EL
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.EL.DefaultCellStyle = dataGridViewCellStyle7;
            this.EL.HeaderText = "";
            this.EL.Image = ((System.Drawing.Image)(resources.GetObject("EL.Image")));
            this.EL.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.EL.Name = "EL";
            this.EL.ReadOnly = true;
            this.EL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EL.ToolTipText = "Opcional \"Supr\" para Eliminar";
            // 
            // panelProveedores
            // 
            this.panelProveedores.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelProveedores.Controls.Add(this.lbltotal);
            this.panelProveedores.Controls.Add(this.label1);
            this.panelProveedores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelProveedores.Location = new System.Drawing.Point(370, 485);
            this.panelProveedores.Name = "panelProveedores";
            this.panelProveedores.Size = new System.Drawing.Size(506, 57);
            this.panelProveedores.TabIndex = 626;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.BackColor = System.Drawing.Color.Transparent;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbltotal.ForeColor = System.Drawing.Color.Black;
            this.lbltotal.Location = new System.Drawing.Point(70, 18);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(20, 22);
            this.lbltotal.TabIndex = 634;
            this.lbltotal.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 22);
            this.label1.TabIndex = 633;
            this.label1.Text = "Total:";
            // 
            // HistorialCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgDetallecompra);
            this.Controls.Add(this.panelProveedores);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "HistorialCompras";
            this.Size = new System.Drawing.Size(876, 542);
            this.Load += new System.EventHandler(this.HistorialCompras_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datalistadoCompras)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetallecompra)).EndInit();
            this.panelProveedores.ResumeLayout(false);
            this.panelProveedores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.DataGridView datalistadoCompras;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Panel Panel29;
        internal System.Windows.Forms.TextBox txtbusca;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem5;
        internal System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        internal System.Windows.Forms.Label Label17;
        private System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.DataGridView dgDetallecompra;
        private System.Windows.Forms.DataGridViewImageColumn EL;
        private System.Windows.Forms.Panel panelProveedores;
        internal System.Windows.Forms.Label lbltotal;
        internal System.Windows.Forms.Label label1;
    }
}
