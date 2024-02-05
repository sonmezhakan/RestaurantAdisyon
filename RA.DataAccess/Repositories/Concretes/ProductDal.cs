using RA.DataAccess.Concrete;
using RA.DataAccess.Repositories.Abstracts;
using RA.Entities.Entity;

namespace RA.DataAccess.Repositories.Concretes
{
    public class ProductDal : BaseRepository<Product>, IProductDal
    {
        public ProductDal(RestaurantAdisyonContext context) : base(context)
        {
        }
    }

}
