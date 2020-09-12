
using Microsoft.AspNetCore.Identity;
using Identidad.Servicio.EventHandlers.Comandos;
using Identidad.Dominio;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Identidad.Servicio.EventHandlers
{
    public class CrearUsuarioEventHandler:IRequestHandler<CrearUsuarioComando, IdentityResult>
    {
        private readonly UserManager<UsuarioAplicacion> _userManager;

    public CrearUsuarioEventHandler(
        UserManager<UsuarioAplicacion> userManager)
    {
        _userManager = userManager;
    }

    public async Task<IdentityResult> Handle(CrearUsuarioComando notification, CancellationToken cancellationToken)
    {
        var entry = new UsuarioAplicacion
        {
            Nombre = notification.Nombre,
            Apellidos = notification.Apellidos,
            Email = notification.Email,
            UserName = notification.Email
        };

        return await _userManager.CreateAsync(entry, notification.Password);
    }
}
}
