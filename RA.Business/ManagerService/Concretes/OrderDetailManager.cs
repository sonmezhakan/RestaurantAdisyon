using RA.Business.ManagerService.Abstracts;
using RA.DataAccess.Repositories.Abstracts;
using RA.Entities.Entity;

namespace RA.Business.ManagerService.Concretes
{
    public class OrderDetailManager :BaseManager<OrderDetail>, IOrderDetailManager
    {
        private readonly IOrderDetailRepository _orderDetailRepository;

        public OrderDetailManager(IOrderDetailRepository orderDetailRepository):base(orderDetailRepository)
        {
            _orderDetailRepository = orderDetailRepository;
        }

        public void Update(OrderDetail orderDetail)
        {
            if (_orderDetailRepository.FirstOrDefaultBool(x=>x.ID == orderDetail.ID))
            {
                _orderDetailRepository.Update(orderDetail);
            }
        }
        public void Delete(int id)
        {
            var getOrderDetail = _orderDetailRepository.FirstOrDefault(x => x.ID == id);
            if (getOrderDetail != null)
            {
                _orderDetailRepository.Delete(getOrderDetail);
            }
        }

        
        public OrderDetail GetByOrderAndProductId(int orderId, int productId)
        {
            return _orderDetailRepository.FirstOrDefault(x => x.OrderID == orderId && x.ProductID == productId);
        }

        public List<OrderDetail> GetByOrderIdList(int id)
        {
            return _orderDetailRepository.GetAll().Where(x => x.OrderID == id).ToList();
        }

        public OrderDetail GetOrderById(int id)
        {
            return _orderDetailRepository.FirstOrDefault(x => x.OrderID == id);
        }

        public OrderDetail GetById(int id)
        {
            return _orderDetailRepository.FirstOrDefault(x => x.ID == id);
        }
    }
}
