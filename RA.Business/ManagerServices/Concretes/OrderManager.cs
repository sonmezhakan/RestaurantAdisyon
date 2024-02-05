using RA.Business.ManagerService.Abstracts;
using RA.DataAccess.Repositories.Abstracts;
using RA.Entities.Entity;

namespace RA.Business.ManagerService.Concretes
{
    public class OrderManager : IOrderService
    {
        private readonly IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }
        public void Update(Order order)
        {
            if (_orderDal.FirstOrDefaultBool(x => x.ID == order.ID))
            {
                _orderDal.Update(order);
            }
        }
        public void Delete(int id)
        {
            var getOrder = _orderDal.FirstOrDefault(x => x.ID == id);
            if (getOrder != null)
            {
                _orderDal.Delete(getOrder);
            }
        }

         public Order GetByTableId(int tableId)
         {
             return _orderDal.FirstOrDefault(x => x.TableId == tableId);
         }

         public Order GetByTableId(int tableId, bool orderIsActive)
         {
             return _orderDal.FirstOrDefault(x => x.TableId == tableId && x.IsActive == orderIsActive);
         }

        public Order GetById(int id)
        {
            return _orderDal.FirstOrDefault(x => x.ID == id);
        }

        public void Add(Order order)
        {
            _orderDal.Add(order);
        }

        public List<Order> GetAll()
        {
            return _orderDal.GetAll();
        }
    }
}
