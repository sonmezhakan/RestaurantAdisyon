using RA.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.Entities.Entity
{
    public class AppUser : BaseEntity
    {

        public string UserName { get; set; }
        public string Password { get; set; }

        //Relational Properties
        public virtual Employee Employee { get; set; }
        public virtual List<Category> Categories { get; set; }
        public virtual List<Product> Products { get; set; }
        public virtual List<Order> Orders { get; set; }
        public virtual List<Supplier> Suppliers { get; set; }
        public virtual List<Stock> Stocks { get; set; }
    }
}
