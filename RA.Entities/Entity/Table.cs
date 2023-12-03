using RA.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.Entities.Entity
{
    public class Table:EntityAbstract
    {
        public string TableName { get; set; }
        public string? Description { get; set; }

        public List<Order> Orders { get; set; }
    }
}
