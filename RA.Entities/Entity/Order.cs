using RA.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.Entities.Entity
{
    public class Order:EntityAbstract
    {
        public int? TableId { get; set; }
        public DateTime OrderDate { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
        public AppUser CreatedUser { get; set; }
        public Table Table { get; set; }
    }
}
