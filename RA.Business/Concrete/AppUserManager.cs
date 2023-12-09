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
        public AppUser GetByCategoryName(string userName)
        {
            return baseRepository.GetAll().FirstOrDefault(x => x.UserName == userName);
        }
    }
}
