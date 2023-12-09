using RA.Business.Abstract;
using RA.Core.Concrete;
using RA.Entities.Entity;

namespace RA.Business.Concrete
{
    public class OrderDetailManager : BaseRepository<OrderDetail>, IOrderDetailService<OrderDetail>
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
