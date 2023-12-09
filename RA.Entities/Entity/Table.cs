using RA.Entities.Abstract;

namespace RA.Entities.Entity
{
    public class Table : EntityAbstract
    {
        public string TableName { get; set; }
        public string? Description { get; set; }

        public List<Order> Orders { get; set; }
    }
}
