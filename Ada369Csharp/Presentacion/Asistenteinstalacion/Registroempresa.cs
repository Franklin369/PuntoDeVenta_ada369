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
using System.Management;
using Ada369Csharp.Logica;
using Sunat.Logica;
using Ada369Csharp.CONEXION;
using Ada369Csharp.Datos;
using Ada369Csharp.Presentacion.AsistenteInstalacion;

namespace Ada369Csharp.Presentacion.Asistenteinstalacion
{
    public partial class Registroempresa : Form
    {
        public Registroempresa()
        {
            InitializeComponent();
        }
        string lblIDSERIAL;
        private void Panel6_Paint(object sender, PaintEventArgs e)
        {

        }
        public static string correo;
        public bool validar_Mail(string sMail)
        {
            return Regex.IsMatch(sMail, @"^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$");

        }
        private void TSIGUIENTE_Y_GUARDAR__Click(object sender, EventArgs e)
        {
          

                if (txtempresa.Text != "")
                {
                    if (txtRuta.Text != "")
                    {
                        if (no.Checked == true)
                        {
                            TXTTRABAJASCONIMPUESTOS.Text = "NO";
                        }
                        if (si.Checked == true)
                        {
                            TXTTRABAJASCONIMPUESTOS.Text = "SI";
                        }
                        IngresarEmpresa();
                        Ingresar_caja();
                        Insertarserializacion();
                        InsertarTicket();
                        Dispose();
                        var frm = new UsuarioPrincipal();
                        frm.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Seleccione una Ruta para Guardar las Copias de Seguridad", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }



                }

                else
                {
                    MessageBox.Show("Ingrese un Nombre de Empresa", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }
        private void Ingresar_caja()
        {
            try
            {


                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("Insertar_caja", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@descripcion", txtcaja.Text);
                cmd.Parameters.AddWithValue("@Tema", "Redentor");
                cmd.Parameters.AddWithValue("@Serial_PC", lblIDSERIAL);
                cmd.Parameters.AddWithValue("@Impresora_Ticket", "Ninguna");
                cmd.Parameters.AddWithValue("@Impresora_A4", "Ninguna");
                cmd.Parameters.AddWithValue("@Tipo", "PRINCIPAL");
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void InsertarTicket()
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("InsertarTicket", CONEXIONMAESTRA.conectar);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }
        private void Insertarserializacion()
        {
            var funcion = new Dserializacion();
            funcion.insertarSerializacion();

        }
        private void IngresarEmpresa()
        {
            var funcion = new Dempresa();
            var parametros = new Lempresa();
            parametros.RazonSocial = txtempresa.Text;
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            ImagenEmpresa.Image.Save(ms, ImagenEmpresa.Image.RawFormat);
            parametros.Logo = ms.GetBuffer();
            parametros.Impuesto = txtimpuesto.Text;
            parametros.Porcentaje_impuesto = Convert.ToDouble(txtporcentaje.Text);
            parametros.SimboloMoneda = txtmoneda.Text;
            parametros.Trabajas_con_impuestos = TXTTRABAJASCONIMPUESTOS.Text;
            parametros.Carpeta_para_copias_de_seguridad = txtRuta.Text;
            parametros.Correo_para_envio_de_reportes = "-";
            if (TXTCON_LECTORA.Checked == true)
            {
                parametros.Modo_de_busqueda = "LECTORA";
            }
            if (txtteclado.Checked == true)
            {
                parametros.Modo_de_busqueda = "TECLADO";
            }
            funcion.Insertar_Empresa(parametros);
        }

        private void TXTCON_LECTORA_CheckedChanged(object sender, EventArgs e)
        {
            if (TXTCON_LECTORA.Checked == true)
            {
                txtteclado.Checked = false;
            }
            if (TXTCON_LECTORA.Checked == false)
            {
                txtteclado.Checked = true;
            }
        }

        private void txtteclado_CheckedChanged(object sender, EventArgs e)
        {
            if (txtteclado.Checked == true)
            {
                TXTCON_LECTORA.Checked = false;
            }
            if (txtteclado.Checked == false)
            {
                TXTCON_LECTORA.Checked = true;
            }
        }


        private void lbleditarLogo_Click(object sender, EventArgs e)
        {
            dlg.InitialDirectory = "";
            dlg.Filter = "Imagenes|*.jpg;*.png";
            dlg.FilterIndex = 2;
            dlg.Title = "Cargador de Imagenes ADA 369";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ImagenEmpresa.BackgroundImage = null;
                ImagenEmpresa.Image = new Bitmap(dlg.FileName);
                ImagenEmpresa.SizeMode = PictureBoxSizeMode.Zoom;

            }
        }

        private void Label9_Click(object sender, EventArgs e)

        {
            if (FolderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string ruta = txtRuta.Text;
                if (ruta.Contains(@"C:\"))
                {
                    MessageBox.Show("Selecciona un Disco Diferente al Disco C:", "Ruta Invalida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtRuta.Text = "";
                }
                else
                {
                    txtRuta.Text = FolderBrowserDialog1.SelectedPath;
                }


            }

        }

        private void ToolStripButton22_Click(object sender, EventArgs e)
        {
            if (FolderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtRuta.Text = FolderBrowserDialog1.SelectedPath;
                string ruta = txtRuta.Text;
                if (ruta.Contains(@"C:\"))
                {
                    MessageBox.Show("Selecciona un Disco Diferente al Disco C:", "Ruta Invalida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtRuta.Text = "";
                }
                else
                {
                    txtRuta.Text = FolderBrowserDialog1.SelectedPath;
                }


            }
        }

        private void Registroempresa_Load(object sender, EventArgs e)
        {
            Bases.Obtener_serialPC(ref lblIDSERIAL);
            Panel16.Location = new Point((Width - Panel16.Width) / 2, (Height - Panel16.Height) / 2);
            TXTCON_LECTORA.Checked = true;
            txtteclado.Checked = false;
            no.Checked = true;
            Panel11.Visible = false;
            Panel9.Visible = false;


            TSIGUIENTE.Visible = false;
            TSIGUIENTE_Y_GUARDAR.Visible = true;
        }

        private void si_CheckedChanged(object sender, EventArgs e)
        {
            Panel11.Visible = true;
        }

        private void no_CheckedChanged(object sender, EventArgs e)
        {
            Panel11.Visible = false;

        }

        private void ImagenEmpresa_Click(object sender, EventArgs e)
        {

        }
    }
}

