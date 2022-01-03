using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ada369Csharp.Datos;
using Ada369Csharp.Logica;
namespace Ada369Csharp.Presentacion.Configuraciones
{
    public partial class BalanzaForm : UserControl
    {
        public BalanzaForm()
        {
            InitializeComponent();
        }
        private string BufeerRespuesta;
        private delegate void DelegadoAcceso(string accion);

        private void AccesoForm(string accion)
        {
            BufeerRespuesta = accion;
            txtresultado.Text = BufeerRespuesta;
        }
        private void accesoInterrupcion(string accion)
        {
            DelegadoAcceso Var_delagadoacceso;
            Var_delagadoacceso = new DelegadoAcceso(AccesoForm);
            Object[] arg = { accion };
            base.Invoke(Var_delagadoacceso, arg);
        }
        private void puertos_DataReceived(Object sender, SerialDataReceivedEventArgs e)
        {
            accesoInterrupcion(puertos.ReadExisting());
        }
        private void BalanzaForm_Load(object sender, EventArgs e)
        {
            listarPuertos();
        }
        private void listarPuertos()
        {
            try
            {
                ListaPuertos.Items.Clear();
                string[] PuertosDisponibles = SerialPort.GetPortNames();
                foreach (string puerto in PuertosDisponibles)
                {
                    ListaPuertos.Items.Add(puerto);

                }
                if (ListaPuertos.Items.Count >0)
                {
                    ListaPuertos.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("No se encontraron Puertos");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontraron Puertos");
            }
        }

        private void btnProbar_Click(object sender, EventArgs e)
        {
            puertos.Close();
            try
            {
                puertos.BaudRate = 9600;
                puertos.DataBits = 8;
                puertos.Parity = Parity.None;
                puertos.StopBits = (StopBits)1;
                puertos.PortName = ListaPuertos.Text;
                puertos.Open();
                if (puertos.IsOpen)
                {
                    lblestado.Text = "Conectado";
                }
                else
                {
                    MessageBox.Show("Fallo la conexion");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            if (puertos.IsOpen)
            {
                puertos.WriteLine(txtresultado.Text);
            }
            else
            {
                MessageBox.Show("Fallo la conexion");
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtresultado.Text ))
            {
              editarBascula();
            }
            else
            {
                MessageBox.Show("El resultado tiene que ser diferente de vacio para confirmar la balanza");
            }
          
        }
        private void editarBascula()
        {
            Lcaja parametros = new Lcaja();
            Editar_datos funcion = new Editar_datos();
            parametros.EstadoBalanza = "CONFIRMADO";
            parametros.PuertoBalanza = ListaPuertos.Text;
            if (funcion.EditarBascula(parametros)==true)
            {
                MessageBox.Show("Balanza configurada y guardada correctamente");
            }
        }
    }
}
