using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Identidad.Dominio
{
    public class RolAplicacion: IdentityRole
    {
       public ICollection<UsuarioRolAplicacion> UsuarioRoles { get; set; }
    }
}
