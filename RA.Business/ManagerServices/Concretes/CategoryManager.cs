using Microsoft.EntityFrameworkCore;
using RA.Business.ManagerService.Abstracts;
using RA.DataAccess.Concrete;
using RA.DataAccess.Repositories.Abstracts;
using RA.Entities.Entity;
using System.Linq.Expressions;

namespace RA.Business.ManagerService.Concretes
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            if (!_categoryDal.FirstOrDefaultBool(x=>x.CategoryName == category.CategoryName))
            {
                _categoryDal.Add(category);
            }
        }
        public void Update(Category category)
        {
            if (_categoryDal.FirstOrDefaultBool(x=>x.ID == category.ID))
            {
                _categoryDal.Update(category);
            }
        }
        public void Delete(int id)
        {
            var getCategory = _categoryDal.FirstOrDefault(x=>x.ID==id);
            if (getCategory != null)
            {
                _categoryDal.Delete(getCategory);
            }
        }

        public List<Category> GetAllComboBox()
        {
            return _categoryDal.GetAll().Select(x => new Category
            {
                ID = x.ID,
                CategoryName = x.CategoryName
            }).ToList();
        }

        public Category GetById(int id)
        {
            return _categoryDal.FirstOrDefault(x => x.ID == id);
        }

        public Category GetByCategoryName(string categoryName)
        {
            return _categoryDal.FirstOrDefault(x => x.CategoryName == categoryName);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }
    }
}
