using RestCsharp.Presentacion.Configuraciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ada369Csharp.Presentacion.Configuraciones
{
    public partial class MenuConfig : UserControl
    {
        public MenuConfig()
        {
            InitializeComponent();
        }

        private void btnempresa_Click(object sender, EventArgs e)
        {
            var ctl = new Empresaconfig();
            ctl.Dock = DockStyle.Fill;
            ctl.Size = new Size(Width, Height);
            Controls.Add(ctl);
            ctl.BringToFront();
        }

        private void btnusuarios_Click(object sender, EventArgs e)
        {
            var ctl = new Usuariosconfig();
            ctl.Dock = DockStyle.Fill;
            ctl.Size = new Size(Width, Height);
            Controls.Add(ctl);
            ctl.BringToFront();
        }

        private void btncajas_Click(object sender, EventArgs e)
        {
            var ctl = new Cajasconfig();
            ctl.Dock = DockStyle.Fill;
            ctl.Size = new Size(Width, Height);
            Controls.Add(ctl);
            ctl.BringToFront();
        }

        private void btnserializacion_Click(object sender, EventArgs e)
        {
            var ctl = new Serializacionconfig();
            ctl.Dock = DockStyle.Fill;
            ctl.Size = new Size(Width, Height);
            Controls.Add(ctl);
            ctl.BringToFront();
        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            var ctl = new Productosconfig();
            ctl.Dock = DockStyle.Fill;
            ctl.Size = new Size(Width, Height);
            Controls.Add(ctl);
            ctl.BringToFront();
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            var ctl = new Clientesconfig();
            ctl.Dock = DockStyle.Fill;
            ctl.Size = new Size(Width, Height);
            Controls.Add(ctl);
            ctl.BringToFront();
        }

        private void btnproveedores_Click(object sender, EventArgs e)
        {
            var ctl = new Proveedoresconfig();
            ctl.Dock = DockStyle.Fill;
            ctl.Size = new Size(Width, Height);
            Controls.Add(ctl);
            ctl.BringToFront();
        }

        private void btndiseñador_Click(object sender, EventArgs e)
        {
            var ctl = new Diseñoticket();
            ctl.Dock = DockStyle.Fill;
            ctl.Size = new Size(Width, Height);
            Controls.Add(ctl);
            ctl.BringToFront();
        }

        private void btnimpresoras_Click(object sender, EventArgs e)
        {
            var ctl = new Impresorasconfig();
            ctl.Dock = DockStyle.Fill;
            ctl.Size = new Size(Width, Height);
            Controls.Add(ctl);
            ctl.BringToFront();
        }

        private void btnBalanza_Click(object sender, EventArgs e)
        {
            var ctl = new Impresorasconfig();
            ctl.Dock = DockStyle.Fill;
            ctl.Size = new Size(Width, Height);
            Controls.Add(ctl);
            ctl.BringToFront();
        }

        private void btncorreo_Click(object sender, EventArgs e)
        {
            var ctl = new Correoconfi();
            ctl.Dock = DockStyle.Fill;
            ctl.Size = new Size(Width, Height);
            Controls.Add(ctl);
            ctl.BringToFront();
        }

        private void btnRespaldos_Click(object sender, EventArgs e)
        {
            var ctl = new Respaldosconfig();
            ctl.Dock = DockStyle.Fill;
            ctl.Size = new Size(Width, Height);
            Controls.Add(ctl);
            ctl.BringToFront();
        }
    }
}
