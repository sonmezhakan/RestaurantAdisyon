using RA.Business.ManagerService.Abstracts;
using RA.DataAccess.Repositories.Abstracts;
using RA.Entities.Entity;
using System.Security.Cryptography.X509Certificates;

namespace RA.Business.ManagerService.Concretes
{
    public class TableManager :BaseManager<Table>, ITableManager
    {
        private readonly ITableRepository _tableRepository;

        public TableManager(ITableRepository tableRepository):base(tableRepository)
        {
            _tableRepository = tableRepository;
        }
        public void Add(Table table)
        {
            if (!_tableRepository.FirstOrDefaultBool(x=>x.TableName == table.TableName))
            {
                _tableRepository.Add(table);
            }
        }
        public void Update(Table table)
        {
            if (_tableRepository.FirstOrDefaultBool(x=>x.ID == table.ID))
            {
                _tableRepository.Update(table);
            }
        }
        public void Delete(int id)
        {
            var getTable = _tableRepository.FirstOrDefault(x => x.ID == id);
            if (getTable != null)
            {
                _tableRepository.Delete(getTable);
            }
        }

        public List<Table> GetAllComboBox()
        {
            return _tableRepository.GetAll().Select(x => new Table
            {
                ID = x.ID,
                TableName = x.TableName
            }).ToList();
        }

        public Table GetById(int id)
        {
            return _tableRepository.FirstOrDefault(x => x.ID == id);
        }

        public bool GetByTableName(string tableName)
        {
            return _tableRepository.FirstOrDefaultBool(x => x.TableName == tableName);
        }
    }
}
