using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Data.SqlClient;

using System.Globalization;
using System.Threading;
using Ada369Csharp.Datos;
namespace Ada369Csharp.Presentacion.CAJA
{
    public partial class Cierrecaja : UserControl
    {
        public Cierrecaja()
        {
            InitializeComponent();
        }
        public static double dineroencaja;
        int idcaja;
        DateTime fechaInicial;
        public static  double saldoInicial;
        DateTime fechafinal=DateTime.Now ;
        public static double ventasefectivo;
        public static double ingresosefectivo;
        public static double gastosefectivo;
        public static double ventascredito;
        public static double ventastarjeta;
        //---
        public static  double efectivoEnCaja;
        public static  double ventastotales;
        double creditosPorPagar;
        double creditosPorCobrar;
        public static double ganancias;
        public static double Ingresos;
        public static double Egresos;
        public static double cobrosEfectivo;
        public static double cobrosTarjeta;
        public static double CobrosTotal;
        private void Cierrecaja_Load(object sender, EventArgs e)
        {
            Mostrar_cierres_de_caja_pendiente();
            lbldesdehasta.Text = "Corte de caja desde: " + fechaInicial + " Hasta: " + DateTime.Now;
            obtener_saldo_inicial();
            obtener_ventas_en_efectivo();
            obtener_gastos_por_turno();
            obtener_ingresos_por_turno();
            obtener_creditosPorPagar();
            mostrar_cobros_efectivo_por_turno();
            mostrar_cobros_tarjeta_por_turno();
            sumar_CreditoPorCobrar();
            M_ventas_Tarjeta_por_turno();
            M_ventas_credito_por_turno();
            calcular();
        }
        private void calcular()
        {
            CobrosTotal = cobrosEfectivo + cobrosTarjeta;
            efectivoEnCaja = saldoInicial + ventasefectivo + ingresosefectivo - gastosefectivo+cobrosEfectivo;
            ventastotales = ventasefectivo + ventascredito + ventastarjeta;
            //---Mostrar en labels
            lblDineroEncaja.Text = efectivoEnCaja.ToString();
            lblVentasTotal.Text = ventastotales.ToString();
            lbltotalventas.Text = ventastotales.ToString();
            lbldineroTotalCaja.Text = efectivoEnCaja.ToString();
            Ingresos = saldoInicial + ventasefectivo + ingresosefectivo+ventastarjeta+cobrosTarjeta+cobrosEfectivo;
            Egresos = gastosefectivo;
        }
        private void obtener_ingresos_por_turno()
        {
            Obtener_datos.sumar_ingresos_por_turno(idcaja, fechaInicial, fechafinal, ref ingresosefectivo);
            lblingresos.Text = ingresosefectivo.ToString ();
        }
        private void obtener_gastos_por_turno()
        {
            Obtener_datos.sumar_gastos_por_turno(idcaja, fechaInicial, fechafinal, ref gastosefectivo);
            lblgastos.Text = gastosefectivo.ToString();
        }
        private void obtener_ventas_en_efectivo()
        {
            Obtener_datos.mostrar_ventas_en_efectivo_por_turno(idcaja, fechaInicial, fechafinal, ref ventasefectivo);
            lblventasefectivo.Text = ventasefectivo.ToString();
            lblventasefectivoGeneral.Text = ventasefectivo.ToString();
        }
        private void obtener_saldo_inicial()
        {
            lblfondodeCaja.Text =saldoInicial.ToString(); 
        }
        private void obtener_creditosPorPagar()
        {
            Obtener_datos.sumar_CreditoPorPagar(idcaja, fechaInicial, fechafinal, ref creditosPorPagar);
            lblPorpagar.Text = creditosPorPagar.ToString ();
        }
        private  void sumar_CreditoPorCobrar()
        {
            Obtener_datos.sumar_CreditoPorCobrar(idcaja, fechaInicial, fechafinal, ref creditosPorCobrar);
            lblPorCobrar.Text = creditosPorCobrar.ToString();

        }
        private void Mostrar_cierres_de_caja_pendiente()
        {
            DataTable dt = new DataTable();
            Obtener_datos.mostrar_cierre_de_caja_pendiente(ref dt);
            foreach (DataRow dr in dt.Rows)
            {
                idcaja = Convert.ToInt32(dr["Id_caja"]);
                fechaInicial = Convert.ToDateTime(dr["fechainicio"]);
                saldoInicial = Convert.ToDouble(dr["SaldoInicial"]);
            }
        }

        private void M_ventas_Tarjeta_por_turno()
        {
            Obtener_datos.M_ventas_Tarjeta_por_turno(idcaja, fechaInicial, fechafinal, ref ventastarjeta);
            lblventas_Tarjeta.Text = ventastarjeta.ToString ();
        }
        private void mostrar_cobros_efectivo_por_turno()
        {
            Obtener_datos.mostrar_cobros_en_efectivo_por_turno(idcaja, fechaInicial, fechafinal, ref cobrosEfectivo);
            lblabonosEfectivo.Text = cobrosEfectivo.ToString();
        }
        private void mostrar_cobros_tarjeta_por_turno()
        {
            Obtener_datos.mostrar_cobros_tarjeta_por_turno(idcaja, fechaInicial, fechafinal, ref cobrosTarjeta);
            lblabonosTarjeta.Text = cobrosTarjeta.ToString();
        }
        private void M_ventas_credito_por_turno()
        {
            Obtener_datos.M_ventas_credito_por_turno(idcaja, fechaInicial, fechafinal, ref ventascredito);
            lblVentasAcredito.Text = ventascredito.ToString ();
        }

        private void Label20_Click(object sender, EventArgs e)
        {

        }

        private void BtnCerrar_turno_Click(object sender, EventArgs e)
        {          
            var ctl = new CierreTurno();
            ctl.Size = new Size(Width, Height);
            this.Controls.Add(ctl);
            ctl.BringToFront();
        }

        private void CIERRE_DE_CAJA_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

       

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
