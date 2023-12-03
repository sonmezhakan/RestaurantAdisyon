using RA.BusinessLogic.Core.Concrete;
using RA.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.BusinessLogic.Abstract
{
    public interface IAppUserRepository<AppUser>
    {
        public void Add(AppUser appUser);
        public void Update(AppUser appUser);
        public void Delete(int id);
        public List<AppUser> GetAll();
        public AppUser GetById(int id);
        public AppUser GetByCategoryName(string userName);
    }
}
