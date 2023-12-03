using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.BusinessLogic.Abstract
{
    public interface ITableRepository<Table>
    {
        public void Add(Table table);
        public void Update(Table table);
        public void Delete(int id);
        public List<Table> GetAll();
        public Table GetById(int id);
        public bool GetByTableName(string tableName);

    }
}
