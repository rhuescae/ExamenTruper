using Cliente.Web.Comercio.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;

namespace Cliente.Web.Comercio.Controllers
{
    public class CuentaController : Controller
    {
        private readonly string _autenticacionnUrl;

        public CuentaController(IConfiguration configuration)
        {
            _autenticacionnUrl = configuration.GetValue<string>("AutenticacionnUrl");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return Redirect(_autenticacionnUrl + $"?ReturnBaseUrl={this.Request.Scheme}://{this.Request.Host}/");
        }

        [HttpGet]
        public async Task<IActionResult> Login(string Accesotoken)
        {
            var token = Accesotoken.Split('.');
            var base64Content = Convert.FromBase64String(token[1]);

            var user = JsonSerializer.Deserialize<Credenciales>(base64Content);

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.nameid),
                new Claim(ClaimTypes.Name, user.unique_name),
                new Claim(ClaimTypes.Email, user.email),
                new Claim("access_token", Accesotoken)
            };

            var claimsIdentity = new ClaimsIdentity(
                claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var authProperties = new AuthenticationProperties
            {
                IssuedUtc = DateTime.UtcNow.AddHours(1)
            };

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                authProperties);

            return Redirect("~/");
        }

        [HttpGet]
        public async Task<IActionResult> CerrarSesion()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("~/");
        }

    }
}
