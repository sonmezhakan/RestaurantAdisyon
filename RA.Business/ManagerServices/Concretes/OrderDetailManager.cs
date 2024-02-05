using RA.Business.ManagerService.Abstracts;
using RA.DataAccess.Repositories.Abstracts;
using RA.Entities.Entity;

namespace RA.Business.ManagerService.Concretes
{
    public class OrderDetailManager : IOrderDetailService
    {
        private readonly IOrderDetailDal _orderDetailDal;

        public OrderDetailManager(IOrderDetailDal orderDetailDal)
        {
            _orderDetailDal = orderDetailDal;
        }

       public void Update(OrderDetail orderDetail)
        {
            if (_orderDetailDal.FirstOrDefaultBool(x=>x.ID == orderDetail.ID))
            {
                _orderDetailDal.Update(orderDetail);
            }
        }
        public void Delete(int id)
        {
            var getOrderDetail = _orderDetailDal.FirstOrDefault(x => x.ID == id);
            if (getOrderDetail != null)
            {
                _orderDetailDal.Delete(getOrderDetail);
            }
        }

        
        public OrderDetail GetByOrderAndProductId(int orderId, int productId)
        {
            return _orderDetailDal.FirstOrDefault(x => x.OrderID == orderId && x.ProductID == productId);
        }

        public List<OrderDetail> GetByOrderIdList(int id)
        {
            return _orderDetailDal.GetAll().Where(x => x.OrderID == id).ToList();
        }

        public OrderDetail GetOrderById(int id)
        {
            return _orderDetailDal.FirstOrDefault(x => x.OrderID == id);
        }

        public OrderDetail GetById(int id)
        {
            return _orderDetailDal.FirstOrDefault(x => x.ID == id);
        }

        public void Add(OrderDetail orderDetail)
        {
            _orderDetailDal.Add(orderDetail);
        }

        public List<OrderDetail> GetAll()
        {
            return _orderDetailDal.GetAll();
        }
    }
}
