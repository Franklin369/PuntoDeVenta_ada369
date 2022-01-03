using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ada369Csharp.Logica
{
   public class Lcontrolcobros
    {
        public int IdcontrolCobro { get; set; }
        public double Monto { get; set; }
        public DateTime Fecha { get; set; }
        public string Detalle { get; set; }
        public int IdCliente { get; set; }
        public int IdUsuario { get; set; }
        public int IdCaja { get; set; }
        public string Comprobante { get; set; }
        public double efectivo { get; set; }
        public double tarjeta { get; set; }

    }
}
