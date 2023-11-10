using ENTJAVA_Week3.Models;
using ENTJAVA_Week3.Services;  // Add this using statement
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;  // Add this using statement
using System.Diagnostics;
using System.Threading.Tasks;

namespace ENTJAVA_Week3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NewsService _newsService;  // Add this line

        public HomeController(ILogger<HomeController> logger, NewsService newsService)  // Add NewsService as a parameter
        {
            _logger = logger;
            _newsService = newsService;  // Initialize the NewsService
        }

        public async Task<IActionResult> Index()
        {
            var articles = await _newsService.GetLatestNewsAsync();  // Use the NewsService to get the latest news
            return View(articles);
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
