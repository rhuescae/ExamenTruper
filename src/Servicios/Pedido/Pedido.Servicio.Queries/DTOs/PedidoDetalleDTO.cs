
namespace Pedido.Servicio.Queries.DTOs
{
    public class PedidoDetalleDTO
    {

        public int Id { get; set; }
        public int SKU { get; set; }

        public int Cantidad { get; set; }

        public double Precio { get; set; }
    }
}
