

namespace Pedido.Dominio
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class Pedido
    {
        [Key]
        public int Id { get; set; }
        public double Total { get; set; }
        public DateTime DateSale { get; set; }
        public string UserName { get; set; }

        public ICollection<PedidoDetalle> Items { get; set; } = new List<PedidoDetalle>();
    }
}
