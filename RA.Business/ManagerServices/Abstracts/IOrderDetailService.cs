using RA.Entities.Entity;

namespace RA.Business.ManagerService.Abstracts
{
    public interface IOrderDetailService
    {
        public void Add(OrderDetail orderDetail);
        public void Update(OrderDetail orderDetail);
        public void Delete(int id);
        public List<OrderDetail> GetAll();
        public List<OrderDetail> GetByOrderIdList(int id);
        public OrderDetail GetByOrderAndProductId(int orderId, int productId);
        OrderDetail GetById(int id);
        public OrderDetail GetOrderById(int id);

    }
}
