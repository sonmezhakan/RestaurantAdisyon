using Microsoft.AspNetCore.Mvc;
using RA.AspNetCoreMVC.Models.ViewModels;
using RA.Business.Constants;
using RA.Business.ManagerService.Abstracts;
using RA.Entities.Entity;

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
                        AppUser appUser = new AppUser()
                        {
                            UserName = registerVM.UserName,
                            Password = registerVM.Password,
                            IsActive = registerVM.IsActive,
                        };
                        Employee employee = new Employee()
                        {
                            FirstName = registerVM.FirstName,
                            LastName = registerVM.LastName,
                            Email = registerVM.Email,
                            PhoneNumber = registerVM.Phone,
                            IsActive = registerVM.IsActive,
                            Adress = registerVM.Adress
                        };
                        _appUserManager.Add(appUser);
                        int getAppUserId = _appUserManager.GetByUserName(registerVM.UserName).ID;
                        employee.ID = getAppUserId;
                        _employeeManager.Add(employee);

                        return RedirectToAction("Index", "Login");
                    }
                    else
                    {
                        ViewData["Email"] = Messages.EmailError;
                        return View(registerVM);
                    }
                }
                else
                {
                    ViewData["UserName"] = Messages.UserNameError;
                    return View(registerVM);
                }
            }
            return View(registerVM);
        }
    }
}
