using RA.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.Entities.Entity
{
    public class Stock:EntityAbstract
    {
        public int ProductID { get; set; }
        public int SupplierID { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        public Product Product { get; set; }
        public Supplier Supplier { get; set; }
        public AppUser CreatedUser { get; set; }

    }
}
