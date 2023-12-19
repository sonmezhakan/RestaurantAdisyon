using Microsoft.AspNetCore.Mvc;
using RA.AspNetCoreMVC.Models.ViewModels;
using RA.Business.ManagerService.Abstracts;

namespace RA.AspNetCoreMVC.Controllers
{
    public class LoginController : Controller
    {
        private readonly IAppUserManager _appUserManager;

        public LoginController(IAppUserManager appUserManager)
        {
            _appUserManager = appUserManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginVM loginVM)
        {
            if(ModelState.IsValid)
            {
               if(_appUserManager.GetByLogin(loginVM.UserName,loginVM.Password))
                {
                    TempData["Success"] = "Giriş Başarılı! Anasayfaya Yönlendiriliyorsunuz...";
                    return RedirectToAction("Index","Home");
                }
               else
                {
                    TempData["Error"] = "Kullanıcı Adı veya Şifre Hatalı!";
                    return View(loginVM);
                }
            }
            return View(loginVM);
        }
    }
}
