using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ada369Csharp.Logica
{
  public  class LKardex
    {
        public int Id_kardex { get; set; }
        public DateTime Fecha { get; set; }
        public string Motivo { get; set; }
        public double  Cantidad { get; set; }
        public int Id_producto { get; set; }
        public int Id_usuario { get; set; }
        public string Tipo { get; set; }
        public string Estado { get; set; }
        public double Total { get; set; }
        public double Costo_unt { get; set; }
        public double Habia { get; set; }
        public double Hay { get; set; }
        public int Id_caja { get; set; }

    }
}
