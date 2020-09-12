

namespace Pedido.Api.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using MediatR;
    using Pedido.Servicio.EventHandlers.Comandos;
    using Pedido.Servicio.Queries;
    using Pedido.Servicio.Queries.DTOs;
    using Servicios.Comun.Modelos;
    using Microsoft.AspNetCore.Authentication.JwtBearer;
    using Microsoft.AspNetCore.Authorization;
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoServicoQueries _pedidoServicoQueries;
        private readonly IMediator _mediator;


        public PedidoController(IPedidoServicoQueries pedidoServicoQueries, IMediator mediator)
        {
            _mediator = mediator;
            _pedidoServicoQueries = pedidoServicoQueries;
        }
        [HttpGet]
        public IActionResult get()
        {
            return Ok("Corriendo...");
        }

        [HttpGet]
        public async Task<RespuestaGetAll<PedidoDTO>> GetPedidos(int page = 1, int take = 10)
        {
            return await _pedidoServicoQueries.GetPedidos(page, take);
        }

        [HttpGet("{Id}")]
        public async Task<RespuestasGet<PedidoDTO>> GetPedido(int Id)
        {
            return await _pedidoServicoQueries.GetPedido(Id);
        }


        [HttpPost]
        public async Task<IActionResult> CreaPedido(PedidoCrearComando notification)
        {
            try
            
            { 
                await _mediator.Publish(notification);
                return Ok();
             }
            catch(Exception ex)
            {
                return BadRequest();
            }
        }

    }
}
