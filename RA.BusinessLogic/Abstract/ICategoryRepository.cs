using RA.BusinessLogic.Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.BusinessLogic.Abstract
{
    public interface ICategoryRepository<Category>
    {
        public void Add(Category category);
        public void Update(Category category);
        public void Delete(int id);
        public List<Category> GetAll();
        public Category GetById(int id);
        public Category GetByCategoryName(string categoryName);
    }
}
