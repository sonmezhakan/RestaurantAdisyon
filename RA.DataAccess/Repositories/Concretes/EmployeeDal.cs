using RA.DataAccess.Concrete;
using RA.DataAccess.Repositories.Abstracts;
using RA.Entities.Entity;

namespace RA.DataAccess.Repositories.Concretes
{
    public class EmployeeDal : BaseRepository<Employee>, IEmployeeDal
    {
        public EmployeeDal(RestaurantAdisyonContext context) : base(context)
        {
        }
    }

}
