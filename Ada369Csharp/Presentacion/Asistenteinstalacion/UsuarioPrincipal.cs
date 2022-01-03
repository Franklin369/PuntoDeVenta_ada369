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
using System.Management;
using Ada369Csharp.Logica;
using Ada369Csharp.Datos;
using Sunat.Logica;

namespace Ada369Csharp.Presentacion.AsistenteInstalacion
{
    public partial class UsuarioPrincipal : Form
    {
        public UsuarioPrincipal()
        {
            InitializeComponent();
        }
        string lblIDSERIAL;
        int idusuario;
        private void UsuarioPrincipal_Load(object sender, EventArgs e)
        {
            Panel2.Location = new Point((Width - Panel2.Width) / 2, (Height - Panel2.Height) / 2);

            Bases.Obtener_serialPC(ref lblIDSERIAL);
        }
        private void Insertarusuario()
        {
            var funcion = new Dusuarios();
            var parametros = new Lusuarios();
            parametros.Nombre = txtnombre.Text;
            parametros.Login = TXTUSUARIO.Text;
            parametros.Password = Bases.Encriptar(TXTCONTRASEÑA.Text);
            parametros.Rol = "Administrador";
            parametros.Correo = "-";
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            PictureBox2.Image.Save(ms, PictureBox2.Image.RawFormat);
            parametros.Icono = ms.GetBuffer();
            funcion.InsertarUsuarios(parametros);
        }
      
        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (txtnombre.Text != "" && TXTCONTRASEÑA.Text != "" && TXTUSUARIO.Text != "")
            {
                if (TXTCONTRASEÑA.Text == txtconfirmarcontraseña.Text)
                {
                    try
                    {
                        Insertarusuario();
                        InsertacodigosUbigeo();
                        InsertarCodProdSunat();
                        InsertarTipoNc();
                        InsertarTipoNd();
                        InsertarUmedida();
                        Insertar_licencia_de_prueba_30_dias();
                        insertar_cliente_standar();
                        insertar_grupo_por_defecto();
                        insertar_proveedor_standar();
                        insertar_inicio_De_sesion();
                        Insertar_Modulos();
                        insertarPermisos();
                        MessageBox.Show("!LISTO! RECUERDA que para Iniciar Sesión tu Usuario es: " + TXTUSUARIO.Text + " y tu Contraseña es: " + TXTCONTRASEÑA.Text, "Registro Exitoso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                        Dispose();
                        Application.Exit();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no Coinciden", "Contraseñas Incompatibles", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("Falta ingresar Datos", "Datos incompletos", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            }
        }
        private void ObtenerIdUsuario()
        {
            Dusuarios funcion = new Dusuarios();
            funcion.ObtenerIdUsuario(ref idusuario, TXTUSUARIO.Text);

        }
        private void insertarPermisos()
        {
            ObtenerIdUsuario();
            DataTable dt = new DataTable();
            Dmodulos funcionModulos = new Dmodulos();
            funcionModulos.mostrar_Modulos(ref dt);
            foreach (DataRow row in dt.Rows)
            {
                int idModulo = Convert.ToInt32(row["IdModulo"]);
                Lpermisos parametros = new Lpermisos();
                Dpermisos funcion = new Dpermisos();
                parametros.IdModulo = idModulo;
                parametros.IdUsuario = idusuario;
                funcion.Insertar_Permisos(parametros);

            }
           
        }
        private void Insertar_Modulos()
        {
            Lmodulos parametros = new Lmodulos();
            Dmodulos funcion = new Dmodulos();
            var Modulos = new List<string> { "Cobrar", "Configurar", "Reportes", "Panel Control", "Sunat", "Ingresos", "Gastos", "Cerrar caja"};
            foreach (var Modulo in Modulos)
            {
                parametros.Modulo = Modulo;
                funcion.Insertar_Modulos(parametros);
            }
        }
        private void InsertarUmedida()
        {
            var funcion = new DunidadM();
            funcion.InsertarUmedida();
        }
        private void InsertarTipoNc()
        {
            var funcion = new Dtiponotascredito();
            funcion.InsertarTipoNc();
        }
        private void InsertarTipoNd()
        {
            var funcion = new Dnotasdebito();
            funcion.InsertarTiposNd();
        }
        private void InsertacodigosUbigeo()
        {
            var funcion = new Dcodigosubigeo();
            funcion.Insertarcodigosubigeo();
        }
        private void InsertarCodProdSunat()
        {
            var funcion = new DcodigosProdsunat();
            funcion.InsertarcodigosProductosSunat();
        }
        private void Insertar_licencia_de_prueba_30_dias()
        {
            DateTime today = DateTime.Now;
            DateTime fechaFinal = today.AddDays(30);
            txtfechaFinalOK.Text = Convert.ToString(fechaFinal);
            string SERIALpC;
            SERIALpC = lblIDSERIAL;
            string FECHA_FINAL;
            FECHA_FINAL = Bases.Encriptar(this.txtfechaFinalOK.Text.Trim());
            string estado;
            estado = Bases.Encriptar("?ACTIVO?");
            string fecha_activacion;
            fecha_activacion = Bases.Encriptar(this.txtfechaInicio.Text.Trim());


            try
            {


                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("Insertar_marcan", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@s", SERIALpC);
                cmd.Parameters.AddWithValue("@f", FECHA_FINAL);
                cmd.Parameters.AddWithValue("@e", estado);
                cmd.Parameters.AddWithValue("@fa", fecha_activacion);
                cmd.ExecuteNonQuery();
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void insertar_cliente_standar()
        {
            try
            {
                var funcion = new Dclientes();
                var parametros = new Lclientes();
                parametros.Nombre = "-";
                parametros.Nrodoc = "-";
                parametros.Celular = "0";
                parametros.Direccion = "-";
                parametros.Tipodoc = "-";
                funcion.insertar_clientes(parametros);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void insertar_grupo_por_defecto()
        {
            try
            {


                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("insertar_Grupo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Grupo", "General");
                cmd.Parameters.AddWithValue("@Por_defecto", "Si");

                cmd.ExecuteNonQuery();
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void insertar_inicio_De_sesion()
        {
            var funcion = new DiniciosSesion();
            var parametros = new LiniciosSesion();
            parametros.IdUsuario = 1;
            funcion.insertarInicioSesion(parametros);
        }
        private void insertar_proveedor_standar()
        {
            var funcion = new Dproveedores();
            var parametros = new Lproveedores();
            parametros.Nombre = "GENERICO";
            parametros.Direccion = "0";
            parametros.IdentificadorFiscal = "0";
            parametros.Celular = "0";
            parametros.Estado = "0";
            parametros.Saldo = 0;
            funcion.insertar_Proveedores(parametros);
        }
    }
}
