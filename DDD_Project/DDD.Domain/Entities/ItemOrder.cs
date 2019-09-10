using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.Entities
{
    public class ItemOrder
    {
        public int OrderId { get; set; }
        public int ItemId { get; private set; }
        public int Quantity { get; private set; }
        public decimal TotalLineValue { get; private set; }
        
        public Order Order { get; set; }

        public Item Item { get; set; }
    }
}
