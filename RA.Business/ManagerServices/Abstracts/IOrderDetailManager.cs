using RA.Entities.Entity;

namespace RA.Business.ManagerService.Abstracts
{
    public interface IOrderDetailManager:IManager<OrderDetail>
    {
        public List<OrderDetail> GetByOrderIdList(int id);
        public OrderDetail GetByOrderAndProductId(int orderId, int productId);
        OrderDetail GetById(int id);
        public OrderDetail GetOrderById(int id);

    }
}
