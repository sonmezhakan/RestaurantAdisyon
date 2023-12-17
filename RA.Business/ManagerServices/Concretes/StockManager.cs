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
    public class StockManager :BaseManager<Stock>, IStockManager
    {
        private readonly IStockRepository _stockRepository;

        public StockManager(IStockRepository stockRepository):base(stockRepository)
        {
            _stockRepository = stockRepository;
        }

        public Stock GetById(int id)
        {
           return _stockRepository.FirstOrDefault(x => x.ID == id);
        }
        /*public void Update(Stock stock)
{
   if (_stockRepository.FirstOrDefaultBool(x=>x.ID == stock.ID))
   {
       _stockRepository.Update(stock);
   }
}
public void Delete(int id)
{
   var getStock = _stockRepository.FirstOrDefault(x => x.ID == id);
   if (getStock != null)
   {
       _stockRepository.Delete(getStock);
   }
}*/



    }
}
