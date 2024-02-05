using RA.Business.ManagerService.Abstracts;
using RA.DataAccess.Repositories.Abstracts;
using RA.Entities.Entity;
using System.Security.Cryptography.X509Certificates;

namespace RA.Business.ManagerService.Concretes
{
    public class TableManager : ITableService
    {
        private readonly ITableDal _tableDal;

        public TableManager(ITableDal tableDal)
        {
            _tableDal = tableDal;
        }
        public void Add(Table table)
        {
            if (!_tableDal.FirstOrDefaultBool(x=>x.TableName == table.TableName))
            {
                _tableDal.Add(table);
            }
        }
        public void Update(Table table)
        {
            if (_tableDal.FirstOrDefaultBool(x=>x.ID == table.ID))
            {
                _tableDal.Update(table);
            }
        }
        public void Delete(int id)
        {
            var getTable = _tableDal.FirstOrDefault(x => x.ID == id);
            if (getTable != null)
            {
                _tableDal.Delete(getTable);
            }
        }

        public List<Table> GetAllComboBox()
        {
            return _tableDal.GetAll().Select(x => new Table
            {
                ID = x.ID,
                TableName = x.TableName
            }).ToList();
        }

        public Table GetById(int id)
        {
            return _tableDal.FirstOrDefault(x => x.ID == id);
        }

        public bool GetByTableName(string tableName)
        {
            return _tableDal.FirstOrDefaultBool(x => x.TableName == tableName);
        }

        public List<Table> GetAll()
        {
            return _tableDal.GetAll();
        }
    }
}
