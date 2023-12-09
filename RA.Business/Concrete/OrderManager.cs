using RA.Business.Abstract;
using RA.Core.Concrete;
using RA.Entities.Entity;

namespace RA.Business.Concrete
{
    public class OrderManager : BaseRepository<Order>, IOrderService<Order>
    {
        BaseRepository<Order> baseRepository = new BaseRepository<Order>();
        public Order GetByTableId(int tableId)
        {
            return baseRepository.GetAll().FirstOrDefault(x => x.TableId == tableId);
        }

        public Order GetByTableId(int tableId, bool orderIsActive)
        {
            return baseRepository.GetAll().FirstOrDefault(x => x.TableId == tableId && x.IsActive == orderIsActive);
        }
    }
}
