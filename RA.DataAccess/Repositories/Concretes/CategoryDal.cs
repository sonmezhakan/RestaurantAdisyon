using RA.DataAccess.Concrete;
using RA.DataAccess.Repositories.Abstracts;
using RA.Entities.Entity;

namespace RA.DataAccess.Repositories.Concretes
{
    public class CategoryDal : BaseRepository<Category>, ICategoryDal
    {
        public CategoryDal(RestaurantAdisyonContext context) : base(context)
        {
        }
    }

}
