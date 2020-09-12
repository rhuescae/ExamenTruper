using Identidad.Dominio;
using Identidad.Persistencia.BaseDatos;
using Identidad.Servicio.EventHandlers.Comandos;
using Identidad.Servicio.EventHandlers.Respuestas;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Identidad.Servicio.EventHandlers
{

    public class AutenticarUsuarioEventHandlers : IRequestHandler<AutenticacionUsuarioComandos, IdentidadAcceso>
    {
        private readonly SignInManager<UsuarioAplicacion> _signInManager;
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _configuration;
        public AutenticarUsuarioEventHandlers(
            SignInManager<UsuarioAplicacion> signInManager,
            ApplicationDbContext context,
            IConfiguration configuration)
        {
            _signInManager = signInManager;
            _context = context;
            _configuration = configuration;
        }

        public async Task<IdentidadAcceso> Handle(AutenticacionUsuarioComandos notification, CancellationToken cancellationToken)
        {
            var result = new IdentidadAcceso();

            var usuario = await _context.Users.SingleAsync(x => x.Email == notification.Email);
            var response = await _signInManager.CheckPasswordSignInAsync(usuario, notification.Password, false);

            if (response.Succeeded)
            {
                result.EsError = false;
                await GenerateToken(usuario, result);
            }

            return result;
        }

        private async Task GenerateToken(UsuarioAplicacion usuario, IdentidadAcceso identidadAcceso)
        {
            var secretKey = _configuration.GetValue<string>("SecretKey");
            var tiempoExpiracion = _configuration.GetValue<int>("TiempoExpiracion");
            var key = Encoding.ASCII.GetBytes(secretKey);

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, usuario.Id),
                new Claim(ClaimTypes.Email, usuario.Email),
                new Claim(ClaimTypes.Name, usuario.Nombre),
                new Claim(ClaimTypes.Surname, usuario.Apellidos)
            };

            var roles = await _context.Roles
                                      .Where(x => x.UsuarioRoles.Any(y => y.UserId == usuario.Id))
                                      .ToListAsync();

            foreach (var role in roles)
            {
                claims.Add(
                    new Claim(ClaimTypes.Role, role.Name)
                );
            }

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddMinutes(tiempoExpiracion),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature
                )
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var createdToken = tokenHandler.CreateToken(tokenDescriptor);

            identidadAcceso.Token = tokenHandler.WriteToken(createdToken);
        }
    }
}
