using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Pedido.Servicio.Queries.DTOs;
using Servicios.Comun.Modelos;
namespace Pedido.Servicio.Queries
{
    public interface IPedidoServicoQueries
    {
        Task<RespuestaGetAll<PedidoDTO>> GetPedidos(int page, int take);
        Task<RespuestasGet<PedidoDTO>> GetPedido(int id);
    }
}
