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
    public class OrderDetailRepository : BaseRepository<OrderDetail>, IOrderDetailRepository<OrderDetail>
    {
        BaseRepository<OrderDetail> baseRepository = new BaseRepository<OrderDetail>();

        public OrderDetail GetByOrderAndProductId(int orderId, int productId)
        {
            return baseRepository.GetAll().FirstOrDefault(x => x.OrderID == orderId && x.ProductID == productId);
        }

        public List<OrderDetail> GetByOrderIdList(int id)
        {
            return baseRepository.GetAll().Where(x => x.OrderID == id).ToList();
        }

        public OrderDetail GetOrderById(int id)
        {
            return baseRepository.GetAll().FirstOrDefault(x => x.OrderID == id);
        }
    }
}
