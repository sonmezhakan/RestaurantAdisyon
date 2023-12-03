using RA.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.BusinessLogic.Abstract
{
    public interface IOrderRepository<Order>
    {
        public void Add(Order order);
        public void Update(Order order);
        public void Delete(int id);
        public List<Order> GetAll();
        public Order GetById(int id);
        public Order GetByTableId(int tableId);
        public Order GetByTableId(int tableId, bool orderIsActive);
    }
}
