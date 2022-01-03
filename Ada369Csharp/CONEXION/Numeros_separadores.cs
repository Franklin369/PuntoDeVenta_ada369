using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ada369Csharp.CONEXION
{
    class Numeros_separadores
    {
        public static void Separador_de_Numeros(System.Windows.Forms.TextBox CajaTexto, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
          
               else if (!(e.KeyChar ==  CajaTexto.Text.IndexOf('.')))
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

        }
    }
}
