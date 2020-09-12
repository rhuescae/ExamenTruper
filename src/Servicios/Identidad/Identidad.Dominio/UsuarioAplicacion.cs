

namespace Identidad.Dominio
{
    using Microsoft.AspNetCore.Identity;
    using System.Collections.Generic;

    public class UsuarioAplicacion : IdentityUser
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public ICollection<UsuarioRolAplicacion> UsuarioRol { get; set; }
        


    }
}
