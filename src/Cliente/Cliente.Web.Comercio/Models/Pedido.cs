using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cliente.Web.Comercio.Models
{
    public class Pedido
    {

        public int Id { get; set; }
        public double Total { get; set; }
        public DateTime DateSale { get; set; }
        public string UserName { get; set; }

        public ICollection<PedidoDetalle> Items { get; set; } = new List<PedidoDetalle>();
    }
}
