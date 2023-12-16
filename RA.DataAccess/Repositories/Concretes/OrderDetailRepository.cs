using RA.DataAccess.Concrete;
using RA.DataAccess.Repositories.Abstracts;
using RA.Entities.Entity;

namespace RA.DataAccess.Repositories.Concretes
{
    public class OrderDetailRepository : BaseRepository<OrderDetail, RestaurantAdisyonContext>, IOrderDetailRepository
    {

    }

}
