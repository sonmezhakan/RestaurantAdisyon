using RA.BusinessLogic.Abstract;
using RA.BusinessLogic.Core.Concrete;
using RA.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.BusinessLogic.Concrete
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository<Product>
    {
        BaseRepository<Product> baseRepository = new BaseRepository<Product>();
        public Product GetByName(string productName)
        {
            return baseRepository.GetAll().FirstOrDefault(x => x.ProductName == productName);
        }
    }
}
