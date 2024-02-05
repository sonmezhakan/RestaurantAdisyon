using RA.Business.ManagerService.Abstracts;
using RA.DataAccess.Repositories.Abstracts;
using RA.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.Business.ManagerService.Concretes
{
    public class StockManager : IStockService
    {
        private readonly IStockDal _stockDal;

        public StockManager(IStockDal stockDal)
        {
            _stockDal = stockDal;
        }

        public Stock GetById(int id)
        {
            return _stockDal.FirstOrDefault(x => x.ID == id);
        }
        public void Update(Stock stock)
        {
            if (_stockDal.FirstOrDefaultBool(x => x.ID == stock.ID))
            {
                _stockDal.Update(stock);
            }
        }
        public void Delete(int id)
        {
            var getStock = _stockDal.FirstOrDefault(x => x.ID == id);
            if (getStock != null)
            {
                _stockDal.Delete(getStock);
            }
        }

        public void Add(Stock stock)
        {
            _stockDal.Add(stock);
        }

        public List<Stock> GetAll()
        {
            return _stockDal.GetAll();
        }
    }
}
