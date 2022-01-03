using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ada369Csharp.Logica
{
  public  class Ldetallecompra
    {
        public int IdDetallecompra { get; set; }
        public int IdCompra { get; set; }
        public double Cantidad { get; set; }
        public double Costo { get; set; }
        public string Moneda { get; set; }
        public int IdProducto { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
    }
}
