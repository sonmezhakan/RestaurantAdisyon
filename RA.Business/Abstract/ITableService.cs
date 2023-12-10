namespace RA.Business.Abstract
{
    public interface ITableService<Table>
    {
        public void Add(Table table);
        public void Update(Table table);
        public void Delete(int id);
        public List<Table> GetAll();
        public List<Table> GetAllComboBox();
        public Table GetById(int id);
        public bool GetByTableName(string tableName);
    }
}
