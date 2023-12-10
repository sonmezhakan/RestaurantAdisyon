namespace RA.Business.Abstract
{
    public interface ICategoryService<Category>
    {
        public void Add(Category category);
        public void Update(Category category);
        public void Delete(int id);
        public List<Category> GetAll();
        public List<Category> GetAllComboBox();
        public Category GetById(int id);
        public Category GetByCategoryName(string categoryName);
    }
}
