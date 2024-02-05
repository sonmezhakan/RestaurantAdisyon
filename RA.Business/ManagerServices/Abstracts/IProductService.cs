using RA.Entities.Entity;

namespace RA.Business.ManagerService.Abstracts
{
    public interface IProductService
    {
        public void Add(Product product);
        public void Update(Product product);
        public void Delete(int id);
        public List<Product> GetAll();
        public List<Product> GetAllComboBox();
        public Product GetByName(string productName);
        public Product GetById(int id);

    }
}
