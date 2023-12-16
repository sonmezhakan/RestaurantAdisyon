using RA.Business.ManagerService.Abstracts;
using RA.DataAccess.Repositories.Abstracts;
using RA.Entities.Entity;

namespace RA.Business.ManagerService.Concretes
{
    public class ProductManager :BaseManager<Product>, IProductManager
    {
        private readonly IProductRepository _productRepository;

        public ProductManager(IProductRepository productRepository):base(productRepository)
        {
            _productRepository = productRepository;
        }

        /*public void Add(Product product)
        {
            if (!_productRepository.FirstOrDefaultBool(x=>x.ProductName == product.ProductName))
            {
                _productRepository.Add(product);
            }
        }
        public void Update(Product product)
        {
            if (_productRepository.FirstOrDefaultBool(x => x.ID == product.ID))
            {
                _productRepository.Update(product);
            }
        }
        public void Delete(int id)
        {
            var getProduct = _productRepository.FirstOrDefault(x => x.ID == id);
            if (getProduct != null)
            {
                _productRepository.Delete(getProduct);
            }
        }*/

        public List<Product> GetAllComboBox()
        {
            return _productRepository.GetAll().Select(x => new Product
            {
                ID = x.ID,
                ProductName = x.ProductName
            }).ToList();
        }

        public Product GetByName(string productName)
        {
            return _productRepository.FirstOrDefault(x => x.ProductName == productName);
        }

        public Product GetById(int id)
        {
            return _productRepository.FirstOrDefault(x=>x.ID == id);
        }
    }
}
