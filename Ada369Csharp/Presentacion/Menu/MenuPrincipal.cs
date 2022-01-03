using Ada369Csharp.Datos;
using Ada369Csharp.Presentacion.CAJA;
using Ada369Csharp.Presentacion.Configuraciones;
using Ada369Csharp.Presentacion.Dashboard;
using Ada369Csharp.Presentacion.Inventarios;
using Ada369Csharp.Presentacion.REPORTES;
using Ada369Csharp.Presentacion.SunatForms;
using Ada369Csharp.Presentacion.Ventas;
using RestCsharp.Presentacion.Licencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ada369Csharp.Presentacion.Menu
{
    public partial class MenuPrincipal : UserControl
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }
        string lic;
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            DibujarBotones();
            validarLicencia();
        }
        private void validarLicencia()
        {
            var funcion = new Dusuarios();
            Panel panellicencia = new Panel();
            funcion.licenciasExtras(ref lic, ref panellicencia);
            if (lic == "NO APLICA")
            {
                btnLicencia.Visible = false;
                PanelLicencia.Visible = false;
            }
            else
            {
                lblestadoLicencia.Text = lic;
                if(lic.Contains("PROFESIONAL"))
                {
                    btnLicencia.Visible = false;
                }
                else
                {
                    btnLicencia.Visible = true;
                }
            }


        }
        private void DibujarBotones()
        {
            panelbotones.Controls.Clear();
            var botones = new string[] { "Vender", "SUNAT", "Configuraciones", "Reportes", "Inventarios", "Panel control" };

            foreach (string boton in botones)
            {
                Button btn = new Button();
                btn.Text = boton.ToString();
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.BackColor = Color.FromArgb(29, 29, 29);
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
                btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
                btn.Size = new Size(168, 69);
                btn.ForeColor = Color.White;
                btn.Font = new Font("Consolas", 13, FontStyle.Bold);
                panelbotones.Controls.Add(btn);
                btn.Click += Btn_Click; ;

            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            string texto = ((Button)sender).Text;
            foreach (Control control in panelbotones.Controls)
            {
                if (control is Button)
                {
                    if (control.Text == texto)
                    {

                        control.BackgroundImage = Properties.Resources.naranja;
                    }
                    else
                    {
                        control.BackgroundImage = null;
                    }

                }
            }
            if (texto == "SUNAT")
            {
                Sunat();
            }
            else if (texto == "Vender")
            {
                Vender();
            }
            else if (texto == "Configuraciones")
            {
                Configuraciones();
            }
            else if (texto == "Panel control")
            {
                Panelcontrol();
            }
            else if (texto == "Reportes")
            {
                Reportes();
            }
            else if (texto == "Inventarios")
            {
                Inventarios();
            }
        }
        private void Inventarios()
        {
            panelVisor.Controls.Clear();
            var ctl = new Menuinv();
            ctl.Dock = DockStyle.Fill;
            panelVisor.Controls.Add(ctl);
        }
        private void Reportes()
        {
            panelVisor.Controls.Clear();
            var ctl = new MenuReportes();
            ctl.Dock = DockStyle.Fill;
            panelVisor.Controls.Add(ctl);
        }
        private void Vender()
        {
            //string resultado = null;
            //var funcion = new Dmovicaja();
            //funcion.MostrarCierresdeCaja(ref resultado);
            //if (resultado == "Nuevo*****")
            //{
            //    Dispose();
            //    var frmCaja = new APERTURA_DE_CAJA();
            //    frmCaja.ShowDialog();
            //}
            //else if (resultado == "Aperturado")
            //{
            //    Puntodeventa();
            //}

            Puntodeventa();
        }
        private void Puntodeventa()
        {
            panelVisor.Controls.Clear();
            var ctl = new Puntodeventa();
            //ctl.Size = new Size(Width, Height);
            ctl.Dock = DockStyle.Fill;
            panelVisor.Controls.Add(ctl);
            //ctl.BringToFront();
        }
        private void Panelcontrol()
        {
            panelVisor.Controls.Clear();
            var ctl = new Panelcontrol();
            ctl.Dock = DockStyle.Fill;
            panelVisor.Controls.Add(ctl);
        }
        private void Sunat()
        {
            panelVisor.Controls.Clear();
            var ctl = new Smenusunat();
            ctl.Dock = DockStyle.Fill;
            panelVisor.Controls.Add(ctl);
        }
        private void Configuraciones()
        {
            panelVisor.Controls.Clear();
            var ctl = new MenuConfig();
            ctl.Dock = DockStyle.Fill;
            panelVisor.Controls.Add(ctl);
        }

        private void btnLicencia_Click(object sender, EventArgs e)
        {
            activarLic();
        }
        private void activarLic()
        {
            var ctl = new Licencias();
            ctl.btnCerrar.Visible = true;
            ctl.Size = new Size(Width, Height);
            this.Controls.Add(ctl);
            
            ctl.BringToFront();
        }
    }
}
