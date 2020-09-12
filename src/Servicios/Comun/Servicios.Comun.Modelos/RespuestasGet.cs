namespace Servicios.Comun.Modelos
{
    using System.Collections.Generic;
    using System.Linq;
    public class RespuestasGet<T>
    {
        public Mensaje Mensaje { get; set; }
        public T Item { get; set; }

    }
}
