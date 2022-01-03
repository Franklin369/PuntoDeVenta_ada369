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
using Ada369Csharp.Datos;

namespace Ada369Csharp.Presentacion.Configuraciones
{
    public partial class Cajasconfig : UserControl
    {
        public Cajasconfig()
        {
            InitializeComponent();
        }

        private void Cajas_form_Load(object sender, EventArgs e)
        {
            dibujarCAJA_PRINCIPAL();
            dibujarCAJAS_REMOTAS();
        }
        private void dibujarCAJA_PRINCIPAL()
        {
             try
            {
                var dt = new DataTable();
                var funcion = new Dcaja();
                funcion.Mostrarcajaprincipal(ref dt);
                foreach (DataRow rdr in dt.Rows)
                {
                    Panel p1 = new Panel();
                    Panel p2 = new Panel();
                    PictureBox  I1 = new PictureBox();
                    PictureBox I2 = new PictureBox();
                    Label L = new Label();
                    Label L2 = new Label();
                  
                    Panel P3 = new Panel();
                    Label LABELusuario = new Label();
                    Panel PbarraArriba = new Panel();
                    Panel Pbarracostado = new Panel();

                    L.Text = rdr["Descripcion"].ToString();
                    L.Name = rdr["Id_Caja"].ToString();
                    L.Size = new System.Drawing.Size(175, 25);
                    L.Font = new System.Drawing.Font("Microsoft Sans Serif", 20);
                    L.AutoSize = false;
                    L.BackColor = Color.Transparent;
                    L.ForeColor = Color.White;
                    L.Dock = DockStyle.Fill;
                    L.TextAlign = ContentAlignment.MiddleCenter;

                    try
                    {

                    }
                    catch (Exception ex )
                    {

                    }
                    LABELusuario.Text = "Por " + rdr["Nombres_y_Apellidos"].ToString();
                    LABELusuario.Dock = DockStyle.Bottom;
                    LABELusuario.AutoSize = false;
                    LABELusuario.TextAlign = ContentAlignment.MiddleCenter;
                    LABELusuario.BackColor = Color.Transparent;
                    LABELusuario.ForeColor = Color.White;
                    LABELusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10);
                    LABELusuario.Size = new System.Drawing.Size(430, 31);

                    p1.Size = new System.Drawing.Size(208, 143);
                    p1.BorderStyle = BorderStyle.None;
                    p1.Dock = DockStyle.Top;
                    p1.BackColor = Color.FromArgb(20, 20, 20);

                    p2.Size = new System.Drawing.Size(208, 24);
                    p2.Dock = DockStyle.Top;
                    p2.BackColor = Color.Transparent;

                    L2.Text = rdr["Estado"].ToString();
                    L2.Size = new System.Drawing.Size(430, 18);
                    L2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9);
                    L2.BackColor = Color.Transparent;
                    L2.AutoSize = false;
                    L2.ForeColor = Color.Gray;
                    L2.Dock = DockStyle.Fill;
                    L2.TextAlign = ContentAlignment.MiddleCenter;

                    MenuStrip Menustrip = new MenuStrip();
                    Menustrip.BackColor = Color.Transparent;
              
                    Menustrip.Size = new System.Drawing.Size(28, 24);
                    Menustrip.Dock = DockStyle.Right;
                    Menustrip.Name = rdr["Id_Caja"].ToString();
                    ToolStripMenuItem ToolStripPRINCIPAL = new ToolStripMenuItem();
                    ToolStripMenuItem ToolStripEDITAR = new ToolStripMenuItem();

                    ToolStripPRINCIPAL.Image = Properties.Resources.menuCajas_claro;
                    ToolStripPRINCIPAL.BackColor = Color.Transparent;
                    ToolStripEDITAR.Text = "Editar";
                    ToolStripEDITAR.Name = rdr["Descripcion"].ToString();
                    ToolStripEDITAR.Tag = rdr["Id_caja"].ToString();

                    Menustrip.Items.Add(ToolStripPRINCIPAL);
                    ToolStripPRINCIPAL.DropDownItems.Add(ToolStripEDITAR);


                    if (L2.Text =="RECIEN CREADA")
                    {
                        I1.BackgroundImage = Properties.Resources.Caja_recien_creada;
                    }
                    else if (L2.Text == "Caja Restaurada")
                    {
                        I1.BackgroundImage = Properties.Resources.Caja_recien_creada;

                    }
                    else if (L2.Text =="Caja Aperturada")
                    {
                        I1.BackgroundImage = Properties.Resources.Caja_activa;

                    }
                    else if (L2.Text =="Caja cerrada")
                    {
                        I1.BackgroundImage = Properties.Resources.caja_eliminada;
                    }
                    else if (L2.Text == "Caja Eliminada")
                    {
                        I1.BackgroundImage = Properties.Resources.Caja_eliminada_oficial;
                        L.ForeColor = Color.DimGray;
                    }

                    I1.BackgroundImageLayout = ImageLayout.Zoom;
                    I1.Size = new System.Drawing.Size(22, 24);
                    I1.Dock = DockStyle.Fill;
                    I1.BackColor = Color.Transparent;

                    P3.Size = new System.Drawing.Size(30, 24);
                        P3.Dock = DockStyle.Left;
                    P3.BackColor = Color.Transparent ;

                    PbarraArriba.Size = new System.Drawing.Size(22, 5);
                    PbarraArriba.Dock = DockStyle.Top;
                    PbarraArriba.BackColor = Color.Transparent ;

                    Pbarracostado.Size = new System.Drawing.Size(2, 22);
                    Pbarracostado.Dock = DockStyle.Left;
                    Pbarracostado.BackColor = Color.Transparent;

                    P3.Controls.Add(PbarraArriba);
                    P3.Controls.Add(Pbarracostado);
                    P3.Controls.Add(I1);

                    p2.Controls.Add(P3);
                    p2.Controls.Add(L2);
                    p2.Controls.Add(Menustrip);
                    p1.Controls.Add(p2);
                    p1.Controls.Add(L);                 
                    p1.Controls.Add(LABELusuario);

                    panel2.Controls.Add(p1);
                    LABELusuario.BringToFront();
                    I1.BringToFront();

                    ToolStripEDITAR.Click += new EventHandler(miEventoToolStripEDITAR);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dibujarCAJAS_REMOTAS()
        {
            flowLayoutPanel1.Controls.Clear();
            try
            {
                
                var dt = new DataTable();
                var funcion = new Dcaja();
                funcion.Mostrarcajaremota(ref dt);
                foreach (DataRow rdr in dt.Rows)
                {
                    Panel p1 = new Panel();
                    Panel p2 = new Panel();
                    PictureBox I1 = new PictureBox();
                    PictureBox I2 = new PictureBox();
                    Label L = new Label();
                    Label L2 = new Label();

                    Panel P3 = new Panel();
                    Label LABELusuario = new Label();
                    Panel PbarraArriba = new Panel();
                    Panel Pbarracostado = new Panel();

                    L.Text = rdr["Descripcion"].ToString();
                    L.Name = rdr["Id_Caja"].ToString();
                    L.Size = new System.Drawing.Size(175, 25);
                    L.Font = new System.Drawing.Font("Microsoft Sans Serif", 20);
                    L.AutoSize = false;
                    L.BackColor = Color.Transparent;
                    L.ForeColor = Color.White;
                    L.Dock = DockStyle.Fill;
                    L.TextAlign = ContentAlignment.MiddleCenter;

                    try
                    {

                    }
                    catch (Exception ex)
                    {

                    }
                    LABELusuario.Text = "Por " + rdr["Nombres_y_Apellidos"].ToString();
                    LABELusuario.Dock = DockStyle.Bottom;
                    LABELusuario.AutoSize = false;
                    LABELusuario.TextAlign = ContentAlignment.MiddleCenter;
                    LABELusuario.BackColor = Color.Transparent;
                    LABELusuario.ForeColor = Color.White;
                    LABELusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10);
                    LABELusuario.Size = new System.Drawing.Size(430, 31);

                    p1.Size = new System.Drawing.Size(208, 143);
                    p1.BorderStyle = BorderStyle.None;
                    p1.Dock = DockStyle.Top;
                    p1.BackColor = Color.FromArgb(20, 20, 20);

                    p2.Size = new System.Drawing.Size(208, 24);
                    p2.Dock = DockStyle.Top;
                    p2.BackColor = Color.Transparent;

                    L2.Text = rdr["Estado"].ToString();
                    L2.Size = new System.Drawing.Size(430, 18);
                    L2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9);
                    L2.BackColor = Color.Transparent;
                    L2.AutoSize = false;
                    L2.ForeColor = Color.Gray;
                    L2.Dock = DockStyle.Fill;
                    L2.TextAlign = ContentAlignment.MiddleCenter;

                    MenuStrip Menustrip = new MenuStrip();
                    Menustrip.BackColor = Color.Transparent;

                    Menustrip.Size = new System.Drawing.Size(28, 24);
                    Menustrip.Dock = DockStyle.Right;
                    Menustrip.Name = rdr["Id_Caja"].ToString();
                    ToolStripMenuItem ToolStripPRINCIPAL = new ToolStripMenuItem();
                    ToolStripMenuItem ToolStripEDITAR = new ToolStripMenuItem();
                    ToolStripMenuItem ToolStripELIMINAR = new ToolStripMenuItem();
                    ToolStripMenuItem ToolStripRESTAURAR = new ToolStripMenuItem();


                    ToolStripPRINCIPAL.Image = Properties.Resources.menuCajas_claro;
                    ToolStripPRINCIPAL.BackColor = Color.Transparent;
                    ToolStripEDITAR.Text = "Editar";
                    ToolStripEDITAR.Name = rdr["Descripcion"].ToString();
                    ToolStripEDITAR.Tag = rdr["Id_caja"].ToString();
                    ToolStripELIMINAR.Text = "Eliminar";
                    ToolStripELIMINAR.Tag = rdr["Id_caja"].ToString();
                    ToolStripRESTAURAR.Text = "Restaurar";
                    ToolStripRESTAURAR.Tag = rdr["Id_caja"].ToString();


                    Menustrip.Items.Add(ToolStripPRINCIPAL);

                   

                    if (L2.Text == "RECIEN CREADA")
                    {
                        I1.BackgroundImage = Properties.Resources.Caja_recien_creada;
                    }
                    else if (L2.Text == "Caja Restaurada")
                    {
                        I1.BackgroundImage = Properties.Resources.Caja_recien_creada;

                    }
                    else if (L2.Text == "Caja Aperturada")
                    {
                        I1.BackgroundImage = Properties.Resources.Caja_activa;

                    }
                    else if (L2.Text == "Caja cerrada")
                    {
                        I1.BackgroundImage = Properties.Resources.caja_eliminada;
                    }
                    else if (L2.Text == "Caja Eliminada")
                    {
                        I1.BackgroundImage = Properties.Resources.Caja_eliminada_oficial;
                        L.ForeColor = Color.DimGray;
                    }
                    if (L2.Text !="Caja Eliminada")
                    {
                        ToolStripPRINCIPAL.DropDownItems.Add(ToolStripEDITAR);
                        ToolStripPRINCIPAL.DropDownItems.Add(ToolStripELIMINAR);
                      
                    }
                    else
                    {
                      ToolStripPRINCIPAL.DropDownItems.Add(ToolStripRESTAURAR);
                    }


                    I1.BackgroundImageLayout = ImageLayout.Zoom;
                    I1.Size = new System.Drawing.Size(22, 24);
                    I1.Dock = DockStyle.Fill;
                    I1.BackColor = Color.Transparent;

                    P3.Size = new System.Drawing.Size(30, 24);
                    P3.Dock = DockStyle.Left;
                    P3.BackColor = Color.Transparent;

                    PbarraArriba.Size = new System.Drawing.Size(22, 5);
                    PbarraArriba.Dock = DockStyle.Top;
                    PbarraArriba.BackColor = Color.Transparent;

                    Pbarracostado.Size = new System.Drawing.Size(2, 22);
                    Pbarracostado.Dock = DockStyle.Left;
                    Pbarracostado.BackColor = Color.Transparent;

                    P3.Controls.Add(PbarraArriba);
                    P3.Controls.Add(Pbarracostado);
                    P3.Controls.Add(I1);

                    p2.Controls.Add(P3);
                    p2.Controls.Add(L2);
                    p2.Controls.Add(Menustrip);
                    p1.Controls.Add(p2);
                    p1.Controls.Add(L);
                    p1.Controls.Add(LABELusuario);

                    flowLayoutPanel1.Controls.Add(p1);
                    LABELusuario.BringToFront();
                    I1.BringToFront();

                    ToolStripEDITAR.Click += new EventHandler(miEventoToolStripEDITAR);
                    ToolStripELIMINAR.Click += new EventHandler(miEventoToolStripELIMINAR);
                    ToolStripRESTAURAR.Click += new EventHandler(miEventoToolStripRESTAURAR);
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        int idcaja;
        private void miEventoToolStripEDITAR(System.Object sender, EventArgs e)
        {
            idcaja = Convert.ToInt32 ( ((ToolStripMenuItem)sender).Tag);
            txtcaja.Text = ((ToolStripMenuItem)sender).Name;
            panel18.Visible = true;
            panel18.Dock = DockStyle.Fill;
            panelEdicion_de_caja.Location = new Point((panel18.Width - panelEdicion_de_caja.Width) / 2, (panel18.Height - panelEdicion_de_caja.Height) / 2);
            txtcaja.SelectAll();
            txtcaja.Focus();
        }
        private void miEventoToolStripELIMINAR(System.Object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("¿Realmente desea eliminar esta caja?", "Eliminando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result== DialogResult.OK )
            {
                idcaja= Convert.ToInt32 (((ToolStripMenuItem )sender ).Tag);
                eliminar_caja();
                dibujarCAJAS_REMOTAS();
            }
        }
        private void eliminar_caja()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("eliminar_caja", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idcaja", idcaja);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void miEventoToolStripRESTAURAR(System.Object sender, EventArgs e)
        {
            idcaja = Convert.ToInt32 ( ((ToolStripMenuItem)sender).Tag);
            restaurar_caja();
        }
        private void restaurar_caja()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("restaurar_caja", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idcaja", idcaja);
                cmd.ExecuteNonQuery ();
                con.Close();
                dibujarCAJAS_REMOTAS();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("editar_caja", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idcaja", idcaja);
                cmd.Parameters.AddWithValue("@descripcion", txtcaja.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                panel18.Visible = false;
                panel18.Dock = DockStyle.None;
                dibujarCAJA_PRINCIPAL();
                dibujarCAJAS_REMOTAS();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel18.Visible = false;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
