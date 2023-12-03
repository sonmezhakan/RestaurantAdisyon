using RA.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.Entities.Entity
{
    public class Category:ChampaingAbstract
    {
        public string CategoryName { get; set; }
        public string? Desription { get; set; }

        public AppUser CreatedUser { get; set; }
        public List<Product> Products { get; set; }
    }
}
