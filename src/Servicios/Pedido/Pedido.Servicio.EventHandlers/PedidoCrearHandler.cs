using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic;
using Pedido.Dominio;
using Pedido.Persistencia.BaseDatos;
using Pedido.Servicio.EventHandlers.Comandos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
namespace Pedido.Servicio.EventHandlers
{
    public class PedidoCrearHandler: INotificationHandler<PedidoCrearComando>
    {
        private readonly ApplicationDbContext _context;

        public PedidoCrearHandler(ApplicationDbContext context)
        {
            _context = context;
            
        }


        public async Task Handle(PedidoCrearComando notificacion, CancellationToken cancellationToken)
        {
            var entidad = new Dominio.Pedido();

            using (var trCrearPedido = await _context.Database.BeginTransactionAsync())
            {
                CrearPedidoDetalle(entidad, notificacion);

                CrearPedido(entidad, notificacion);

                await _context.AddAsync(entidad);
                await _context.SaveChangesAsync();
                await trCrearPedido.CommitAsync();

            }
            
        }

        private void CrearPedidoDetalle(Dominio.Pedido pedido, PedidoCrearComando notifiacion)
        {
            pedido.Items = notifiacion.Items.Select(x => new PedidoDetalle
            {
                SKU = x.SKU,
                Cantidad = x.Cantidad,
                Precio = x.Precio

            }).ToList();
            
        }

        private void CrearPedido(Dominio.Pedido pedido, PedidoCrearComando notificacion)
        {
            pedido.DateSale = DateTime.UtcNow;
            pedido.UserName = notificacion.UserName;
            pedido.Total = notificacion.Items.Sum(x => (x.Cantidad * x.Precio));
        }
    }
}
