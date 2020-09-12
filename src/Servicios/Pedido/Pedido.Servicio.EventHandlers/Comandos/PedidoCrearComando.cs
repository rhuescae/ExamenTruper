using Pedido.Dominio;
using System.Collections.Generic;
using MediatR;

namespace Pedido.Servicio.EventHandlers.Comandos
{
    public class PedidoCrearComando : INotification
    {
        public string UserName { get; set; }
        public IEnumerable<PedidoCrearDetalle> Items { get; set; } = new List<PedidoCrearDetalle>();
 
    }

    public class PedidoCrearDetalle
    {
        public int SKU { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
    }
}
