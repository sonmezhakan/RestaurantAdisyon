namespace RA.Business.Abstract
{
    public interface IProductService<Product>
    {
        public void Add(Product product);
        public void Update(Product product);
        public void Delete(int id);
        public Product GetById(int id);
        public List<Product> GetAll();
        public List<Product> GetAllComboBox();
        public Product GetByName(string productName);
    }
}
