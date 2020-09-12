using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.VisualBasic;
using Pedido.Dominio;
using System;

using System.Collections.Generic;
namespace Pedido.Persistencia.BaseDatos.Configuracion
{
    public class PedidoConfiguracion
    {
        public PedidoConfiguracion(EntityTypeBuilder<Dominio.Pedido> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.UserName).HasMaxLength(150);

            
            

        }
    }
}
