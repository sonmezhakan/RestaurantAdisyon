using RA.Entities.Entity;

namespace RA.Business.ManagerService.Abstracts
{
    public interface IProductManager:IManager<Product>
    {
        public List<Product> GetAllComboBox();
        public Product GetByName(string productName);
        public Product GetById(int id);

    }
}
