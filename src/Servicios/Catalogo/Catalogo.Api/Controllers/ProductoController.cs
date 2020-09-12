using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Catalogo.Servicio.Queries;
using Catalogo.Servicio.Queries.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Servicios.Comun.Modelos;
using System.Text.Json;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace Catalogo.Api.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoQueryService _productoQueryService;

        public ProductoController(IProductoQueryService productoQueryService)
        {
            _productoQueryService = productoQueryService;
            
        }

        [HttpGet]
        public async Task<IActionResult> GetProductos(int page = 2, int take = 10, string skus = null)
        {
            IEnumerable<int> productos = null;
            if (!string.IsNullOrEmpty(skus))
            {
                productos = skus.Split(',').Select(x => Convert.ToInt32(x));
            }

            var resultProductos =  await _productoQueryService.GetProductosAsync(page, take, productos);
            return Ok(resultProductos);
            //return Ok(new RespuestasGet<ProductoDto> { Mensaje = new Mensaje { EsError = false,Codigo= "1000",Descripcion = "Se consulto correctamente la información" }, DataCollection = resultProductos.ToList() });
        }
    }
}
