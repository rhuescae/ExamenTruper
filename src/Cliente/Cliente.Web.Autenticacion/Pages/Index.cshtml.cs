using Cliente.Web.Autenticacion.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Configuration;

namespace Cliente.Web.Autenticacion.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly string _identityUrl;

        [BindProperty(SupportsGet = true)]
        public string ReturnBaseUrl { get; set; }
        [BindProperty]
        public CredencialesViewModel model { get; set; }

        public bool HasInvalidAccess { get; set; }

        public IndexModel(
            ILogger<IndexModel> logger,
            IConfiguration configuration)
        {
            _logger = logger;
            _identityUrl = configuration.GetValue<string>("IdentidadUrl");
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            using (var client = new HttpClient())
            {
                var content = new StringContent(
                    JsonSerializer.Serialize(model),
                    Encoding.UTF8,
                    "application/json"
                );

                var request = await client.PostAsync(_identityUrl + "api/Identidad/Autenticacion", content);

                if (!request.IsSuccessStatusCode)
                {
                    HasInvalidAccess = true;
                    return Page();
                }

                var result = JsonSerializer.Deserialize<IdentidadAcceso>(
                    await request.Content.ReadAsStringAsync(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    }
                );

                return Redirect(ReturnBaseUrl + $"Cuenta/Login?Accesotoken={result.Token}");
            }
        }
    }


}