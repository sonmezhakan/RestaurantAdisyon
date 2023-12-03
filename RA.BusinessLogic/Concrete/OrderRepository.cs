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
    public class OrderRepository : BaseRepository<Order>, IOrderRepository<Order>
    {
        BaseRepository<Order> baseRepository = new BaseRepository<Order>();
        public Order GetByTableId(int tableId)
        {
            return baseRepository.GetAll().FirstOrDefault(x => x.TableId == tableId);
        }

        public Order GetByTableId(int tableId, bool orderIsActive)
        {
            return baseRepository.GetAll().FirstOrDefault(x=>x.TableId == tableId && x.IsActive == orderIsActive);
        }
    }
}
