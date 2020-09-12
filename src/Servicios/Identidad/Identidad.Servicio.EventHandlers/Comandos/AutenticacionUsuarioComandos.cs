using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using System.ComponentModel.DataAnnotations;
using Identidad.Servicio.EventHandlers.Respuestas;

namespace Identidad.Servicio.EventHandlers.Comandos
{
    public class AutenticacionUsuarioComandos: IRequest<IdentidadAcceso>
    {
        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }



    }
}
