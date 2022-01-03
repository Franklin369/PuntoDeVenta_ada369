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
namespace Ada369Csharp.Presentacion.Asistenteinstalacion
{
    public partial class Opcionesprincipales : Form
    {
        public Opcionesprincipales()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Dispose();
            var frm = new Instalacionservidor();
            frm.ShowDialog();
        }
        string Estado_de_conexion;
        private void Listar()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();
                da = new SqlDataAdapter("select * from USUARIO2", con);
                da.Fill(dt);
                datalistado.DataSource = dt;
                con.Close();
                Estado_de_conexion = "CONECTADO";
            }
            catch (Exception ex)
            {
                Estado_de_conexion = "-";
          
            }
        }
        private void Opcionesprincipales_Load(object sender, EventArgs e)
        {
            Panel4.Location = new Point((Width - Panel4.Width) / 2, (Height - Panel4.Height) / 2);
            Listar();
            if (Estado_de_conexion == "CONECTADO")
                {
                Hide();
                var  frm = new Registroempresa();
                frm.ShowDialog();
                Dispose();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Dispose();
            Conexion_remota.Conexion_secundaria frm = new Conexion_remota.Conexion_secundaria();
            frm.ShowDialog();
        }
    }
}
