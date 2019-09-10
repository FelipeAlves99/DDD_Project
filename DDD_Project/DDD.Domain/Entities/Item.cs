using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.Entities
{
    public class Item
    {
        public int Id { get; private set; }
        public string Description { get; private set; }
        public decimal BuyValue { get; private set; }
        public decimal SellValue { get; private set; }
        public int StorageQuantity { get; private set; }

        public IList<ItemOrder> ItemOrder { get; set; }
    }
}
