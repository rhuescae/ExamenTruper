namespace Pedido.Servicio.Queries.DTOs
{
    using System;
    using System.Collections.Generic;
    public class PedidoDTO
    {
        public int Id { get; set; }
        public double Total { get; set; }
        public DateTime DateSale { get; set; }
        public string UserName { get; set; }

        public ICollection<PedidoDetalleDTO> Items { get; set; } = new List<PedidoDetalleDTO>();
    }
}
