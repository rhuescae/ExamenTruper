

namespace Pedido.Persistencia.BaseDatos
{
    using Microsoft.EntityFrameworkCore;
    using Pedido.Dominio;
    using Pedido.Persistencia.BaseDatos.Configuracion;
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Database schema
            builder.HasDefaultSchema("Pedido");

            // Model Contraints
            ModelConfig(builder);
        }

        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<PedidoDetalle> PedidoDetalle { get; set; }

        private void ModelConfig(ModelBuilder modelBuilder)
        {
            new PedidoConfiguracion(modelBuilder.Entity<Pedido>());
            new PedidoDetalleConfiguracion(modelBuilder.Entity<PedidoDetalle>());
        }



    }
}
