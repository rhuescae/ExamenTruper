

namespace Servicios.Comun.Modelos
{
    using System.Collections.Generic;
    public class RespuestaGetAll<T>
    {
        public Mensaje Mensaje { get; set; }
        public IEnumerable<T> DataCollection { get; set; }
    }
}
