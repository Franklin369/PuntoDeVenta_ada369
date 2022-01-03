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
using System.IO;
using System.Net.Mail;
using System.Net;
using System.Management;
using System.Xml;
using Ada369Csharp.Logica;
using Ada369Csharp.CONEXION;
using Ada369Csharp.Datos;
using Ada369Csharp.Presentacion.Menu;
using Ada369Csharp.Presentacion.Ventas;
using Ada369Csharp.Presentacion.Asistenteinstalacion;

namespace Ada369Csharp.Presentacion

{

    public partial class LOGIN : Form

    {
        int idsesion;
        int idusuario;
        int contador;
        int contadorCajas;
        int contador_Movimientos_de_caja;
        public static int idcajavariable;
        string lblSerialPc;
        string lblSerialPcLocal;
        string rol;
        string txtlogin;
        string lblApertura_De_caja;
        string ResultadoLicencia;
        string FechaFinal;
        string Ip;
        int contadorconexion = 0;
        string resultadocaja;
        int contadorCajasAperturadas;
        public LOGIN()

        {
            InitializeComponent();

        }

        public void dibujarUsuarios()

        {
            try
            {
                DataTable dt = new DataTable();
                Dusuarios funcion = new Dusuarios();
                Panel panellicencia = new Panel();
                this.Controls.Add(panellicencia);
                funcion.dibujarUsuarios(ref dt, ref ResultadoLicencia, ref panellicencia);
                lblestadoLicencia.Text = ResultadoLicencia;
                foreach (DataRow rdr in dt.Rows)
                {
                    Label b = new Label();
                    Panel p1 = new Panel();
                    PictureBox I1 = new PictureBox();

                    b.Text = rdr["Login"].ToString();
                    b.Name = rdr["idUsuario"].ToString();
                    b.Size = new Size(175, 25);
                    b.Font = new Font("Microsoft Sans Serif", 13);
                    b.BackColor = Color.FromArgb(20, 20, 20);
                    b.ForeColor = Color.White;
                    b.Dock = DockStyle.Bottom;
                    b.TextAlign = ContentAlignment.MiddleCenter;
                    b.Cursor = Cursors.Hand;

                    p1.Size = new System.Drawing.Size(155, 167);
                    p1.BorderStyle = BorderStyle.None;
                    p1.BackColor = Color.FromArgb(20, 20, 20);


                    I1.Size = new System.Drawing.Size(175, 132);
                    I1.Dock = DockStyle.Top;
                    I1.BackgroundImage = null;
                    byte[] bi = (Byte[])rdr["Icono"];

                    MemoryStream ms = new MemoryStream(bi);
                    I1.Image = Image.FromStream(ms);
                    I1.SizeMode = PictureBoxSizeMode.Zoom;
                    I1.Tag = rdr["Login"].ToString();
                    I1.Cursor = Cursors.Hand;

                    p1.Controls.Add(b);
                    p1.Controls.Add(I1);
                    b.BringToFront();
                    flowLayoutPanel1.Controls.Add(p1);

                    b.Click += new EventHandler(mieventoLabel);
                    I1.Click += new EventHandler(miEventoImagen);
                }


            }
            catch (Exception ex)
            {

            }
        }
        private void mostrarRoles()
        {
            Lusuarios parametros = new Lusuarios();
            Dusuarios funcion = new Dusuarios();
            parametros.IdUsuario = idusuario;
            funcion.mostrarRoles(parametros, ref rol);
            
        }
        private void miEventoImagen(System.Object sender, EventArgs e)
        {
            txtlogin = Convert.ToString(((PictureBox)sender).Tag);
            PanelIngreso_de_contraseña.Visible = true;
            PanelUsuarios.Visible = false;

        }

        private void mieventoLabel(System.Object sender, EventArgs e)
        {
            txtlogin = ((Label)sender).Text;
            PanelIngreso_de_contraseña.Visible = true;
            PanelUsuarios.Visible = false;

        }
        private void LOGIN_Load(object sender, EventArgs e)
        {
            ValidarConexion();
        }

        private void ObtenerIpLocal()
        {

            this.Text = Bases.ObtenerIp(ref Ip);
        }

        private void centralPaneles()
        {
            PanelIngreso_de_contraseña.Size = new Size(397, 654);
            PanelIngreso_de_contraseña.Visible = false;
            PanelIngreso_de_contraseña.Location = new Point((Width - PanelIngreso_de_contraseña.Width) / 2, (Height - PanelIngreso_de_contraseña.Height) / 2);
            PanelUsuarios.Visible = true;
            PanelUsuarios.Dock = DockStyle.Fill;
        }
        private void flowLayoutPanel1_Click(object sender, EventArgs e)
        {

        }

        private void MostrarCierresdeCaja()
        {
            try
            {
                DataTable dt = new DataTable();
                var funcion = new Dmovicaja();
                funcion.MostrarCierresdeCaja(ref resultadocaja);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        private void txtpaswwor_TextChanged(object sender, EventArgs e)
        {
            Iniciar();
        }


        private void Iniciar()
        {
            Validarusuario();

            if (idusuario > 0)
            {
                mostrarRoles();
                if (rol != "Cajero")
                {
                    Validarrol();
                }
                else if (rol == "Cajero")
                {
                    validarAperturasCaja();
                }
            }


        }

        private void validarAperturasCaja()
        {
            mostrarInicioSesion();
            mostrarMovCajaaperturada();
            if (contadorCajasAperturadas == 0)
            {
                Validarrol();
            }
            else
            {
                mostrarMovcajaXusuario();
            }
        }
        private void mostrarMovcajaXusuario()
        {
            var funcion = new Dmovicaja();
            var dt = new DataTable();

            funcion.mostrarMovcajaXusuario(ref dt, rol);
            contador = dt.Rows.Count;
            if (contador == 0)
            {
                MessageBox.Show("Para poder continuar con el Turno de *" + lblnombredeCajero.Text + "* ,Inicia sesion con el Usuario " + lblusuario_queinicioCaja.Text + " -ó-el Usuario *admin*", "Caja Iniciada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Validarrol();
            }
        }
        private void mostrarMovCajaaperturada()
        {
            var funcion = new Dmovicaja();
            funcion.MostrarCajasAperturada(ref contadorCajasAperturadas);
        }
        private void Validarusuario()
        {
            var funcion = new Dusuarios();
            var parametros = new Lusuarios();
            parametros.Login = txtlogin;
            parametros.Password = Bases.Encriptar(txtpaswwor.Text);
            funcion.validarUsuario(parametros, ref idusuario);
        }

     
      

      
     

      
     
        private void MOSTRAR_CAJA_POR_SERIAL()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();

                da = new SqlDataAdapter("mostrar_cajas_por_Serial_de_DiscoDuro", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Serial", lblSerialPc);
                da.Fill(dt);
                datalistado_caja.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }
        string INDICADOR;

        int txtcontador_USUARIOS;

        private void ValidarConexion()
        {
            var funcion = new Dconexion();
            if (funcion.validarConexion(ref contadorconexion) == true)
            {
                if (contadorconexion > 0)
                {

                    centralPaneles();
                    dibujarUsuarios();
                    ObtenerIpLocal();
                }
                else
                {
                    PasarAConfigurar();
                }

            }
            else
            {
                PasarAeleccionServidor();
            }
        }
        private void PasarAeleccionServidor()
        {
            Dispose();
            var frm = new Opcionesprincipales();
            frm.ShowDialog();
        }
        private void PasarAConfigurar()
        {
            Dispose();
            var frm = new Registroempresa();
            frm.ShowDialog();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtpaswwor.Text = txtpaswwor.Text + "0";

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtpaswwor.Text = txtpaswwor.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtpaswwor.Text = txtpaswwor.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtpaswwor.Text = txtpaswwor.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtpaswwor.Text = txtpaswwor.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtpaswwor.Text = txtpaswwor.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtpaswwor.Text = txtpaswwor.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtpaswwor.Text = txtpaswwor.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtpaswwor.Text = txtpaswwor.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtpaswwor.Text = txtpaswwor.Text + "9";
        }

        private void btnborrartodo_Click(object sender, EventArgs e)
        {
            txtpaswwor.Clear();

        }
        public static string Mid(string param, int startIndex, int length)
        {
            string result = param.Substring(startIndex, length);
            return result;
        }


        private void btnborrarderecha_Click(object sender, EventArgs e)
        {
            try
            {
                int largo;
                if (txtpaswwor.Text != "")
                {
                    largo = txtpaswwor.Text.Length;
                    label4.Text = Convert.ToString(largo);
                    txtpaswwor.Text = Mid(txtpaswwor.Text, 0, largo - 1);
                }
            }
            catch
            {

            }
        }

        private void tver_Click(object sender, EventArgs e)
        {

            txtpaswwor.PasswordChar = '\0';
            tocultar.Visible = true;
            tver.Visible = false;
        }

        private void tocultar_Click(object sender, EventArgs e)
        {
            txtpaswwor.PasswordChar = '*';
            tocultar.Visible = false;
            tver.Visible = true;
        }

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuario o contraseña Incorrectos", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        private void insertarInicioSesion()
        {
            LiniciosSesion parametros = new LiniciosSesion();
            DiniciosSesion funcion = new DiniciosSesion();
            parametros.IdUsuario = idusuario;
            funcion.insertarInicioSesion(parametros);
        }
        private void editarInicioSesion()
        {
            LiniciosSesion parametros = new LiniciosSesion();
            DiniciosSesion funcion = new DiniciosSesion();
            parametros.IdUsuario = idusuario;
            parametros.Idsesion = idsesion;
            funcion.editarInicioSesion(parametros);
        }

        private void Menuprincipal()
        {
             var ctl = new MenuPrincipal();
            ctl.Dock = DockStyle.Fill;
            this.Controls.Add(ctl);
            ctl.BringToFront();
        }
        private void mostrarInicioSesion()
        {
            DiniciosSesion funcion = new DiniciosSesion();
            funcion.mostrarInicioSesion(ref idsesion);
            if (idsesion > 0)
            {
                editarInicioSesion();
            }
            else
            {
                insertarInicioSesion();
            }
        }

        private void Validarrol()
        {
            if (rol == "Administrador")
            {

                mostrarInicioSesion();
                Menuprincipal();

            }
            else
            {
                mostrarInicioSesion();
                Puntoventa();

            }
        }

        private void Puntoventa()
        {

            var ctl = new Puntodeventa();
            ctl.Size = new Size(Width, Height);
            this.Controls.Add(ctl);
            ctl.BringToFront();
        }
        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btncambioUsuario_Click(object sender, EventArgs e)
        {
            PanelUsuarios.Visible = true;
            PanelIngreso_de_contraseña.Visible = false;
            txtpaswwor.Clear();
        }
    }
}
