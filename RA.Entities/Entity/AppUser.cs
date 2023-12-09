using RA.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.Entities.Entity
{
    public class AppUser : EntityAbstract
    {
        public int EmployeeID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public Employee Employee { get; set; }
        //public AppUser CreatedUser { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public List<Order> Orders { get; set; }
    }
}
