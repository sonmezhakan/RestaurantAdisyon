using RA.Business.Abstract;
using RA.Core.Concrete;
using RA.Entities.Entity;

namespace RA.Business.Concrete
{
    public class CategoryManager : BaseRepository<Category>, ICategoryService<Category>
    {
        BaseRepository<Category> repository = new BaseRepository<Category>();

        public Category GetByCategoryName(string categoryName)
        {
            return repository.GetAll().FirstOrDefault(x => x.CategoryName == categoryName);
        }
    }
}
