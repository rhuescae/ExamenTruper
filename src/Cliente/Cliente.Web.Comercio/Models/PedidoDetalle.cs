using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cliente.Web.Comercio.Models
{
    public class PedidoDetalle
    {

        public int Id { get; set; }
        public int SKU { get; set; }

        public int Cantidad { get; set; }

        public double Precio { get; set; }
    }
}
