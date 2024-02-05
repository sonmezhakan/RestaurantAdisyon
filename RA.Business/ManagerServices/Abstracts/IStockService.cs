using RA.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.Business.ManagerService.Abstracts
{
    public interface IStockService
    {
        void Add(Stock stock);
        void Update(Stock stock);
        void Delete(int id);
        List<Stock> GetAll();
        Stock GetById(int id);
    }
}
