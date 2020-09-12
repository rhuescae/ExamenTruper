using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Identidad.Dominio
{
    public class UsuarioRolAplicacion: IdentityUserRole<string>
    {
        public RolAplicacion Rol { get; set; }

        public UsuarioAplicacion Usuario { get; set; }

    }
}
