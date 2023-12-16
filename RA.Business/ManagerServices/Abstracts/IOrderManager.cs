using RA.Entities.Entity;

namespace RA.Business.ManagerService.Abstracts
{
    public interface IOrderManager:IManager<Order>
    {
        public Order GetById(int id);
        public Order GetByTableId(int tableId);
        public Order GetByTableId(int tableId, bool orderIsActive);

    }
}
