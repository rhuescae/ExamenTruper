
using Servicios.Comun.Modelos;


namespace Catalogo.Servicio.Queries
{
    
    
    using System.Collections.Generic;
     
    using Catalogo.Servicio.Queries.DTOs;
    using System.Threading.Tasks;
    public interface IProductoQueryService
    {
        Task<RespuestaGetAll<ProductoDto>> GetProductosAsync(int page, int take, IEnumerable<int> productos = null);

    }
}
