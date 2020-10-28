using DDD.Domain.Entities;
using DDD.Domain.Interfaces.IRepository;
using DDD.Domain.Interfaces.IService;
using System.Collections.Generic;

namespace DDD.Domain.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public int AddOrderService(Order order)
            => _orderRepository.PostOrder(order);

        public IList<Order> GetAllOrder()
            => _orderRepository.GetAllOrder();

        public IList<Order> GetOrderByCompanyId(int companyId)
            => _orderRepository.GetAllOrderByCompany(companyId);

        public Order GetOrderById(int orderId)
            => _orderRepository.GetOrderById(orderId);

        public void UpdateOrderService(Order order)
            => _orderRepository.PatchOrder(order);
    }
}
