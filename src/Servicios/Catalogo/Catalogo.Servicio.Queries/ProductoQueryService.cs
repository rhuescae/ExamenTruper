using Catalogo.Persistencia.BaseDatos;
using System;
using System.Collections.Generic;
using Catalogo.Servicio.Queries.DTOs;
using System.Threading.Tasks;
using System.Linq;
using Servicio.Comun.Mapping;
using Microsoft.EntityFrameworkCore;
using Servicios.Comun.Modelos;

namespace Catalogo.Servicio.Queries
{
   
    
    public class ProductoQueryService: IProductoQueryService
    {
        private readonly AplicationBDContext _context;
        public ProductoQueryService(AplicationBDContext context)
        {
            _context = context;
        }

        public async Task<RespuestaGetAll<ProductoDto>> GetProductosAsync(int page, int take, IEnumerable<int> productos = null)
        {
            try
            {
                var colleccion = (await _context.Productos.Where(x => productos == null || productos.Contains(x.SKU))
                    .OrderByDescending(x => x.SKU)
                    .ToListAsync()).MapTo<IEnumerable<ProductoDto>>();
                var response = new RespuestaGetAll<ProductoDto>() {
                    Mensaje = new Mensaje { EsError = false, Codigo = "100", Descripcion = "Se consultaron productos correctamente" }
                    , DataCollection = colleccion
                };

                return response;
            }
            catch (Exception ex)
            {
                return new RespuestaGetAll<ProductoDto>()
                {
                    Mensaje = new Mensaje { EsError = true, Codigo = "101", Descripcion = "Ocurrio un problema al consultar productos" },
                    
                };

            }


            //return colleccion.MapTo<List<ProductoDto>>();
        }

       

    }
}
