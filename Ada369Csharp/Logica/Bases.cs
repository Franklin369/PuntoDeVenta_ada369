using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using System.Windows.Forms;
using System.Drawing;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Net.Mail;
using System.Net;
using Ada369Csharp.CONEXION;

namespace Ada369Csharp.Logica
{
   public  class Bases
    {
        public void DiseñoDatagridview(ref DataGridView Listado)
        {
            Listado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Listado.EnableHeadersVisualStyles = false;
            DataGridViewCellStyle cabecera = new DataGridViewCellStyle();
            cabecera.BackColor = Color.White;
            cabecera.ForeColor = Color.Black;
            cabecera.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            Listado.ColumnHeadersDefaultCellStyle = cabecera;
        }
        public void DiseñoDatagridviewEliminar(ref DataGridView Listado)
        {
            foreach (DataGridViewRow row in Listado.Rows)
            {
                string estado;
                estado = row.Cells["Estado"].Value.ToString();
                if (estado == "ELIMINADO")
                {
                    row.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Strikeout | FontStyle.Bold);
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }
        public static void Obtener_serialPC(ref string serial)
        {
            ManagementObject serialPC = new ManagementObject("Win32_PhysicalMedia='\\\\.\\PHYSICALDRIVE0'");
            serial = serialPC.Properties["SerialNumber"].Value.ToString();
            serial =Encriptar ( serial.Trim());
        }
        public static void Cambiar_idioma_regional()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-Es");
            System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ",";
            System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ",";
            System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(4);

        }
        public static void Multilinea(ref DataGridView List)
        {
            List.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            List.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            List.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            List.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            List.EnableHeadersVisualStyles = false;
            List.BackgroundColor = Color.White;
            List.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            List.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            List.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Gainsboro;
            List.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;



            DataGridViewCellStyle styCabeceras = new DataGridViewCellStyle();
            styCabeceras.BackColor = System.Drawing.Color.White;
            styCabeceras.ForeColor = System.Drawing.Color.Black;
            styCabeceras.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            List.ColumnHeadersDefaultCellStyle = styCabeceras;
        }
        public static void MultilineaTemaOscuro(ref DataGridView List)
        {
            List.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            List.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            List.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            List.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            List.BackgroundColor = Color.FromArgb(35, 35, 35);

            List.EnableHeadersVisualStyles = false;

            List.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(35, 35, 35);
            List.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            List.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(23, 23, 23);
            List.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;

            DataGridViewCellStyle styCabeceras = new DataGridViewCellStyle();
            styCabeceras.BackColor = System.Drawing.Color.FromArgb(35,35,35);
            styCabeceras.ForeColor = System.Drawing.Color.White;
            styCabeceras.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            List.ColumnHeadersDefaultCellStyle = styCabeceras;
        }
        public  void MultilineaCobros(ref DataGridView List)
        {
            List.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            List.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            List.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            List.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            List.EnableHeadersVisualStyles = false;
            DataGridViewCellStyle styCabeceras = new DataGridViewCellStyle();
            styCabeceras.BackColor = System.Drawing.Color.FromArgb (39, 39, 39);
            styCabeceras.ForeColor = System.Drawing.Color.White;
            styCabeceras.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            List.ColumnHeadersDefaultCellStyle = styCabeceras;
        }
        public static string Encriptar(string texto)
        {
            try
            {
                byte[] keyArray;

                byte[] Arreglo_a_Cifrar = UTF8Encoding.UTF8.GetBytes(texto);


                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();

                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(Desencryptacion.appPwdUnique));

                hashmd5.Clear();

                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();

                tdes.Key = keyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;

                ICryptoTransform cTransform = tdes.CreateEncryptor();

                byte[] ArrayResultado = cTransform.TransformFinalBlock(Arreglo_a_Cifrar, 0, Arreglo_a_Cifrar.Length);

                tdes.Clear();

                texto = Convert.ToBase64String(ArrayResultado, 0, ArrayResultado.Length);

            }
            catch (Exception)
            {

            }
            return texto;
        }

        public static string Desencriptar(string textoEncriptado)
        {
            try
            {
                byte[] keyArray;
                byte[] Array_a_Descifrar = Convert.FromBase64String(textoEncriptado);

                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();

                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(Desencryptacion.appPwdUnique));

                hashmd5.Clear();

                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();

                tdes.Key = keyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;

                ICryptoTransform cTransform = tdes.CreateDecryptor();

                byte[] resultArray = cTransform.TransformFinalBlock(Array_a_Descifrar, 0, Array_a_Descifrar.Length);

                tdes.Clear();
                textoEncriptado = UTF8Encoding.UTF8.GetString(resultArray);

            }
            catch (Exception)
            {

            }
            return textoEncriptado;
        }
        public static bool  enviarCorreo(string emisor, string password, string mensaje, string asunto, string destinatario, string ruta)
        {
            try
            {
                MailMessage correos = new MailMessage();
                SmtpClient envios = new SmtpClient();
                correos.To.Clear();
                correos.Body = "";
                correos.Subject = "";
                correos.Body = mensaje;
                correos.Subject = asunto;
                correos.IsBodyHtml = true;
                correos.To.Add((destinatario));
                correos.From = new MailAddress(emisor);
                envios.Credentials = new NetworkCredential(emisor, password);
                envios.Host = "smtp.gmail.com";
                envios.Port = 587;
                envios.EnableSsl = true;
                envios.Send(correos);
                return true;
            }
            catch (Exception )
            {
                MessageBox.Show("ERROR, revisa tu correo Electronico", "Restauracion de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

        }
        public static object  Separador_de_Numeros(TextBox CajaTexto, KeyPressEventArgs e)
        {
            Cambiar_idioma_regional();
            if ((e.KeyChar == '.') || (e.KeyChar == ','))
            {

                e.KeyChar = System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];

            }

            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '.' && (~CajaTexto.Text.IndexOf(".")) != 0)
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else if (e.KeyChar == ',')
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;

            }
            return null;
        }
        public static string ObtenerIp( ref string valorIp)
        {
            valorIp = Dns.GetHostEntry(System.Environment.MachineName).AddressList.FirstOrDefault((i) => i.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).ToString();
            return valorIp;
        }
     
            

    }
}
