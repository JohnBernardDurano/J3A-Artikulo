using System.Threading.Tasks;
using ENTJAVA_Week3.Services;
using Microsoft.AspNetCore.Mvc;

namespace ENTJAVA_Week3.Controllers
{
    public class NewsServiceController : Controller // Add : Controller
    {
        private readonly NewsService newsService;

        public NewsServiceController(NewsService newsService)
        {
            this.newsService = newsService;
        }

        public async Task<IActionResult> Index()
        {
            var articles = await newsService.GetLatestNewsAsync();
            return View(articles);
        }
    }
}
