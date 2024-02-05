using RA.Business.ManagerService.Abstracts;
using RA.DataAccess.Repositories.Abstracts;
using RA.Entities.Entity;

namespace RA.Business.ManagerService.Concretes
{
    public class ProductManager :IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            if (!_productDal.FirstOrDefaultBool(x=>x.ProductName == product.ProductName))
            {
                _productDal.Add(product);
            }
        }
        public void Update(Product product)
        {
            if (_productDal.FirstOrDefaultBool(x => x.ID == product.ID))
            {
                _productDal.Update(product);
            }
        }
        public void Delete(int id)
        {
            var getProduct = _productDal.FirstOrDefault(x => x.ID == id);
            if (getProduct != null)
            {
                _productDal.Delete(getProduct);
            }
        }

        public List<Product> GetAllComboBox()
        {
            return _productDal.GetAll().Select(x => new Product
            {
                ID = x.ID,
                ProductName = x.ProductName
            }).ToList();
        }

        public Product GetByName(string productName)
        {
            return _productDal.FirstOrDefault(x => x.ProductName == productName);
        }

        public Product GetById(int id)
        {
            return _productDal.FirstOrDefault(x=>x.ID == id);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }
    }
}
