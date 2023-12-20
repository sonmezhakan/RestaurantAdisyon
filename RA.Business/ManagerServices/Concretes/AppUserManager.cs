using RA.Business.ManagerService.Abstracts;
using RA.DataAccess.Concrete;
using RA.DataAccess.Repositories.Abstracts;
using RA.Entities.Entity;


namespace RA.Business.ManagerService.Concretes
{
    public class AppUserManager : BaseManager<AppUser>, IAppUserManager
    {
        IAppUserRepository _appUserRepository;

        public AppUserManager(IAppUserRepository appUserRepository) : base(appUserRepository)
        {
            _appUserRepository = appUserRepository;
        }

        /*public void Add(AppUser appUser)
        {
            if (!_appUserRepository.FirstOrDefaultBool(x => x.UserName == appUser.UserName)) _appUserRepository.Add(appUser);
        }

        public void Delete(int id)
        {
            var getUser = _appUserRepository.FirstOrDefault(x => x.ID == id);
            if (getUser != null) _appUserRepository.Delete(getUser);
        }

        public void Update(AppUser appUser)
        {
            if (!_appUserRepository.FirstOrDefaultBool(x => x.ID == appUser.ID)) _appUserRepository.Update(appUser);
        }*/

        public List<AppUser> GetAllComboBox()
        {
            return _appUserRepository.GetAll().Select(x => new AppUser
            {
                ID = x.ID,
                UserName = x.UserName
            }).ToList();
        }
        public bool GetByEmployeeId(int id)
        {
            return _appUserRepository.FirstOrDefaultBool(x => x.ID == id);
        }

        public bool GetByLogin(string userName, string password)
        {
            return _appUserRepository.FirstOrDefaultBool(x => x.UserName == userName && x.Password == password);
        }

        public AppUser GetByUserName(string userName)
        {
            return _appUserRepository.FirstOrDefault(x => x.UserName == userName);
        }

        public int GetByUserNameReturnId(string userName)
        {
            return GetByUserName(userName).ID;
        }

        public AppUser GetById(int id)
        {
            return _appUserRepository.FirstOrDefault(x => x.ID == id);
        }
    }
}
