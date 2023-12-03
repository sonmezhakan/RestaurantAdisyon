using RA.BusinessLogic.Abstract;
using RA.BusinessLogic.Core.Concrete;
using RA.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.BusinessLogic.Concrete
{
    public class TableRepository : BaseRepository<Table>, ITableRepository<Table>
    {
        BaseRepository<Table> baseRepository = new BaseRepository<Table>();
        public bool GetByTableName(string tableName)
        {
            return baseRepository.GetAll().Any(x => x.TableName == tableName);
        }
    }
}
