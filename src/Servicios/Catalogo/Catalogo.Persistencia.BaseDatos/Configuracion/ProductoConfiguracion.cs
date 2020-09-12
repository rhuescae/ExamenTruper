
namespace Catalogo.Persistencia.BaseDatos.Configuracion
{
    using Catalogo.Dominio;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ProductoConfiguracion
    {
        public ProductoConfiguracion(EntityTypeBuilder<Producto> entityBuilder)
        {
            entityBuilder.HasIndex(x => x.SKU);
            entityBuilder.Property(x => x.SKU).IsRequired();
            entityBuilder.Property(x => x.Nombre).IsRequired().HasMaxLength(200);
            entityBuilder.Property(x => x.Existencia).IsRequired();
            entityBuilder.Property(x => x.Precio).IsRequired();

            var productos = new List<Producto>();
            productos.Add(new Producto() { SKU = 19806, Nombre = "PP-10|CARRETILLA DOBLE LLANTA,MGOS/MAD 2,10FT", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 31417, Nombre = "TRS-5F-GR|PALA PARA CANERIAS 5", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 74609, Nombre = "ET-CB-EP-30 ETIQUETA CODIGO DE BARRAS", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 74632, Nombre = "ET-CB-R-16MF ETIQUETA CODIGO DE BARRAS", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 74633, Nombre = "ET-CB-R8M-KID ETIQUETA CODIGO DE BARRAS", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 74639, Nombre = "ET-CB-MARTE-TP-M", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 86632, Nombre = "ENSAMBLE DE TARIMA Y CONTENEDOR MADERA", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 86714, Nombre = "SUBENSAMBLE TUBO-SOLERA R-4 FOR", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 86910, Nombre = "TARIMA DE 1.0X 1.2 HOME DEPOT", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 87010, Nombre = "DISPLAY-36-PRL-E-LW/36-R16AM-E-LW S/PROD", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 88836, Nombre = "TARIMA P/CARRETILLA CAT-KID", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 88980, Nombre = "TARIMA PARA CONTENEDOR #1 Y #2 DE EXHIBI", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 89177, Nombre = "TARIMA PARA CAT KID", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 89509, Nombre = "BOLSA TORNILLOS|BOLSA TORN. CAT-KIT TUB.", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 907855, Nombre = "R274-SME-10X-2|TUERCA HEXAGONAL M14 (ACERO)", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 910606, Nombre = "R22-TAPI-13|BARRA SOPORTE MOTOR IZQUIERDA (ACERO)", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 910607, Nombre = "R23-TAPI-13|TORNILLO HEXAGONAL M8X40MM (ACERO)", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 910608, Nombre = "R24-TAPI-13|RONDANA PLANA Ø8 (ACERO)", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 910609, Nombre = "R25-TAPI-13|MONTURA MOTOR (ACERO)", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 910610, Nombre = "R26-TAPI-13|RONDANA PLANA Ø12 (ACERO)", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 910611, Nombre = "R27-TAPI-13|RONDANA DE PRESION Ø12 (ACERO)", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 910612, Nombre = "R28-TAPI-13|TUERCA HEXAGONAL M12 (ACERO)", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 910613, Nombre = "R29.1-TAPI-13|VENTLADOR (PLASTICO)", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 910614, Nombre = "R29.2-TAPI-13|CAJA DEL CAPACITOR (ACERO)", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 910615, Nombre = "R29.3-TAPI-13|RONDANA PLANA Ø4 (ACERO)", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 910616, Nombre = "R29.4-TAPI-13|TORNILLO PAN M4X6MM  (ACERO)", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 911925, Nombre = "R81-CEP-13|BALERO DE BOLAS 6203 (ACERO-PLASTICO)", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 911926, Nombre = "R82-CEP-13|ARMAZON SUPERIOR (ACERO)", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 911927, Nombre = "R82.2-CEP-13|RONDANA DENTADA   Ø4 (ACERO)", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 911928, Nombre = "R83-CEP-13|OPRESOR DE CABLE (PLASTICO)", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 911929, Nombre = "R83.1-CEP-13|TORNILLO PAN M4X14MM (ACERO)", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 911930, Nombre = "R84-CEP-13|RONDANA PLANA Ø4 (ACERO)", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 911931, Nombre = "R85-CEP-13|DEFLECTOR DE ASERRIN (ACERO)", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 911932, Nombre = "R85.1-CEP-13|TORNILLO PAN M4X8MM (ACERO)", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 911933, Nombre = "R86-CEP-13|TUERCA HEXAGONAL M20 (ACERO)", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 911934, Nombre = "R87-CEP-13|SOPORTE DERECHO (ACERO)", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 911935, Nombre = "R88-CEP-13|RESORTE (ACERO)", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 911936, Nombre = "R89-CEP-13|FRENO DE SEGURIDAD (ACERO)", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 911937, Nombre = "R90-CEP-13|TORNILLO ALLEN M5X12MM (ACERO)", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 911938, Nombre = "R91-CEP-13|PLACA DE CONEXION (ACERO)", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 911939, Nombre = "R92-CEP-13|RONDANA PLANA Ø8 (ACERO)", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 911940, Nombre = "R93-CEP-13|TORNILLO HEXAGONAL M8X16MM (ACERO)", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 999965, Nombre = "LJ-NS-278|LJ-NS-278", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 999971, Nombre = "LJ-NS-285|LJ-NS-285", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 999972, Nombre = "LJ-NS-286|LJ-NS-286", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 999973, Nombre = "LJ-NS-287|LJ-NS-287", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 999975, Nombre = "LJ-NS-289|LJ-NS-289", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 999976, Nombre = "LJ-NS-290|LJ-NS-290", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 999977, Nombre = "LJ-NS-291|LJ-NS-291", Existencia = 300, Precio = 100 });
            productos.Add(new Producto() { SKU = 999979, Nombre = "LJ-NS-293|LJ-NS-293", Existencia = 300, Precio = 100 });
            entityBuilder.HasData(productos);
        }
    }
}
