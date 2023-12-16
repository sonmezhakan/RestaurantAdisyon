using RA.Entities.Interfaces;

namespace RA.Entities.Entity
{
    public class Table : BaseEntity
    {
        public string TableName { get; set; }
        public string? Description { get; set; }

        public List<Order> Orders { get; set; }
    }
}
