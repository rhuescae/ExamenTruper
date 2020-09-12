

namespace Catalogo.Dominio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;
    public  class Producto
    {
        [Key]
        public int SKU { get; set; }
        public string Nombre { get; set; }
        public int Existencia { get; set; }
        public double Precio { get; set; }

    }
}
