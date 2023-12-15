using RA.Entities.Abstract;

namespace RA.Entities.Entity
{
    public class Product : ChampaingAbstract
    {
        public int CategoryID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        public AppUser CreatedUser { get; set; }
        public Category Category { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public List<Stock> Stocks { get; set; }
    }
}
