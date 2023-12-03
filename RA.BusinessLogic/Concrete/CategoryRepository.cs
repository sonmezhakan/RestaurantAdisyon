using RA.BusinessLogic.Abstract;
using RA.BusinessLogic.Core.Concrete;
using RA.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.BusinessLogic.Concrete
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository<Category>
    {
        BaseRepository<Category> repository = new BaseRepository<Category>();

        public Category GetByCategoryName(string categoryName)
        {
            return repository.GetAll().FirstOrDefault(x => x.CategoryName == categoryName);
        }
    }
}
