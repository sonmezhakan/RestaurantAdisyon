using RA.Business.Abstract;
using RA.Core.Concrete;
using RA.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.Business.Concrete
{
    public class AppUserManager : BaseRepository<AppUser>, IAppUserService<AppUser>
    {
        BaseRepository<AppUser> baseRepository = new BaseRepository<AppUser>();

        public List<AppUser> GetAllComboBox()
        {
            return baseRepository.GetAll().Select(x => new AppUser
            {
                ID = x.ID,
                UserName = x.UserName
            }).ToList();
        }

        public bool GetByEmployeeId(int id)
        {
            return baseRepository.GetAll().Any(x => x.EmployeeID == id);
        }

        public bool GetByLogin(string userName, string password)
        {
            return baseRepository.GetAll().Any(x => x.UserName == userName && x.Password == password);
        }

        public AppUser GetByUserName(string userName)
        {
            return baseRepository.GetAll().FirstOrDefault(x => x.UserName == userName);
        }

        public int GetByUserNameReturnId(string userName)
        {
            return baseRepository.GetAll().FirstOrDefault(x => x.UserName == userName).ID;
        }
    }
}
