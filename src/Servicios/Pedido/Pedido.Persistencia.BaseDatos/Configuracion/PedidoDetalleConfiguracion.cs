using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pedido.Dominio;


namespace Pedido.Persistencia.BaseDatos.Configuracion
{
    public class PedidoDetalleConfiguracion
    {
        public PedidoDetalleConfiguracion(EntityTypeBuilder<Dominio.PedidoDetalle> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);
            

        }

        }
}
