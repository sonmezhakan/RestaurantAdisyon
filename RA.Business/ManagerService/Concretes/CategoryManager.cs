using Microsoft.EntityFrameworkCore;
using RA.Business.ManagerService.Abstracts;
using RA.DataAccess.Concrete;
using RA.DataAccess.Repositories.Abstracts;
using RA.Entities.Entity;
using System.Linq.Expressions;

namespace RA.Business.ManagerService.Concretes
{
    public class CategoryManager : BaseManager<Category>, ICategoryManager
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryManager(ICategoryRepository categoryRepository) : base(categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void Add(Category category)
        {
            if (!_categoryRepository.FirstOrDefaultBool(x=>x.CategoryName == category.CategoryName))
            {
                _categoryRepository.Add(category);
            }
        }
        public void Update(Category category)
        {
            if (_categoryRepository.FirstOrDefaultBool(x=>x.ID == category.ID))
            {
                _categoryRepository.Update(category);
            }
        }
        public void Delete(int id)
        {
            var getCategory = _categoryRepository.FirstOrDefault(x=>x.ID==id);
            if (getCategory != null)
            {
                _categoryRepository.Delete(getCategory);
            }
        }

        public List<Category> GetAllComboBox()
        {
            return _categoryRepository.GetAll().Select(x => new Category
            {
                ID = x.ID,
                CategoryName = x.CategoryName
            }).ToList();
        }

        public Category GetById(int id)
        {
            return _categoryRepository.FirstOrDefault(x => x.ID == id);
        }

        public Category GetByCategoryName(string categoryName)
        {
            return _categoryRepository.FirstOrDefault(x => x.CategoryName == categoryName);
        }
    }
}
