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

        public int EmployeeID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        //Relational Properties
        public virtual Employee Employee { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public List<Order> Orders { get; set; }
        public List<Supplier> Suppliers { get; set; }
        public List<Stock> Stocks { get; set; }
    }
}
