using RA.DataAccess.Concrete;
using RA.DataAccess.Repositories.Abstracts;
using RA.Entities.Entity;

namespace RA.DataAccess.Repositories.Concretes
{
    public class OrderDetailDal : BaseRepository<OrderDetail>, IOrderDetailDal
    {
        public OrderDetailDal(RestaurantAdisyonContext context) : base(context)
        {
        }
    }

}
