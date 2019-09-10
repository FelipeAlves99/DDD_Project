using DDD.Domain.Entities.CompanyEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.Entities
{
    public class Order
    {
        public int Id { get; private set; } = 0;
        public DateTime OrderDate { get; private set; } = DateTime.Today;
        public DateTime OrderDelivery { get; private set; }
        public OrderStatus Status { get; private set; }
        public decimal OrderValue { get; private set; }
        public decimal Discount { get; private set; } = 0;
        public decimal ValueDiscounted { get; private set; }

        public IList<ItemOrder> ItemOrder { get; private set; }

        public int CompanyId { get; private set; }

        public Company Company { get; set; }

        public enum OrderStatus
        {
            Aberto,
            Entregue,
            Fechado,
            Cancelado
        }
    }
}
