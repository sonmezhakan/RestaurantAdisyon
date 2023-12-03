using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.BusinessLogic.Abstract
{
    public interface IOrderDetailRepository<OrderDetail>
    {
        public void Add(OrderDetail orderDetail);
        public void Update(OrderDetail orderDetail);
        public void Delete(int id);
        public List<OrderDetail> GetAll();
        //public OrderDetail GetById(int id);
        public OrderDetail GetOrderById(int id);
        public List<OrderDetail> GetByOrderIdList(int id);
        public OrderDetail GetByOrderAndProductId(int orderId, int productId);
    }
}
