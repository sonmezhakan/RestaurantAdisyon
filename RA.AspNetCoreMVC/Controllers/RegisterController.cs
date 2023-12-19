using Microsoft.AspNetCore.Mvc;
using RA.AspNetCoreMVC.Models.ViewModels;
using RA.Business.Constants;
using RA.Business.ManagerService.Abstracts;

namespace RA.AspNetCoreMVC.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IAppUserManager _appUserManager;
        private readonly IEmployeeManager _employeeManager;

        public RegisterController(IAppUserManager appUserManager, IEmployeeManager employeeManager)
        {
            _appUserManager = appUserManager;
            _employeeManager = employeeManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(RegisterVM registerVM)
        {
            if (ModelState.IsValid)
            {
                if (_appUserManager.GetByUserName(registerVM.UserName) == null)
                {
                    if(!_employeeManager.GetByEmail(registerVM.Email))
                    {
                        //todo:Kullanıcı ve employe tablosunda değişiklik yapıldıktan sonra ekleme işlemi yapılacaktır
                    }
                    else
                    {
                        ViewData["Email"] = Messages.EmailError;
                    }
                }
                else
                {
                    ViewData["UserName"] = Messages.UserNameError;
                }
            }
            return View(registerVM);
        }
    }
}
