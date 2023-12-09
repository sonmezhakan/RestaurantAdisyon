using RA.Business.Abstract;
using RA.Core.Concrete;
using RA.Entities.Entity;

namespace RA.Business.Concrete
{
    public class ProductManager : BaseRepository<Product>, IProductService<Product>
    {
        BaseRepository<Product> baseRepository = new BaseRepository<Product>();
        public Product GetByName(string productName)
        {
            return baseRepository.GetAll().FirstOrDefault(x => x.ProductName == productName);
        }
    }
}
