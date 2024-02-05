using RA.Business.ManagerService.Abstracts;
using RA.DataAccess.Concrete;
using RA.DataAccess.Repositories.Abstracts;
using RA.Entities.Entity;


namespace RA.Business.ManagerService.Concretes
{
    public class AppUserManager : IAppUserService
    {
        IAppUserDal _appUserDal;

        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public void Add(AppUser appUser)
        {
            if (!_appUserDal.FirstOrDefaultBool(x => x.UserName == appUser.UserName)) _appUserDal.Add(appUser);
        }

        public void Delete(int id)
        {
            var getUser = _appUserDal.FirstOrDefault(x => x.ID == id);
            if (getUser != null) _appUserDal.Delete(getUser);
        }

        public void Update(AppUser appUser)
        {
            if (!_appUserDal.FirstOrDefaultBool(x => x.ID == appUser.ID)) _appUserDal.Update(appUser);
        }

        public List<AppUser> GetAllComboBox()
        {
            return _appUserDal.GetAll().Select(x => new AppUser
            {
                ID = x.ID,
                UserName = x.UserName
            }).ToList();
        }
        public bool GetByEmployeeId(int id)
        {
            return _appUserDal.FirstOrDefaultBool(x => x.ID == id);
        }

        public bool GetByLogin(string userName, string password)
        {
            return _appUserDal.FirstOrDefaultBool(x => x.UserName == userName && x.Password == password);
        }

        public AppUser GetByUserName(string userName)
        {
            return _appUserDal.FirstOrDefault(x => x.UserName == userName);
        }

        public int GetByUserNameReturnId(string userName)
        {
            return GetByUserName(userName).ID;
        }

        public AppUser GetById(int id)
        {
            return _appUserDal.FirstOrDefault(x => x.ID == id);
        }

        public List<AppUser> GetAll()
        {
            return _appUserDal.GetAll();
        }
    }
}
