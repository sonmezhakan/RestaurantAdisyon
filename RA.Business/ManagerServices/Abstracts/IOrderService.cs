using RA.Entities.Entity;

namespace RA.Business.ManagerService.Abstracts
{
    public interface IOrderService
    {
        public void Add(Order order);
        public void Update(Order order);
        public void Delete(int id);
        public List<Order> GetAll();
        public Order GetById(int id);
        public Order GetByTableId(int tableId);
        public Order GetByTableId(int tableId, bool orderIsActive);

    }
}
