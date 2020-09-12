using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

using System.Net.Http;
using System.Text;
using System.Text.Json;
using Cliente.Web.Comercio.Models;
using System.Collections.Generic;

namespace Cliente.Web.Comercio.Pages
{
    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly string _pedidosUrl;
        public IEnumerable<Pedido> Pedidos { get; set; }
        public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration)
        {
            _logger = logger;
            _pedidosUrl = configuration.GetValue<string>("PedidosUrl");
        }

        public void OnGet()
        {
            
        }
    }
}
