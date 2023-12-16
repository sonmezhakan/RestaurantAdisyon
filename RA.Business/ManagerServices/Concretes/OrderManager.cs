using RA.Business.ManagerService.Abstracts;
using RA.DataAccess.Repositories.Abstracts;
using RA.Entities.Entity;

namespace RA.Business.ManagerService.Concretes
{
    public class OrderManager : BaseManager<Order>, IOrderManager
    {
        private readonly IOrderRepository _orderRepository;

        public OrderManager(IOrderRepository orderRepository) : base(orderRepository)
        {
            _orderRepository = orderRepository;
        }
        /*public void Update(Order order)
        {
            if (_orderRepository.FirstOrDefaultBool(x => x.ID == order.ID))
            {
                _orderRepository.Update(order);
            }
        }
        public void Delete(int id)
        {
            var getOrder = FirstOrDefault(x => x.ID == id);
            if (getOrder != null)
            {
                _orderRepository.Delete(getOrder);
            }
        }*/

         public Order GetByTableId(int tableId)
         {
             return _orderRepository.FirstOrDefault(x => x.TableId == tableId);
         }

         public Order GetByTableId(int tableId, bool orderIsActive)
         {
             return _orderRepository.FirstOrDefault(x => x.TableId == tableId && x.IsActive == orderIsActive);
         }

        public Order GetById(int id)
        {
            return _orderRepository.FirstOrDefault(x => x.ID == id);
        }
    }
}
