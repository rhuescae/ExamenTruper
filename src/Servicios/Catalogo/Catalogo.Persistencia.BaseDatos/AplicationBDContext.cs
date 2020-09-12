

namespace Catalogo.Persistencia.BaseDatos
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Catalogo.Dominio;
    using Catalogo.Persistencia.BaseDatos.Configuracion;
    using Microsoft.EntityFrameworkCore;
    
    public class AplicationBDContext: DbContext
    {
        public AplicationBDContext(DbContextOptions<AplicationBDContext> opciones) : base(opciones)
        {
            
        }

        public DbSet<Producto> Productos { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.HasDefaultSchema("Catalogo");

            ModelConfig(builder);
        }

        private void ModelConfig(ModelBuilder modelBuilder)
        {
            new ProductoConfiguracion(modelBuilder.Entity<Producto>());
            
        }
    }
}
