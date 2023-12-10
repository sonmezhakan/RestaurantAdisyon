using RA.Business.Abstract;
using RA.Core.Concrete;
using RA.Entities.Entity;

namespace RA.Business.Concrete
{
    public class TableManager : BaseRepository<Table>, ITableService<Table>
    {
        BaseRepository<Table> baseRepository = new BaseRepository<Table>();

        public List<Table> GetAllComboBox()
        {
            return baseRepository.GetAll().Select(x=>new Table
            {
                ID = x.ID,
                TableName = x.TableName
            }).ToList();
        }

        public bool GetByTableName(string tableName)
        {
            return baseRepository.GetAll().Any(x => x.TableName == tableName);
        }
    }
}
