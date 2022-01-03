using Ada369Csharp.Presentacion;
using Ada369Csharp.Presentacion.AsistenteInstalacion;
using Ada369Csharp.Presentacion.Compras;
using Ada369Csharp.Presentacion.Menu;
using Ada369Csharp.Sunat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace Ada369Csharp
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var frm = new LOGIN();
            frm.FormClosed += Frm_FormClosed;
            frm.ShowDialog();
            Application.Run();

        }

        private static void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
        }
    }
}
