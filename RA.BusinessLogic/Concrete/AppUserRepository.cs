using RA.BusinessLogic.Abstract;
using RA.BusinessLogic.Core.Concrete;
using RA.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.BusinessLogic.Concrete
{
    public class AppUserRepository : BaseRepository<AppUser>, IAppUserRepository<AppUser>
    {
        BaseRepository<AppUser> baseRepository = new BaseRepository<AppUser>();
        public AppUser GetByCategoryName(string userName)
        {
            return baseRepository.GetAll().FirstOrDefault(x => x.UserName == userName);
        }
    }
}
