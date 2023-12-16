using RA.Entities.Entity;

namespace RA.Business.ManagerService.Abstracts
{
    public interface ITableManager:IManager<Table>
    {
        public List<Table> GetAllComboBox();
        public Table GetById(int id);
        public bool GetByTableName(string tableName);

    }
}
