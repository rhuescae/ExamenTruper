
namespace Servicios.Comun.Modelos
{
    using System.Collections.Generic;
    using System.Linq;

    public class DataCollection<T>
    {
       public IEnumerable<T> Items { get; set; }
    }
}
