using RA.DataAccess.Concrete;
using RA.DataAccess.Repositories.Abstracts;
using RA.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RA.DataAccess.Repositories.Concretes
{
    public class AppUserDal : BaseRepository<AppUser>, IAppUserDal
    {
        public AppUserDal(RestaurantAdisyonContext context) : base(context)
        {
        }
    }

}
