using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using Identidad.Servicio.EventHandlers.Comandos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace Identidad.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class IdentidadController : ControllerBase
    {
        private readonly IMediator _mediator;

        public IdentidadController(
            IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public IActionResult get()
        {
            return Ok("Corriendo...");
        }
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPost]
        public async Task<IActionResult> CreaUsuario(CrearUsuarioComando command)
        {
            if (ModelState.IsValid)
            {
                var result = await _mediator.Send(command);

                if (!result.Succeeded)
                {
                    return BadRequest(result.Errors);
                }

                return Ok();
            }

            return BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> Autenticacion(AutenticacionUsuarioComandos command)
        {
            if (ModelState.IsValid)
            {
                var result = await _mediator.Send(command);

                if (result.EsError)
                {
                    return BadRequest("Access denied");
                }

                return Ok(result);
            }

            return BadRequest();
        }
    }
}
