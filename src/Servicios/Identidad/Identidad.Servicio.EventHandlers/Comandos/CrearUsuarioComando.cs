using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
namespace Identidad.Servicio.EventHandlers.Comandos
{
    public class CrearUsuarioComando : IRequest<IdentityResult>
    {
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellidos { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
