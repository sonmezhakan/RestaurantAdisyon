﻿using RA.Entities.Abstract;

namespace RA.Entities.Entity
{
    public class OrderDetail : EntityAbstract
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public byte Quantity { get; set; }
        public decimal? Discount { get; set; }

        public Product Product { get; set; }
        public Order Order { get; set; }
    }
}
