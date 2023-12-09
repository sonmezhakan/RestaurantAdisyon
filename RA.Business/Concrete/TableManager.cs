using RA.Business.Abstract;
using RA.Core.Concrete;
using RA.Entities.Entity;

namespace RA.Business.Concrete
{
    public class TableManager : BaseRepository<Table>, ITableService<Table>
    {
        BaseRepository<Table> baseRepository = new BaseRepository<Table>();
        public bool GetByTableName(string tableName)
        {
            return baseRepository.GetAll().Any(x => x.TableName == tableName);
        }
    }
}
