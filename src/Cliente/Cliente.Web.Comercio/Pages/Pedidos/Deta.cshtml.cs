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

namespace Cliente.Web.Comercio.Pages.Pedidos
{
    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
    public class DetaModel : PageModel
    {
        private readonly ILogger<DetaModel> _logger;
        
        private readonly string _pedidosUrl;
        [BindProperty]
        public Pedido Pedido { get; set; }
        public DetaModel(
            ILogger<DetaModel> logger
            
        )
        {
            
            _logger = logger;
        }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            using (var client = new HttpClient())
            {

                var response = await client.GetAsync(_pedidosUrl + "/api/Pedido/GetPedido");
                if (response.IsSuccessStatusCode)
                {
                    Pedido = JsonSerializer.Deserialize<Pedido>(
                    await response.Content.ReadAsStringAsync(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    }
                );
                }


            }
            return Page();
        }

      
    }
}
