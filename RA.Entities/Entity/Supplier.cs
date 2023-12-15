using RA.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.Entities.Entity
{
    public class Supplier:EntityAbstract
    {
        public string CompanyName { get; set; }
        public string? ContactName { get; set; }
        public char PhoneNumber { get; set; }
        public string Adress { get; set; }

        public AppUser CreatedUser { get; set; }
        public List<Stock> Stocks { get; set; }
    }
}
