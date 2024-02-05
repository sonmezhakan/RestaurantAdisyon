using RA.DataAccess.Concrete;
using RA.DataAccess.Repositories.Abstracts;
using RA.Entities.Entity;

namespace RA.DataAccess.Repositories.Concretes
{
    public class SupplierDal : BaseRepository<Supplier>, ISupplierDal
    {
        public SupplierDal(RestaurantAdisyonContext context) : base(context)
        {
        }
    }

}
