using Identidad.Dominio;
using Identidad.Persistencia.BaseDatos.Configuracion;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Identidad.Persistencia.BaseDatos
{
    public class ApplicationDbContext : IdentityDbContext<UsuarioAplicacion, RolAplicacion, string>
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options
        )
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Database schema
            builder.HasDefaultSchema("Identidad");

            // Model Contraints
            ModelConfig(builder);
        }

        private void ModelConfig(ModelBuilder modelBuilder)
        {
            new UsuarioAplicacionConfiguracion(modelBuilder.Entity<UsuarioAplicacion>());
            new RolAplicacionConfiguracion(modelBuilder.Entity<RolAplicacion>());
        }
    }
}
