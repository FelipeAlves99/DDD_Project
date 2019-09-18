using DDD.Domain.Entities;
using DDD.Domain.Interfaces.IRepository;
using DDD.Domain.Interfaces.IService.OrderServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.Services.OrderService
{
    public class UpdateOrderService : IUpdateOrderService
    {
        private IOrderRepository _orderRepository;

        public UpdateOrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        void IUpdateOrderService.UpdateOrderService(Order order)
        {
            _orderRepository.PatchOrder(order);
        }
    }
}
