using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalogo.Persistencia.BaseDatos.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Catalogo");

            migrationBuilder.CreateTable(
                name: "Productos",
                schema: "Catalogo",
                columns: table => new
                {
                    SKU = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 200, nullable: false),
                    Existencia = table.Column<int>(nullable: false),
                    Precio = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.SKU);
                });

            migrationBuilder.InsertData(
                schema: "Catalogo",
                table: "Productos",
                columns: new[] { "SKU", "Existencia", "Nombre", "Precio" },
                values: new object[,]
                {
                    { 19806, 300, "PP-10|CARRETILLA DOBLE LLANTA,MGOS/MAD 2,10FT", 100.0 },
                    { 911926, 300, "R82-CEP-13|ARMAZON SUPERIOR (ACERO)", 100.0 },
                    { 911927, 300, "R82.2-CEP-13|RONDANA DENTADA   Ø4 (ACERO)", 100.0 },
                    { 911928, 300, "R83-CEP-13|OPRESOR DE CABLE (PLASTICO)", 100.0 },
                    { 911929, 300, "R83.1-CEP-13|TORNILLO PAN M4X14MM (ACERO)", 100.0 },
                    { 911930, 300, "R84-CEP-13|RONDANA PLANA Ø4 (ACERO)", 100.0 },
                    { 911931, 300, "R85-CEP-13|DEFLECTOR DE ASERRIN (ACERO)", 100.0 },
                    { 911932, 300, "R85.1-CEP-13|TORNILLO PAN M4X8MM (ACERO)", 100.0 },
                    { 911933, 300, "R86-CEP-13|TUERCA HEXAGONAL M20 (ACERO)", 100.0 },
                    { 911934, 300, "R87-CEP-13|SOPORTE DERECHO (ACERO)", 100.0 },
                    { 911935, 300, "R88-CEP-13|RESORTE (ACERO)", 100.0 },
                    { 911936, 300, "R89-CEP-13|FRENO DE SEGURIDAD (ACERO)", 100.0 },
                    { 911937, 300, "R90-CEP-13|TORNILLO ALLEN M5X12MM (ACERO)", 100.0 },
                    { 911938, 300, "R91-CEP-13|PLACA DE CONEXION (ACERO)", 100.0 },
                    { 911939, 300, "R92-CEP-13|RONDANA PLANA Ø8 (ACERO)", 100.0 },
                    { 911940, 300, "R93-CEP-13|TORNILLO HEXAGONAL M8X16MM (ACERO)", 100.0 },
                    { 999965, 300, "LJ-NS-278|LJ-NS-278", 100.0 },
                    { 999971, 300, "LJ-NS-285|LJ-NS-285", 100.0 },
                    { 999972, 300, "LJ-NS-286|LJ-NS-286", 100.0 },
                    { 999973, 300, "LJ-NS-287|LJ-NS-287", 100.0 },
                    { 999975, 300, "LJ-NS-289|LJ-NS-289", 100.0 },
                    { 999976, 300, "LJ-NS-290|LJ-NS-290", 100.0 },
                    { 911925, 300, "R81-CEP-13|BALERO DE BOLAS 6203 (ACERO-PLASTICO)", 100.0 },
                    { 910616, 300, "R29.4-TAPI-13|TORNILLO PAN M4X6MM  (ACERO)", 100.0 },
                    { 910615, 300, "R29.3-TAPI-13|RONDANA PLANA Ø4 (ACERO)", 100.0 },
                    { 910614, 300, "R29.2-TAPI-13|CAJA DEL CAPACITOR (ACERO)", 100.0 },
                    { 31417, 300, "TRS-5F-GR|PALA PARA CANERIAS 5", 100.0 },
                    { 74609, 300, "ET-CB-EP-30 ETIQUETA CODIGO DE BARRAS", 100.0 },
                    { 74632, 300, "ET-CB-R-16MF ETIQUETA CODIGO DE BARRAS", 100.0 },
                    { 74633, 300, "ET-CB-R8M-KID ETIQUETA CODIGO DE BARRAS", 100.0 },
                    { 74639, 300, "ET-CB-MARTE-TP-M", 100.0 },
                    { 86632, 300, "ENSAMBLE DE TARIMA Y CONTENEDOR MADERA", 100.0 },
                    { 86714, 300, "SUBENSAMBLE TUBO-SOLERA R-4 FOR", 100.0 },
                    { 86910, 300, "TARIMA DE 1.0X 1.2 HOME DEPOT", 100.0 },
                    { 87010, 300, "DISPLAY-36-PRL-E-LW/36-R16AM-E-LW S/PROD", 100.0 },
                    { 88836, 300, "TARIMA P/CARRETILLA CAT-KID", 100.0 },
                    { 999977, 300, "LJ-NS-291|LJ-NS-291", 100.0 },
                    { 88980, 300, "TARIMA PARA CONTENEDOR #1 Y #2 DE EXHIBI", 100.0 },
                    { 89509, 300, "BOLSA TORNILLOS|BOLSA TORN. CAT-KIT TUB.", 100.0 },
                    { 907855, 300, "R274-SME-10X-2|TUERCA HEXAGONAL M14 (ACERO)", 100.0 },
                    { 910606, 300, "R22-TAPI-13|BARRA SOPORTE MOTOR IZQUIERDA (ACERO)", 100.0 },
                    { 910607, 300, "R23-TAPI-13|TORNILLO HEXAGONAL M8X40MM (ACERO)", 100.0 },
                    { 910608, 300, "R24-TAPI-13|RONDANA PLANA Ø8 (ACERO)", 100.0 },
                    { 910609, 300, "R25-TAPI-13|MONTURA MOTOR (ACERO)", 100.0 },
                    { 910610, 300, "R26-TAPI-13|RONDANA PLANA Ø12 (ACERO)", 100.0 },
                    { 910611, 300, "R27-TAPI-13|RONDANA DE PRESION Ø12 (ACERO)", 100.0 },
                    { 910612, 300, "R28-TAPI-13|TUERCA HEXAGONAL M12 (ACERO)", 100.0 },
                    { 910613, 300, "R29.1-TAPI-13|VENTLADOR (PLASTICO)", 100.0 },
                    { 89177, 300, "TARIMA PARA CAT KID", 100.0 },
                    { 999979, 300, "LJ-NS-293|LJ-NS-293", 100.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Productos_SKU",
                schema: "Catalogo",
                table: "Productos",
                column: "SKU");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productos",
                schema: "Catalogo");
        }
    }
}
