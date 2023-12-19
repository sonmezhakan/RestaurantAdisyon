using Microsoft.AspNetCore.Mvc;
using RA.Business.ManagerService.Abstracts;

namespace RA.AspNetCoreMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductManager _productManager;

        public HomeController(IProductManager productManager)
        {
            _productManager = productManager;
        }
        public IActionResult Index()
        {
            var result = _productManager.GetAll();
            return View(result);
        }
    }
}
