using Identidad.Dominio;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Identidad.Persistencia.BaseDatos.Configuracion
{
    public class RolAplicacionConfiguracion
    {
        public RolAplicacionConfiguracion(EntityTypeBuilder<RolAplicacion> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);

            entityBuilder.HasData(
                new RolAplicacion
                {
                    Id = Guid.NewGuid().ToString().ToLower(),
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                }
            );

            entityBuilder.HasMany(e => e.UsuarioRoles).WithOne(e => e.Rol).HasForeignKey(e => e.RoleId).IsRequired();
        }
    }
}
