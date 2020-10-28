using DDD.Domain.Entities;
using System.Collections.Generic;

namespace DDD.Domain.Interfaces.IService
{
    public interface IOrderService
    {
        IList<Order> GetAllOrder();
        IList<Order> GetOrderByCompanyId(int companyId);
        Order GetOrderById(int orderId);
        void UpdateOrderService(Order order);
        int AddOrderService(Order order);
    }
}
