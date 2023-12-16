using RA.Entities.Entity;

namespace RA.Business.ManagerService.Abstracts
{
    public interface ICategoryManager : IManager<Category>
    {
        public List<Category> GetAllComboBox();
        public Category GetById(int id);
        public Category GetByCategoryName(string categoryName);
        /*public void Add(Category category);
        public void Update(Category category);
        public void Delete(int id);
        public List<Category> GetAll();
        public List<Category> GetAllComboBox();
        public Category GetById(int id);
        public Category GetByCategoryName(string categoryName);*/
    }
}
