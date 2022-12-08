using Microsoft.AspNetCore.Mvc;
using MVCCore_OAS3Client.Models;
using System.Diagnostics;
using ClientNSName;
using System.Text.Json;
//using Newtonsoft.Json;

namespace MVCCore_OAS3Client.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        HttpClient client = null!;
        string baseUrl = string.Empty;
        ClientProxyClass proxy = null!;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            baseUrl = "https://localhost:7270";
            client = new HttpClient();
            proxy = new ClientProxyClass(baseUrl, client);
        }

        public async Task<IActionResult> Index()
        {
            var result = await proxy.GetcategoriesAsync();
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> GetProducts(int id) 
        {
            var result = await proxy.GetproductAsync(id);
            return View(result);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}