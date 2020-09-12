using Identidad.Dominio;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Identidad.Persistencia.BaseDatos.Configuracion
{
    public class UsuarioAplicacionConfiguracion
    {
        public UsuarioAplicacionConfiguracion(EntityTypeBuilder<UsuarioAplicacion> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);

            entityBuilder.Property(x => x.Nombre).IsRequired().HasMaxLength(100);
            entityBuilder.Property(x => x.Apellidos).IsRequired().HasMaxLength(100);

            entityBuilder.HasMany(e => e.UsuarioRol).WithOne(e => e.Usuario).HasForeignKey(e => e.UserId).IsRequired();
        }

    }
}
