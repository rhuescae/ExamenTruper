using Pedido.Persistencia.BaseDatos;
using Pedido.Servicio.Queries.DTOs;
using Servicios.Comun.Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Servicio.Comun.Mapping;

namespace Pedido.Servicio.Queries
{
    public class PedidoServicoQueries : IPedidoServicoQueries
    {
        private readonly ApplicationDbContext _context;

        public PedidoServicoQueries(
            ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<RespuestaGetAll<PedidoDTO>> GetPedidos(int page, int take)
        {
            try
            {
                var colleccion = (await _context.Pedidos
                    .Include(x => x.Items)
                    .OrderByDescending(x => x.Id)
                    .ToListAsync()).MapTo<IEnumerable<PedidoDTO>>();
                var response = new RespuestaGetAll<PedidoDTO>()
                {
                    Mensaje = new Mensaje { EsError = false, Codigo = "100", Descripcion = "Se consultaron los pedidos correctamente" }
                    ,
                    DataCollection = colleccion
                };

                return response;
            }
            catch (Exception ex)
            {
                return new RespuestaGetAll<PedidoDTO>()
                {
                    Mensaje = new Mensaje { EsError = true, Codigo = "101", Descripcion = "Ocurrio un problema al consultar pedidos" },

                };

            }
        }
        public async Task<RespuestasGet<PedidoDTO>> GetPedido(int id)
        {
            try { 
            var colleccion = (await _context.Pedidos
                    .Include(x => x.Items)
                    .SingleAsync(x => x.Id == id)
                    ).MapTo<PedidoDTO>();
            var response = new RespuestasGet<PedidoDTO>()
            {
                Mensaje = new Mensaje { EsError = false, Codigo = "100", Descripcion = "Se consultaron los pedidos correctamente" },
                Item = colleccion
            };

            return response;
        }
            catch (Exception ex)
            {
                return new RespuestasGet<PedidoDTO>()
                {
                    Mensaje = new Mensaje { EsError = true, Codigo = "101", Descripcion = "Ocurrio un problema al consultar pedidos" },

                };

            }
        }
    }
}
