using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.IO;
using Ada369Csharp.Datos;
using Sunat.Logica;
using Ada369Csharp.Presentacion.Menu;

namespace Ada369Csharp.Presentacion.Configuraciones
{
    public partial class Empresaconfig : UserControl
    {
        public Empresaconfig()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Empresaconfig_Load(object sender, EventArgs e)
        {
            Cargarubigeos();
            mostrarEmpresa();
        }
        int PorcImpuesto;
        string Trabajasconimpuestos;
        string Modobusqueda;
        string Conectarsunat;
        string Servidor;
        string Codigoubigeo;
        private void Cargarubigeos()
        {
            var funcion = new Dcodigosubigeo();
            var dt = new DataTable();
            funcion.mostrarCodigosubigeo(ref dt);
            txtdepartamento.DisplayMember = "Departamento";
            txtdepartamento.DataSource = dt;
            txtprovincia.DisplayMember = "Provincia";
            txtprovincia.DataSource = dt;
            txtdistrito.DisplayMember = "Distrito";
            txtdistrito.DataSource = dt;
        }
        private void ObtenerUbicaionXubigeo()
        {
            var funcion = new Dcodigosubigeo();
            var parametros = new Lcodigosubigeos();
            var dt = new DataTable();
            parametros.Ubigeo = Codigoubigeo;
            funcion.ObtenerUbicaionXubigeo(ref dt, parametros);
            txtdepartamento.Text = dt.Rows[0][0].ToString();
            txtprovincia.Text = dt.Rows[0][1].ToString();
            txtdistrito.Text = dt.Rows[0][2].ToString();

        }
        private void ObtenercodigoUbigeo()
        {
            var funcion = new Dcodigosubigeo();
            var parametros = new Lcodigosubigeos();
            parametros.Departamento = txtdepartamento.Text;
            parametros.Provincia = txtprovincia.Text;
            parametros.Distrito = txtdistrito.Text;
            funcion.ObtenercodigoUbigeo(ref Codigoubigeo, parametros);
        }

        private void mostrarEmpresa()
        {
            var funcion = new Dempresa();
            var dt = new DataTable();
            funcion.mostrar_empresa(ref dt);
            txtrazonsocial.Text = dt.Rows[0][15].ToString();
            ImagenEmpresa.BackgroundImage = null;
            byte[] b = (Byte[])dt.Rows[0][1];
            MemoryStream ms = new MemoryStream(b);
            ImagenEmpresa.Image = Image.FromStream(ms);
            txtmoneda.Text = dt.Rows[0][4].ToString();
            Trabajasconimpuestos = dt.Rows[0][5].ToString();
            if (Trabajasconimpuestos == "SI")
            {
                si.Checked = true;
                PanelImpuesto.Visible = true;
            }
            if (Trabajasconimpuestos == "NO")
            {
                PanelImpuesto.Visible = false;
                no.Checked = true;
            }
            txtporcentaje.Text = dt.Rows[0][3].ToString();
            txtimpuesto.Text = dt.Rows[0][2].ToString();
            Modobusqueda = dt.Rows[0][6].ToString();
            txtRuta.Text = dt.Rows[0][7].ToString();
            if (Modobusqueda == "LECTORA")
            {
                txtlectora.Checked = true;
                txtteclado.Checked = false;
            }
            if (Modobusqueda == "TECLADO")
            {
                txtlectora.Checked = false;
                txtteclado.Checked = true;
            }
            Conectarsunat = dt.Rows[0][18].ToString();
            txtdireccionfiscal.Text = dt.Rows[0][16].ToString();
            if (Conectarsunat == "SI")
            {
                checConectarsunat.Checked = true;
                panelSunat.Visible = true;
            }
            Codigoubigeo = dt.Rows[0][17].ToString();
            txtRuc.Text = dt.Rows[0][14].ToString();
            txtCertificado.Text = dt.Rows[0][20].ToString();
            txtContraseñaCert.Text = dt.Rows[0][21].ToString();
            txtUsuarioSunat.Text = dt.Rows[0][22].ToString();
            txtContraseñaSunat.Text = dt.Rows[0][23].ToString();
            Servidor = dt.Rows[0][19].ToString();
            if (Servidor.Contains("beta"))
            {
                cbxServidor.Text = "Pruebas";
            }
            else
            {
                cbxServidor.Text = "Produccion";
            }
            ObtenerUbicaionXubigeo();
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
         
                if (txtrazonsocial.Text != "")
                {

                    Editarempresa();
                }
            
        }
        private void Editarempresa()
        {
            ValidarConexionsunat();
            ValidarImpuestos();
            var funcion = new Dempresa();
            var parametros = new Lempresa();
            parametros.RazonSocial = txtrazonsocial.Text;
            parametros.Impuesto = txtimpuesto.Text;
            parametros.Porcentaje_impuesto = PorcImpuesto;
            parametros.SimboloMoneda = txtmoneda.Text;
            parametros.Trabajas_con_impuestos = Trabajasconimpuestos;
            MemoryStream ms = new MemoryStream();
            ImagenEmpresa.Image.Save(ms, ImagenEmpresa.Image.RawFormat);
            parametros.Logo = ms.GetBuffer();
            parametros.Modo_de_busqueda = Modobusqueda;
            parametros.Carpeta_para_copias_de_seguridad = txtRuta.Text;
            parametros.Correo_para_envio_de_reportes = "-";
            parametros.ConectarSunat = Conectarsunat;
            funcion.EditarEmpresa(parametros);
            MessageBox.Show("Cambios guardados", "Guardando Cambios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dispose();
        }
        private void ValidarConexionsunat()
        {
            if (checConectarsunat.Checked == true)
            {
                Conectarsunat = "SI";
                Validarsunat();
            }
            else
            {
                Conectarsunat = "NO";
            }
        }
        private void ValidarImpuestos()
        {
            if (si.Checked == true)
            {
                PorcImpuesto = Convert.ToInt32(txtporcentaje.Text);
                Trabajasconimpuestos = "SI";
            }
            else if (no.Checked == true)
            {
                PorcImpuesto = 0;
                Trabajasconimpuestos = "NO";
            }
        }
        private void Validarsunat()
        {
            ObtenercodigoUbigeo();
            Validarservidor();
            var funcion = new Dempresa();
            var parametros = new Lempresa();

            parametros.Ruc = txtRuc.Text;
            parametros.DireccionFiscal = txtdireccionfiscal.Text;
            parametros.Ubigeo = Codigoubigeo;
            parametros.Servidor = Servidor;
            parametros.CarpetaCertificado = txtCertificado.Text;
            parametros.Passcertificado = txtContraseñaCert.Text;
            parametros.UserSecundario = txtUsuarioSunat.Text;
            parametros.PassSecundario = txtContraseñaSunat.Text;
            parametros.CodMoneda = txtCodigoMoneda.Text;
            funcion.editarSunatEmpresa(parametros);


        }

        private void Validarservidor()
        {
            if (cbxServidor.Text == "Pruebas")
            {
                Servidor = "https://e-beta.sunat.gob.pe/ol-ti-itcpfegem-beta/billService";
            }
            else
            {
                Servidor = "https://e-factura.sunat.gob.pe/ol-ti-itcpfegem/billService";
            }
        }

        private void si_CheckedChanged(object sender, EventArgs e)
        {
            PanelImpuesto.Visible = true;
        }

        private void no_CheckedChanged(object sender, EventArgs e)
        {
            PanelImpuesto.Visible = false;
        }

        private void txtlectora_CheckedChanged(object sender, EventArgs e)
        {
            if (txtlectora.Checked == true)
            {
                txtteclado.Checked = false;
                Modobusqueda = "LECTORA";
            }
            else
            {
                txtteclado.Checked = true;
                Modobusqueda = "TECLADO";

            }
        }

        private void txtteclado_CheckedChanged(object sender, EventArgs e)
        {
            if (txtteclado.Checked == true)
            {
                txtlectora.Checked = false;
            }
            else
            {
                txtlectora.Checked = true;
            }
        }

      


        private void lbleditarLogo_Click(object sender, EventArgs e)
        {
            dlg.InitialDirectory = "";
            dlg.Filter = "Imagenes|*.jpg;*.png";
            dlg.FilterIndex = 2;
            dlg.Title = "cargador de Imagenes Ada 369";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ImagenEmpresa.BackgroundImage = null;
                ImagenEmpresa.Image = new Bitmap(dlg.FileName);
                ImagenEmpresa.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void Label9_Click(object sender, EventArgs e)
        {
            Obtener_ruta();
        }
        private void Obtener_ruta()
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {

                string ruta = folderBrowserDialog1.SelectedPath;
                if (ruta.Contains(@"C:\"))
                {
                    MessageBox.Show("Seleccione un disco diferente al C", "Ruta Invalida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    txtRuta.Text = folderBrowserDialog1.SelectedPath;
                }
            }
        }

        private void ToolStripButton22_Click(object sender, EventArgs e)
        {
            Obtener_ruta();
        }

        private void checConectarsunat_CheckedChanged(object sender, EventArgs e)
        {
            if (checConectarsunat.Checked == true)
            {
                panelSunat.Visible = true;
            }
            else
            {
                panelSunat.Visible = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Obtenerutacertificado();
        }
        private void Obtenerutacertificado()
        {
            var dalg = new OpenFileDialog();
            dalg.InitialDirectory = "";
            dalg.Filter = "Certificado Sunat|*.pfx";
            dalg.FilterIndex = 2;
            dalg.Title = "Cargador de certificado digital";
            if (dalg.ShowDialog() == DialogResult.OK)
            {
                txtCertificado.Text = Path.GetFullPath(dalg.FileName);
            }
        }

        private void txtCertificado_Click(object sender, EventArgs e)
        {
            Obtenerutacertificado();
        }

     
    }
}
