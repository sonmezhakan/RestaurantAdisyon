using Microsoft.AspNetCore.Mvc;

namespace RA.AspNetCoreMVC.Areas.Yonetim.Controllers
{
    [Area("Yonetim")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
