using DDD.Domain.Entities;
using DDD.Domain.Interfaces.IRepository;
using DDD.Domain.Interfaces.IService.OrderServices;

namespace DDD.Domain.Services.OrderService
{
    public class AddOrderService : IAddOrderService
    {
        private IOrderRepository _orderRepository;

        public AddOrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        int IAddOrderService.AddOrderService(Order order)
        {
            return _orderRepository.PostOrder(order);
        }
    }
}
