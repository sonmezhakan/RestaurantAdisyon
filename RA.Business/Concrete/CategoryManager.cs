using RA.Business.Abstract;
using RA.Core.Concrete;
using RA.Entities.Entity;

namespace RA.Business.Concrete
{
    public class CategoryManager : BaseRepository<Category>, ICategoryService<Category>
    {
        BaseRepository<Category> repository = new BaseRepository<Category>();

        public List<Category> GetAllComboBox()
        {
            return repository.GetAll().Select(x => new Category
            {
                ID = x.ID,
                CategoryName = x.CategoryName
            }).ToList();
        }

        public Category GetByCategoryName(string categoryName)
        {
            return repository.GetAll().FirstOrDefault(x => x.CategoryName == categoryName);
        }
    }
}
