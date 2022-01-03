using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Ada369Csharp.Logica;
namespace Ada369Csharp.Presentacion.Conexion_remota
{
    public partial class Caja_secundaria : Form
    {
        public Caja_secundaria()
        {
            InitializeComponent();
        }
        string serialPC;
        public static string lblconexion;
        private void Caja_secundaria_Load(object sender, EventArgs e)
        {
            Bases.Obtener_serialPC(ref serialPC);
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtcaja.Text))
            {
              Ingresar_caja();
            }
            else
            {
                MessageBox.Show("Datos incompletos");
            }
              
        }
        private void Ingresar_caja()
        {
            try
            {
                SqlConnection conexionExpress = new SqlConnection( lblconexion );
                conexionExpress.Open();

                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("Insertar_caja", conexionExpress );
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@descripcion", txtcaja.Text);
                cmd.Parameters.AddWithValue("@Tema", "Redentor");
                cmd.Parameters.AddWithValue("@Serial_PC", serialPC);
                cmd.Parameters.AddWithValue("@Impresora_Ticket", "Ninguna");
                cmd.Parameters.AddWithValue("@Impresora_A4", "Ninguna");
                cmd.Parameters.AddWithValue("@Tipo", "SECUNDARIA");
                cmd.ExecuteNonQuery();
                conexionExpress.Close();
                insertar_inicio_De_sesion();
                MessageBox.Show("Listo ya Tienes Esta CAJA Habilitada", "Caja Registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void insertar_inicio_De_sesion()
        {
            try
            {
                SqlConnection conexionExpress = new SqlConnection(lblconexion);
                conexionExpress.Open();

                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("insertar_inicio_De_sesion", conexionExpress);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_serial_Pc", serialPC);   
                cmd.ExecuteNonQuery();
                conexionExpress.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
